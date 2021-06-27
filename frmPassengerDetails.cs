using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyanair_Airline_Booking_System
{
    public partial class frmPassengerDetails : Form
    {
        //DATABASE CONNECTION
        public CyanairDataConnection myNewCyanDatabaseConnection;
        public SystemUsers mySystemUsers;

        public FlightRoute OutboundFlight01;
        public FlightRoute OutboundFlight02;
  

       


        public frmPassengerDetails()
        {
            InitializeComponent();
        }

        //Creating an object from the Bookings Class (Bookings.cs)
        public Bookings newBookingObject = new Bookings();

        


        private void frmPassengerDetails_Load(object sender, EventArgs e)
        {

            //Focus on the first field
            txtFullName.Focus();

            lblOutwardFlightLeg1DepDest.Text =
                OutboundFlight01.DepartAirportName + " TO " + OutboundFlight01.DestinAirportName;
            lblOutwardFlightLeg1TimeDur.Text =
             OutboundFlight01.TimeOfFlight + " - " + OutboundFlight01.Duration + " Minutes Duration";


            //NEED A VALIDATION HERE !
            lblOutwardFlightLeg2DepDest.Text =
                OutboundFlight02.DepartAirportName + " TO " + OutboundFlight02.DestinAirportName;
            lblOutwardFlightLeg2TimeDur.Text =
             OutboundFlight02.TimeOfFlight + " - " + OutboundFlight02.Duration + " Minutes Duration";


            //Maximise the screen
            this.WindowState = FormWindowState.Maximized;

            //Set Panel to Center of Screen - Fullscreen centered
            pnlPassengerDetails.Left = (this.ClientSize.Width - pnlPassengerDetails.Size.Width) / 2;

            /*=====================SETTING ATTRIBUTES========================*/
            //1. FULL NAME
            newBookingObject.fullname = "Iram Dev";
            //2. PASSPORT NUMBER
            newBookingObject.passportnumber = "PA1234567";
            //3. NATIONALITY
            newBookingObject.nationality = "Irish";
            //4. PHONE NUMBER
            newBookingObject.phonenumber = "0870123456";
            //5. EMAIL ADDRESS
            newBookingObject.emailaddress = "iramdev@info.com";
            //6. GENDER
            newBookingObject.gender = "F";
        }

        private void btnMakeBooking_Click(object sender, EventArgs e)
        {
            /*=====================ensures that representative cannot proceed with booking
             * until all of the fields have been filled========================*/
            string warningErrorMessage = "";
            //1. FULL NAME
             if (txtFullName.Text != "")
            {
                newBookingObject.fullname = txtFullName.Text;
            }
             else
            {
                warningErrorMessage += "Please enter the Full Name of the Passenger" + Environment.NewLine;
            }

            //2. PASSPORT NUMBER
            if (txtPassportNumber.Text != "")
            {
                newBookingObject.passportnumber = txtPassportNumber.Text;
            }
            else
            {
                warningErrorMessage += "Please enter the Passport Number of the Passenger" + Environment.NewLine;  
            }

            //3. NATIONALITY
            if (txtNationality.Text != "")
            {
                newBookingObject.nationality = txtNationality.Text;
            }
            else
            {
                warningErrorMessage += "Please enter the Nationality of the Passenger" + Environment.NewLine; 
            }

            //4. PHONE NUMBER
            if (txtPhoneNumber.Text != "")
            {
                newBookingObject.phonenumber = txtPhoneNumber.Text;
            }
            else
            {
                warningErrorMessage += "Please enter the Phone Number of the Passenger" + Environment.NewLine;
            }

            //5. EMAIL ADDRESS
            if (txtEmailAddress.Text != "")
            {
                newBookingObject.emailaddress = txtEmailAddress.Text;
            }
            else
            {
                warningErrorMessage += "Please enter the Email Address of the Passenger" + Environment.NewLine;
            }

            //6. GENDER
            if (txtGender.Text != "")
            {
                newBookingObject.gender = txtGender.Text;
            }
            else
            {
                warningErrorMessage += "Please enter the Gender of the Passenger";
            }



            if (warningErrorMessage != "")
            {
                MessageBox.Show(warningErrorMessage);
                return;
            }
            else
            {
                //IF all fields are completed, the system will ask the flight representative to confirm the booking 
                //if YES --> proceeds to confirmation screen where it will generate a reference number
                //if NO --> returns back to edit form. [cancel]
                DialogResult dialogResult = MessageBox.Show(null, "Are you sure you want to proceed creating this booking?", "Cyanair: Confirm Booking", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    //open booking confirmation form
                    frmBookingConfirmation BookingConfirmation = new frmBookingConfirmation();
                    //DATABASE CONNECTION
                    BookingConfirmation.myNewCyanDatabaseConnection = myNewCyanDatabaseConnection;
                    BookingConfirmation.mySystemUsers = mySystemUsers;

                    //MOVING OBJECTS TO NEXT PAGE?
                    BookingConfirmation.OutboundFlight01 = OutboundFlight01;
                    BookingConfirmation.OutboundFlight02 = OutboundFlight02;
                    BookingConfirmation.newBookingObject = newBookingObject;

                    BookingConfirmation.ShowDialog();
                    this.Close();
                    
                }
            }
            
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show(null, "Are you sure you want to cancel this booking?" + Environment.NewLine + "Please note: this will result in a loss of data.", "Cyanair: Cancel Booking?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                //opens booking system
                Cyanair BookingSystem = new Cyanair();
                BookingSystem.ShowDialog();
                this.Close();
                this.Dispose();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
                /*=====================ensures that representative cannot proceed with booking
                 * until all of the fields have been filled========================*/
                string warningErrorMessage = "";
                //1. FULL NAME
                if (txtFullName.Text != "")
                {
                    newBookingObject.fullname = txtFullName.Text;
                }
                else
                {
                    warningErrorMessage += "Please enter the Full Name of the Passenger" + Environment.NewLine;
                }

                //2. PASSPORT NUMBER
                if (txtPassportNumber.Text != "")
                {
                    newBookingObject.passportnumber = txtPassportNumber.Text;
                }
                else
                {
                    warningErrorMessage += "Please enter the Passport Number of the Passenger" + Environment.NewLine;
                }

                //3. NATIONALITY
                if (txtNationality.Text != "")
                {
                    newBookingObject.nationality = txtNationality.Text;
                }
                else
                {
                    warningErrorMessage += "Please enter the Nationality of the Passenger" + Environment.NewLine;
                }

                //4. PHONE NUMBER
                if (txtPhoneNumber.Text != "")
                {
                    newBookingObject.phonenumber = txtPhoneNumber.Text;
                }
                else
                {
                    warningErrorMessage += "Please enter the Phone Number of the Passenger" + Environment.NewLine;
                }

                //5. EMAIL ADDRESS
                if (txtEmailAddress.Text != "")
                {
                    newBookingObject.emailaddress = txtEmailAddress.Text;
                }
                else
                {
                    warningErrorMessage += "Please enter the Email Address of the Passenger" + Environment.NewLine;
                }

                //6. GENDER
                if (txtGender.Text != "")
                {
                    newBookingObject.gender = txtGender.Text;
                }
                else
                {
                    warningErrorMessage += "Please enter the Gender of the Passenger";
                }



                if (warningErrorMessage != "")
                {
                    MessageBox.Show(warningErrorMessage);
                    return;
                }
                else
                {
                //open booking confirmation form
                frmBookingConfirmation BookingConfirmation = new frmBookingConfirmation();
                //DATABASE CONNECTION
                BookingConfirmation.myNewCyanDatabaseConnection = myNewCyanDatabaseConnection;

                //MOVING OBJECTS TO NEXT PAGE?
                BookingConfirmation.OutboundFlight01 = OutboundFlight01;
                BookingConfirmation.OutboundFlight02 = OutboundFlight02;
                BookingConfirmation.newBookingObject = newBookingObject;
                BookingConfirmation.mySystemUsers = mySystemUsers;


                BookingConfirmation.ShowDialog();
                this.Close();
                this.Dispose();
               
                }

            }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {
            txtGender.MaxLength = 1;
        }

        private void pnlPassengerDetails_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblOutwardFlightLeg1_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp Help = new frmHelp();
            Help.ShowDialog();
        }
    }
    }

