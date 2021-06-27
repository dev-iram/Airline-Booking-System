using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cyanair_Airline_Booking_System
{
    public partial class frmWelcomeScreen : Form
    {
        public CyanairDataConnection myNewCyanDatabaseConnection = new CyanairDataConnection("");

        public SystemUsers mySystemUsers = new SystemUsers();


        public frmWelcomeScreen()
        {
            InitializeComponent();


        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void frmWelcomeScreen_Load(object sender, EventArgs e)
        {
            


            //Maximise the screen
            this.WindowState = FormWindowState.Maximized;

            //Set Panel to Center of Screen - Fullscreen centered
            pnlWelcomeScreen.Left = (this.ClientSize.Width - pnlWelcomeScreen.Size.Width) / 2;

                   

        }


        private void btnMinimiseScreen_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pnlWelcomeScreen_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            if (txtUsername.Text =="")
            {
                MessageBox.Show("Please enter your username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }

            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter your password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // trurn true for user was a valid login, otherwise, messsage no access..
            bool canAccessSystem = false;

            canAccessSystem = myNewCyanDatabaseConnection.Login(txtUsername.Text, txtPassword.Text, mySystemUsers);

            if (canAccessSystem)
            {
                //this hides the WELCOME/LOGIN FORM so the user will have only the choice application open
                //  this.Hide();
                //After user has logged in, message box will pop up to let them know if it was successful or not
                //After this, the choice form will open
                //Admin will have choice of booking system, maintenance suite and close application
                //Flight representative will NOT have maintenance suite option available
                //Depends on the user who logged in - if user is representative/admin
                frmChoice ChoiceForm = new frmChoice();
                ChoiceForm.myNewCyanDatabaseConnection = myNewCyanDatabaseConnection;
                ChoiceForm.mySystemUsers = mySystemUsers;
                ChoiceForm.ShowDialog();
                
                this.Close();
            
            } else
            {
                MessageBox.Show("The username and password entered does not match");
            }




        }

  
        private void btnHelp_Click_1(object sender, EventArgs e)
        {
            frmHelp Help = new frmHelp();
            Help.ShowDialog();
        }
    }
}
