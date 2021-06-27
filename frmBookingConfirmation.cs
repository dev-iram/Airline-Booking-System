using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Cyanair_Airline_Booking_System
{
    public partial class frmBookingConfirmation : Form
    {
        //DATABASE CONNECTION
        public CyanairDataConnection myNewCyanDatabaseConnection;
        public SystemUsers mySystemUsers;
        public FlightRoute OutboundFlight01;
        public FlightRoute OutboundFlight02;
        public Bookings newBookingObject;
        public string BookingReference = "";

        public frmBookingConfirmation()
        {
            InitializeComponent();
        }

        /*=====================CREATE NEW BOOKING BUTTON=========================*/
        private void btnCreateNewBooking_Click(object sender, EventArgs e)
        {//opens booking system
            Cyanair BookingSystem = new Cyanair();
            BookingSystem.ShowDialog();
            this.Close();
            this.Dispose();
        }

        /*=======================CLOSE PROGRAM BUTTON============================*/
        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void frmBookingConfirmation_Load(object sender, EventArgs e)
        {
            /* DOES NOT WORK
             * WAS TRYING TO MAKE VALIDATION TO HIDE THE LEG 2 PANEL IF FLIGHT IS ONLY ONE WAY */
            //if the outboundflight two object exists then display the panel 
            /*
            if (OutboundFlight02 != null)
            {
                pnlFlight2.Visible = true;
            }
            */
            /*=====================FULLSCREEN/CENTER PROGRAM========================*/
            //Maximise the screen
            this.WindowState = FormWindowState.Maximized;

            //Set Panel to Center of Screen - Fullscreen centered
            pnlBookingConfirmation.Left = (this.ClientSize.Width - pnlBookingConfirmation.Size.Width) / 2;

            /*FILLING IN INFO STORED FROM OBJECTS IN THE CONFIRMATION PAGE SO THE USER CAN VIEW DETAILS!
             * THEN THEY NEED TO CLICK THE CREATE BOOKING BUTTON AFTER THEY CONFIRM ! */


            /* LEG 1 FLIGHT */
            lblLeg1.Text = "Leg 1 - " + "Flight Number: " + OutboundFlight01.FlightNo;
            txtTimeLeg1.Text = OutboundFlight01.TimeOfFlight;
            txtDepartureLeg1.Text = OutboundFlight01.DepartAirportName;
            txtDestinationLeg1.Text = OutboundFlight01.DestinAirportName;
            txtTypeOfSeatLeg1.Text = OutboundFlight01.SeatTypeBooked;
            txtDateLeg1.Text = OutboundFlight01.DateOfFlight.Substring(0, 10);
            txtDurationLeg1.Text = OutboundFlight01.Duration + " Minutes";


            /*LEG 2 FLIGHT */
            lblLeg2.Text = "Leg 2 - " + "Flight Number: " + OutboundFlight02.FlightNo;
            txtTimeLeg2.Text = OutboundFlight02.TimeOfFlight;
            txtDepartureLeg2.Text = OutboundFlight02.DepartAirportName;
            txtDestinationLeg2.Text = OutboundFlight02.DestinAirportName;
            txtTypeOfSeatLeg2.Text = OutboundFlight02.SeatTypeBooked;
            txtDateLeg2.Text = OutboundFlight02.DateOfFlight.Substring(0, 10);
            txtDurationLeg2.Text = OutboundFlight02.Duration + " Minutes";

            /*PASSENGER DETAILS ! */
            txtFullName.Text = newBookingObject.fullname;
            txtPassportNumber.Text = newBookingObject.passportnumber;
            txtNationality.Text = newBookingObject.nationality;
            txtPhoneNumber.Text = newBookingObject.phonenumber;
            txtEmailAddress.Text = newBookingObject.emailaddress;
            txtGender.Text = newBookingObject.gender;

            //txtBookingReference = newBookingObject.BookingReference;
        }

        private void btnMakeBooking_Click(object sender, EventArgs e)
        {

            //IF all fields are completed, the system will ask the flight representative to confirm the booking 
            //if YES --> proceeds to confirmation screen where it will generate a reference number
            //if NO --> returns back to edit form. [cancel]
            DialogResult dialogResult = MessageBox.Show(null, "Are you sure you want to proceed creating this booking?", "Cyanair: Confirm Booking", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)

            {
                //THIS IS WHERE YOU CODE THE BOOKING REFERENCE NUMBER IF THE USER SELECTS YES !
                //HIDE AND UNHIDE PANELS/! 
                pnlBookingReference.Visible = true;
                pnlMakeBooking.Visible = false;






                //NOW THE BOOKING REFERENCE HAS BEEN GENERATED
                //USER HAS CONFIRMED THEY WANT THE BOOKING
                //NOW PUSH DATA INTO DATABASE !

                //*************************************************************************************

        

                txtBookingReference.Text = myNewCyanDatabaseConnection.InsertNewBooking(OutboundFlight01,OutboundFlight02,newBookingObject,mySystemUsers);
                MessageBox.Show(null, "Your data has been stored in the database!", "Cyanair: Confirm Booking -" + txtBookingReference.Text);

                //insert info into sql string
                /*
                string mySQLCommandString;
                //creating a new guid so it can be inserted into the database
                Guid myPassengerDetailsGuid = Guid.NewGuid();
                myNewCyanDatabaseConnection.openDB();
                mySQLCommandString = @"INSERT INTO PassengerDetails (Guid,PassengerFullName,PassportNumber,Nationality,
                                                                    PhoneNumber,EmailAddress,Gender WHERE deleted=0) VALUES ('"
                                                                     + myPassengerDetailsGuid.ToString() + "','"
                                                                     + txtFullName.Text + "','"
                                                                     + txtPassportNumber.Text + "','"
                                                                     + txtNationality.Text + "','"
                                                                     + txtPhoneNumber.Text + "','"
                                                                     + txtEmailAddress.Text + "','"
                                                                     + txtGender.Text + "')";
                SQLiteCommand sqlInsertNewPassenger = new SQLiteCommand(mySQLCommandString , myNewCyanDatabaseConnection.CyanairDBconn);
                sqlInsertNewPassenger.ExecuteNonQuery();



               // OutboundFlight01.DepartureAirport_guid


                    //OutboundFlight02.DepartureAirport_guid

                //"Leg1FlightDate"    TEXT,
                //"Leg2FlightDate"    TEXT,
                //"Leg1FlightTime"    NUMERIC,
                //"Leg2FlightTime"    NUMERIC,
                //"PassengerDetails_Guid" TEXT,
                //"DateOfBooking" TEXT,
                //"BookedByUser_Guid" TEXT,
                //"Leg1FlightNo"  TEXT,
                //"Leg2FlightNo"  TEXT,
                //"Deleted"   NUMERIC DEFAULT 0

                //Guid myBookingsGuid = Guid.NewGuid();
                //mySQLCommandString = @"INSERT INTO Booking (Guid,BookingReference,DepartureLeg1Airport_Guid,DestinationLeg1Airport_Guid,DepartureLeg2Airport_Guid,DestinationLeg2Airport_Guid) 
                                                                    
                //                                                                            VALUES ('"
                //                                                     + myBookingsGuid.ToString() + "','"
                //                                                     + BookingReference + "','"
                //                                                     +  + "','"
                //                                                     + DestinationLeg1Airport_Guid + "','"
                //                                                     + DepartureLeg2Airport_Guid + "','"
                //                                                     + DestinationLeg2Airport_Guid + "','"
                //                                                     + OutboundFlight01.DateOfFlight + "','"
                //                                                     + OutboundFlight02.DateOfFlight + "','"
                //                                                     + OutboundFlight01.TimeOfFlight + "','"
                //                                                     + OutboundFlight02.TimeOfFlight + "','"
                //                                                     + myPassengerDetailsGuid.ToString() + "','"
                //                                                     + DateTime.Now.ToString("dd/MM/yyyy") + "','"
                //                                                     + mySystemUsers.BookedByUser_Guid + "','"
                //                                                     + OutboundFlight01.FlightNo + "','"
                //                                                     + OutboundFlight02.FlightNo + "')";


                //SQLiteCommand sqlInsertBooking = new SQLiteCommand(mySQLCommandString, myNewCyanDatabaseConnection.CyanairDBconn);
                //sqlInsertBooking.ExecuteNonQuery();
                //MessageBox.Show(null, "Your data has been stored in the database!", "Cyanair: Confirm Booking");
                */
            }
        }

        private void pnlBookingConfirmation_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pnlFlight2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grpFlightDetails_Enter(object sender, EventArgs e)
        {

        }

        private void cbxTermsConditions_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as CheckBox).Checked)
            {
                btnMakeBooking.Enabled = true;
            }
            else
            {
                btnMakeBooking.Enabled = false;
            }
        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }


        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp Help = new frmHelp();
            Help.ShowDialog();
        }
    }
}
