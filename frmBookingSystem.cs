using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyanair_Airline_Booking_System
{
    public partial class Cyanair : Form
    {
        //DATABASE CONNECTION
        public CyanairDataConnection myNewCyanDatabaseConnection;
        public SystemUsers mySystemUsers;

        public FlightRoute OutboundFlight01 = new FlightRoute();
        public FlightRoute OutboundFlight02 = new FlightRoute();
   




        public Cyanair()
        {
            InitializeComponent();
        }

        private void frmBookingSystem_Load(object sender, EventArgs e)
        {
            
            if (rbtReturn.Checked == true)
            {
                btnNext.Enabled = false;
            }
            if (rbtOnwardLeg.Checked == true)
            {
                btnNext.Enabled = false;
            }




            //Maximise the screen
            this.WindowState = FormWindowState.Maximized;

            //Set Panel to Center of Screen - Fullscreen centered
            pnlBookingSystem.Left = (this.ClientSize.Width - pnlBookingSystem.Size.Width) / 2;


            /*FILLING THE COMBOXES WITH INFORMATION FROM DATABASE!!!*/
            //CALLS FUNCTION FROM CYANAIRDATACONNECTION.DS ! FILLS THE COMBOBOXES
            myNewCyanDatabaseConnection.AirportDataFromDB();


            //LEG 1 DEPARTURE
            cmbDepartureLeg1.DataSource = myNewCyanDatabaseConnection.CyanairDataSet.Tables["DepartureLeg1Airport"];
            cmbDepartureLeg1.DisplayMember = "Airport";
            cmbDepartureLeg1.ValueMember = "Guid";

            //LEG 1 DESTINATION
            cmbDestinationLeg1.DataSource = myNewCyanDatabaseConnection.CyanairDataSet.Tables["DestinationLeg1Airport"];
            cmbDestinationLeg1.DisplayMember = "Airport";
            cmbDestinationLeg1.ValueMember = "Guid";


            myNewCyanDatabaseConnection.TypeOfSeatsData();
            //LEG 1 CLASS / TYPE OF SEATS 
            cmbTypeOfSeatLeg1.DataSource = myNewCyanDatabaseConnection.CyanairDataSet.Tables["ClassTypeLeg1"];
            cmbTypeOfSeatLeg1.DisplayMember = "details";
            cmbTypeOfSeatLeg1.ValueMember = "Guid";

            /*---------------------------------------------*/
            //LEG 2 DEPARTURE
            cmbDepartureLeg2.DataSource = myNewCyanDatabaseConnection.CyanairDataSet.Tables["DestinationLeg1Airport"];
            cmbDepartureLeg2.DisplayMember = "Airport";
            cmbDepartureLeg2.ValueMember = "Guid";

            //LEG 2 DESTINATION
            cmbDestinationLeg2.DataSource = myNewCyanDatabaseConnection.CyanairDataSet.Tables["DestinationLeg2Airport"];
            cmbDestinationLeg2.DisplayMember = "Airport";
            cmbDestinationLeg2.ValueMember = "Guid";

           
            //LEG 2 CLASS / TYPE OF SEATS 
            cmbTypeOfSeatLeg2.DataSource = myNewCyanDatabaseConnection.CyanairDataSet.Tables["ClassTypeLeg2"];
            cmbTypeOfSeatLeg2.DisplayMember = "details";
            cmbTypeOfSeatLeg2.ValueMember = "Guid";


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            frmPassengerDetails PassengerDetails = new frmPassengerDetails();
            //DATABASE CONNECTION
           PassengerDetails.myNewCyanDatabaseConnection = myNewCyanDatabaseConnection;
           PassengerDetails.mySystemUsers = mySystemUsers;


            PassengerDetails.OutboundFlight01 = OutboundFlight01;
            PassengerDetails.OutboundFlight02 = OutboundFlight02;




            PassengerDetails.ShowDialog();
            this.Close();
 
        }

        private void btnSearchAvailabilityFlight1_Click(object sender, EventArgs e)
        {

            if (CheckDeptAndDestNameLeg1()) { 

            

                OutboundFlight01.DepartureAirport_guid  = cmbDepartureLeg1.SelectedValue.ToString();
                OutboundFlight01.DestinationAirport_guid = cmbDestinationLeg1.SelectedValue.ToString();
                OutboundFlight01.DateOfFlight = dtpFlightDateLeg1.Value.ToString();
                OutboundFlight01.SeatTypeBooked = cmbTypeOfSeatLeg1.Text;

                OutboundFlight01._FLightValid =  myNewCyanDatabaseConnection.FlightAvailability(OutboundFlight01);

                ///FLIGHT VALIDATION !!!
                if (!OutboundFlight01._FLightValid)
                {
                    lblLeg1.Text = "Select Flight";
                    pnlLeg1.BackColor = System.Drawing.Color.LightSalmon ;
                    btnFlightUnavailable1.Visible = true;
                    btnFlightAvailable1.Visible = false;
                    MessageBox.Show(null, "Sorry, there are no flights available for the date, departure or destination you have selected!", "Cyanair: Affordable Business Travel: Unavailable Flight");
                
                    if (btnFlightUnavailable1.Visible == true)
                    {
                        btnNext.Enabled = false;
                    }

                } else
                {


                    OutboundFlight01.DepartAirportName = myNewCyanDatabaseConnection.GetAirportfromGUID(OutboundFlight01.DepartureAirport_guid);
                    OutboundFlight01.DestinAirportName = myNewCyanDatabaseConnection.GetAirportfromGUID(OutboundFlight01.DestinationAirport_guid);

                    pnlLeg1.BackColor = System.Drawing.Color.LightGreen;
                    btnFlightAvailable1.Visible = true;
                    btnFlightUnavailable1.Visible = false;
                    lblLeg1.Text = "Flight Number: " + OutboundFlight01.FlightNo + " Departure Time: " + OutboundFlight01.TimeOfFlight;

                    if (btnFlightAvailable1.Visible == true)
                    {
                        btnNext.Enabled = true;
                    }
                    else if (pnlLeg2.Visible == true)
                    {
                        btnNext.Enabled = false;
                    }

                } 


            }
        }

        private void dtpFlightDateLeg1_Leave(object sender, EventArgs e)
        {
           // MessageBox.Show(dtpFlightDateLeg1.Value.ToString());
        }

        private void rbtReturn_CheckedChanged(object sender, EventArgs e)
        {
            //shows the panel for return flight
            pnlLeg2.Visible = true;
            lblLeg2.Text = "Return Flight";

            //IF THE FLIGHT IS A RETURN FLIGHT
            //DEPT LEG 2 = DEST LEG 1
            //DEST LEG 2 = DEPT LEG 1
            cmbDepartureLeg2.Text = cmbDestinationLeg1.Text;
            cmbDestinationLeg2.Text = cmbDepartureLeg1.Text;

            //if RETURN flight is clicked, change the destination automatically to leg 1's departure !
           // cmbDestinationLeg2.DataSource = myNewCyanDatabaseConnection.CyanairDataSet.Tables["DepartureLeg1Airport"];
            btnNext.Enabled = false;
            if (btnFlightAvailable2.Visible == true)
            {
                btnNext.Enabled = true;
            }




        }

        private void rbtOneWay_CheckedChanged(object sender, EventArgs e)
        {
            
            //hides panel for one way flight. only one flight can be booked !
            pnlLeg2.Visible = false;

            if (pnlLeg2.Visible == false)
            {
                btnNext.Enabled = true;
            }
        }

        private void rbtOnwardLeg_CheckedChanged(object sender, EventArgs e)
        {
            cmbDepartureLeg2.Text = cmbDestinationLeg1.Text;
            //shows the panel for onward leg ! second flight can be booked !
            pnlLeg2.Visible = true;
            lblLeg2.Text = "Onward Flight";
            btnNext.Enabled = false;
            if (btnFlightAvailable2.Visible == true)
            {
                btnNext.Enabled = true;
            }


        }




        private void btnSearchAvailabilityFlight2_Click(object sender, EventArgs e)
        {
            if (CheckDeptAndDestNameLeg2())
            {
                OutboundFlight02.DepartureAirport_guid = cmbDepartureLeg2.SelectedValue.ToString();
                OutboundFlight02.DestinationAirport_guid = cmbDestinationLeg2.SelectedValue.ToString();
                OutboundFlight02.DateOfFlight = dtpFlightDateLeg2.Value.ToString();
                OutboundFlight02.SeatTypeBooked = cmbTypeOfSeatLeg2.Text;

                OutboundFlight02._FLightValid = myNewCyanDatabaseConnection.FlightAvailability(OutboundFlight02);

                ///FLIGHT VALIDATION !!!
                if (!OutboundFlight02._FLightValid)
                {
                    lblLeg2.Text = "Select Flight";
                    pnlLeg2.BackColor = System.Drawing.Color.LightSalmon;
                    btnFlightUnavailable2.Visible = true;
                    btnFlightAvailable2.Visible = false;
                    MessageBox.Show(null, "Sorry, there are no flights available for the date, departure or destination you have selected!", "Cyanair: Affordable Business Travel: Unavailable Flight");
                    if (btnFlightUnavailable2.Visible == true)
                    {
                        btnNext.Enabled = false;
                    }


                }
                else
                {
                    OutboundFlight02.DepartAirportName = myNewCyanDatabaseConnection.GetAirportfromGUID(OutboundFlight02.DepartureAirport_guid);
                    OutboundFlight02.DestinAirportName = myNewCyanDatabaseConnection.GetAirportfromGUID(OutboundFlight02.DestinationAirport_guid);
                    pnlLeg2.BackColor = System.Drawing.Color.LightGreen;
                    btnFlightAvailable2.Visible = true;
                    btnFlightUnavailable2.Visible = false;
                    lblLeg2.Text = "Flight Number: " + OutboundFlight02.FlightNo + " Departure Time: " + OutboundFlight02.TimeOfFlight;

                    if (btnFlightAvailable2.Visible == true)
                    {
                        btnNext.Enabled = true;
                    }

                }


            }

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp Help = new frmHelp();
            Help.ShowDialog();
        }



        private bool CheckDeptAndDestNameLeg1()
        {
            bool allOk = false;
            if (cmbDestinationLeg1.Text == cmbDepartureLeg1.Text)
            {
                MessageBox.Show("You have made an invalid selection! You cannot select the same departure and destination. Please select a different option before checking for flight availability.");
                cmbDestinationLeg1.Focus();
            }
            else
            {
                allOk = true;
            }
            return allOk;
        }

        private bool CheckDeptAndDestNameLeg2()
        {
            bool allOk = false;
            if (cmbDestinationLeg2.Text == cmbDepartureLeg2.Text)
            {
                MessageBox.Show("You have made an invalid selection! You cannot select the same departure and destination. Please select a different option before checking for flight availability.");
                cmbDestinationLeg2.Focus();
            }
            else
            {
                allOk = true;
            }
            return allOk;
        }


        //this function removes selected item from departure in destination
        // so that the contents cannot be same !
        //cannot fly from same dept and dest on one flight !
        private void cmbDepartureLeg1_SelectedIndexChanged(object sender, EventArgs e)
        {
            myNewCyanDatabaseConnection.AirportDataFromDBWithFilter(cmbDepartureLeg1.SelectedValue.ToString(), "ExcludedAirportLeg1");

            //LEG 1 DESTINATION
            cmbDestinationLeg1.DataSource = myNewCyanDatabaseConnection.CyanairDataSet.Tables["ExcludedAirportLeg1"];
            cmbDestinationLeg1.DisplayMember = "Airport";
            cmbDestinationLeg1.ValueMember = "Guid";


            cmbDestinationLeg1.Enabled = true;
        }

        private void cmbDestinationLeg1_Leave(object sender, EventArgs e)
        {



        }

        private void cmbDestinationLeg1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbDepartureLeg1_Leave(object sender, EventArgs e)
        {


        }

        //this function removes selected item from departure in destination
        // so that the contents cannot be same !
        //cannot fly from same dept and dest on one flight !
        private void cmbDepartureLeg2_SelectedIndexChanged(object sender, EventArgs e)
        {
            myNewCyanDatabaseConnection.AirportDataFromDBWithFilter(cmbDepartureLeg2.SelectedValue.ToString(), "ExcludedAirportLeg2");

            //LEG 1 DESTINATION
            cmbDestinationLeg2.DataSource = myNewCyanDatabaseConnection.CyanairDataSet.Tables["ExcludedAirportLeg2"];
            cmbDestinationLeg2.DisplayMember = "Airport";
            cmbDestinationLeg2.ValueMember = "Guid";


            cmbDestinationLeg2.Enabled = true;
        }
    }
}
