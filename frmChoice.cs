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
    public partial class frmChoice : Form
    {
        //DATABASE CONNECTION
        public CyanairDataConnection myNewCyanDatabaseConnection;
        public SystemUsers mySystemUsers;

        public frmChoice()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnBookingSystem_Click(object sender, EventArgs e)
        {
            Cyanair BookingSystem = new Cyanair();
            //DATABASE CONNECTION
            BookingSystem.myNewCyanDatabaseConnection = myNewCyanDatabaseConnection;
            BookingSystem.mySystemUsers = mySystemUsers;
            BookingSystem.ShowDialog();
            this.Close();
            
        }

        private void btnMaintenanceSuite_Click(object sender, EventArgs e)
        {
            frmMaintenanceSuite MaintenanceSuite = new frmMaintenanceSuite();
            MaintenanceSuite.myNewCyanDatabaseConnection = myNewCyanDatabaseConnection;
            MaintenanceSuite.ShowDialog();
            this.Close();
            this.Dispose();
        }

        private void frmChoice_Load(object sender, EventArgs e)
        {

            if (mySystemUsers.UserRole == "Flight Representative")
            {
                btnMaintenanceSuite.Enabled = false;

            }

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp Help = new frmHelp();
            Help.ShowDialog();
        }

        private void pnlChoice_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
