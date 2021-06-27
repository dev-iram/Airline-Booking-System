using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SQLite;
using System.Data;
using System.Data.SqlClient;
using System.Data.Entity.Core.Metadata.Edm;
using System.Windows.Forms;
//using System.Windows.Forms;

namespace Cyanair_Airline_Booking_System
{
    public class CyanairDataConnection
    {

        static string myDataSource = @"Data Source = C:\\data\\Cyanair.db";
        public bool ableToConnect = false;
        public string FileFailed;
        public FlightRoute OutboundFlight01;
        public FlightRoute OutboundFlight02;
    //    public PassengerDetails OutboundFlight01;
    //    public PassengerDetails OutboundFlight02;
        public PassengerDetails newBookingObject;
        public SystemUsers mySystemUsers;
        public string BookingReference;



        //SQL DATA CONNECTION TO THE SQLITEDATABASE USING THE SQLCONNECTION COMPONENT
        public SQLiteConnection CyanairDBconn = new SQLiteConnection(myDataSource);

        //DATASET THAT WILL HOLD DATATABLES
        public DataSet CyanairDataSet = new DataSet();

        //SQL ADAPTER
        public SQLiteDataAdapter CyanairDataAdapter = new SQLiteDataAdapter();

        //DATATABLE
        private DataTable CyanairDataTable = new DataTable();



        //connection constructor
        public CyanairDataConnection(string myDatabaseFile)
        {
            if (File.Exists(myDatabaseFile))
            {
                myDataSource += myDatabaseFile;
                ableToConnect = true;
            }
            else
            {
                FileFailed = myDatabaseFile;

                /*
                System.Windows.Forms.MessageBox.Show("This program could not load the required database file. The database file should be " +
                "located in the path = C:\\Data\\Cyanair.db. Please locate the file and try again.", "WARNING - MISSING FILE");
                //CLOSES THE ENTIRE PROGRAM IF THERE IS NO DATABASE FILE
                Environment.Exit(0); */
            }
        }

        //checks if connection is open method
        //use this when we want to write soemthing to the database we will check and run this method!!
        //checks if the state of db is open
        //prevents accidentally opening an open DB
        //if the DB is closed, it will open it
        //if it is open it will leave the DB open
        public void openDB()
        {
            if (CyanairDBconn.State != System.Data.ConnectionState.Open)
            {
                CyanairDBconn.Open();
            }

        }

        //this method CLOSES the DB
        public void closeDB()
        {
            if (CyanairDBconn.State == System.Data.ConnectionState.Open)
            {
                CyanairDBconn.Close();
            }

        }

        //FUNCTION TO FILL COMBOBOX WITH THE DESTINATION/DEPARTURE AIRPORT LEG 1 AND LEG 2 
        public void AirportDataFromDBWithFilter(string ExcludeAirportFromList, string SelectedTable)
        {

            if (CyanairDataSet.Tables.Contains(SelectedTable))
            {
                CyanairDataSet.Tables.Remove(SelectedTable);
            }

            this.openDB(); //opens the database if not already opened ! makes sure its available
            string mySQLcommandstring = "SELECT * from Airport WHERE Guid != '"+ ExcludeAirportFromList + "' ORDER BY Airport ;";
            CyanairDataAdapter = new SQLiteDataAdapter(mySQLcommandstring, this.CyanairDBconn);

            CyanairDataAdapter.Fill(CyanairDataSet, SelectedTable);
        }


        //FUNCTION TO FILL COMBOBOX WITH THE DESTINATION/DEPARTURE AIRPORT LEG 1 AND LEG 2 
        public void AirportDataFromDB()
        {
            this.openDB(); //opens the database if not already opened ! makes sure its available
            string mySQLcommandstring = "SELECT * from Airport ORDER BY Airport ;";
            CyanairDataAdapter = new SQLiteDataAdapter(mySQLcommandstring, this.CyanairDBconn);

            CyanairDataAdapter.Fill(CyanairDataSet, "DepartureLeg1Airport");
            CyanairDataAdapter.Fill(CyanairDataSet, "DestinationLeg1Airport");
            CyanairDataAdapter.Fill(CyanairDataSet, "DepartureLeg2Airport");
            CyanairDataAdapter.Fill(CyanairDataSet, "DestinationLeg2Airport");
        }
        //FUNCTION TO FILL COMBOBOX WITH THE TYPE OF SEATS AVAILABLE
        public void TypeOfSeatsData()
        {
            this.openDB(); //opens the database if not already opened ! makes sure its available
            string mySQLcommandstring = "SELECT * from SeatClass ;";
            CyanairDataAdapter = new SQLiteDataAdapter(mySQLcommandstring, this.CyanairDBconn);

            CyanairDataAdapter.Fill(CyanairDataSet, "ClassTypeLeg1");
            CyanairDataAdapter.Fill(CyanairDataSet, "ClassTypeLeg2");
        }
  
        
         //LOGIN METHOD FUNCTION
         public bool Login(string UserName, string Passwordy,SystemUsers mySystemUsers)
         {

            bool CanAccess = false;

            this.openDB(); //opens the database if not already opened ! makes sure its available
            
            string mySQLcommandstring = "SELECT Guid,Role FROM Users WHERE Username='"+ UserName + "' AND Password='"+ Passwordy + "';";
            DataTable loginDt = new DataTable();

            CyanairDataAdapter = new SQLiteDataAdapter(mySQLcommandstring, this.CyanairDBconn);
            
            CyanairDataAdapter.Fill(loginDt);

             if (loginDt.Rows.Count  > 0) //> 1
             {
                // MessageBox.Show("You have logged in ! ");

                mySystemUsers.BookedByUser_Guid = loginDt.Rows[0].ItemArray[0].ToString();
                mySystemUsers.UserRole = loginDt.Rows[0].ItemArray[1].ToString();

                CanAccess = true;

            }


             this.closeDB();

            return CanAccess;



         }


        public void InsertPassengerDetails(PassengerDetails LocalPassengerObject)
        {

        }
        
        public string InsertNewBooking(FlightRoute OutboundFlight01, FlightRoute OutboundFlight02, Bookings newBookingObject, SystemUsers mySystemUsers)
        {

            string myNewBookingRef = newBookingObject.CreateNewBookingReference();

            this.openDB();
            //creating a new guid so it can be inserted into the database
            Guid myPassengerDetailsGuid = Guid.NewGuid();
            string mySQLCommandString = @"INSERT INTO PassengerDetails (Guid,PassengerFullName,PassportNumber,Nationality,
                                                                    PhoneNumber,EmailAddress,Gender) VALUES ('"
                                                                     + myPassengerDetailsGuid.ToString() + "','"
                                                                     + newBookingObject.fullname + "','"
                                                                     + newBookingObject.passportnumber + "','"
                                                                     + newBookingObject.nationality + "','"
                                                                     + newBookingObject.phonenumber + "','"
                                                                     + newBookingObject.emailaddress + "','"
                                                                     + newBookingObject.gender + "')";
            CyanairDataAdapter = new SQLiteDataAdapter(mySQLCommandString, this.CyanairDBconn);
            SQLiteCommand sqlInsertNewPassenger = new SQLiteCommand(mySQLCommandString, CyanairDBconn);
            sqlInsertNewPassenger.ExecuteNonQuery();

            

            this.openDB();
            Guid myBookingsGuid = Guid.NewGuid();
             mySQLCommandString = @"INSERT INTO Booking (Guid,BookingReference,DepartureLeg1Airport_Guid,DestinationLeg1Airport_Guid,
                                                                DepartureLeg2Airport_Guid,DestinationLeg2Airport_Guid,
                                                                Leg1FlightDate,Leg2FlightDate,Leg1FlightTime,Leg2FlightTime,PassengerDetails_Guid,
                                                                DateOfBooking,BookedByUser_Guid,Leg1FlightNo,Leg2FlightNo) 
                                                                    VALUES ('"
                                                                   + myBookingsGuid.ToString() + "','"
                                                                   + myNewBookingRef  + "','"
                                                                   + OutboundFlight01.DepartureAirport_guid + "','"
                                                                   + OutboundFlight01.DestinationAirport_guid + "','"
                                                                   + OutboundFlight02.DepartureAirport_guid + "','"
                                                                   + OutboundFlight02.DestinationAirport_guid + "','"

                                                                   + OutboundFlight01.DateOfFlight + "','"
                                                                   + OutboundFlight02.DateOfFlight + "','"
                                                                   + OutboundFlight01.TimeOfFlight + "','"
                                                                   + OutboundFlight02.TimeOfFlight + "','"
                                                                   + myPassengerDetailsGuid.ToString() + "','"
                                                                   + DateTime.Now.ToString("dd/MM/yyyy") + "','"
                                                                   + mySystemUsers.BookedByUser_Guid + "','"
                                                                   + OutboundFlight01.FlightNo + "','"
                                                                   + OutboundFlight02.FlightNo + "')";

           CyanairDataAdapter = new SQLiteDataAdapter(mySQLCommandString, this.CyanairDBconn);
           SQLiteCommand sqlInsertNewBooking = new SQLiteCommand(mySQLCommandString, CyanairDBconn);
           sqlInsertNewBooking.ExecuteNonQuery();
           

            return myNewBookingRef;
        }




        //CHECKING FLIGHT AVAILABILITY FUNCTION
        public bool FlightAvailability(FlightRoute myFlightRoutetoCheck)
        {

            DataTable dt = new DataTable();
            bool FlightisOK = false;
            string myDateOnly = myFlightRoutetoCheck.DateOfFlight.Substring(0, 10); // 12/06/2020


            this.openDB(); //opens the database if not already opened ! makes sure its available
            string mySQLcommandstring = @"SELECT Uid,FlightNo,TimeOfFlight,Duration FROM FlightRoute " +
                                    " WHERE " +
                                    "DepartureAirport_Guid='" + myFlightRoutetoCheck.DepartureAirport_guid + "'  AND " +
                                    "DestinationAirport_Guid='" + myFlightRoutetoCheck.DestinationAirport_guid + "' AND " +
                                    "DateOfFlight='" + myDateOnly + "'" + 
                                    "; ";
            CyanairDataAdapter = new SQLiteDataAdapter(mySQLcommandstring, this.CyanairDBconn);

            CyanairDataAdapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                FlightisOK = true;
                myFlightRoutetoCheck.FlightNo = dt.Rows[0].ItemArray[1].ToString();
                myFlightRoutetoCheck.TimeOfFlight = dt.Rows[0].ItemArray[2].ToString();
                myFlightRoutetoCheck.Duration = dt.Rows[0].ItemArray[3].ToString();

            }

            return FlightisOK;

        }


        public string GetAirportfromGUID(string AirportGuid)
        {

            DataTable dt = new DataTable();
            this.openDB(); //opens the database if not already opened ! makes sure its available
            string mySQLcommandstring = "SELECT * from Airport WHERE Guid='" + AirportGuid  + "' ;";
            CyanairDataAdapter = new SQLiteDataAdapter(mySQLcommandstring, this.CyanairDBconn);

            CyanairDataAdapter.Fill(dt);
            //FILLS IN THE FORM WITH THE AIRPORT NAME AND CODE !
            return dt.Rows[0].ItemArray[2].ToString() + " (" + dt.Rows[0].ItemArray[3].ToString() + ")";
        }




    }
}

