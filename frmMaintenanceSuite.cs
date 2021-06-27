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
using System.Data.SqlClient;

namespace Cyanair_Airline_Booking_System
{
    public partial class frmMaintenanceSuite : Form
    {
        //DATABASE CONNECTION
        public CyanairDataConnection myNewCyanDatabaseConnection;
        public frmMaintenanceSuite()
        {
            InitializeComponent();
        }


        //new connection
        


        private void lblBookingReference_Click(object sender, EventArgs e)
        {

        }

        private void frmMaintenanceSuite_Load(object sender, EventArgs e)
        {
            this.dgvAirports.DefaultCellStyle.Font = new Font("Montserrat", 10);
            this.dgvBookings.DefaultCellStyle.Font = new Font("Montserrat", 10);
            this.dgvAirports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            //Maximise the screen
            this.WindowState = FormWindowState.Maximized;

            //Set Panel to Center of Screen - Fullscreen centered
            pnlMaintenanceSuite.Left = (this.ClientSize.Width - pnlMaintenanceSuite.Size.Width) / 2;


           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDataFromAirportsINDGV();
            grpAirportCode.Visible = true;
            btnAirports.Enabled = false;
            btnBookings.Enabled = true;
            grpBookings.Visible = false;
        }
        private void AddAirport()
        {
            SQLiteConnection MaintenanceSuiteConnection = new SQLiteConnection(@"Data Source = C:\\data\\Cyanair.db");
            //CREATES A NEW GUID FOR THE INSERT INTO THE DB 
            Guid AirportGuid = Guid.NewGuid();


            //add guid later?                           //WHERE Deleted=0
            string mySQLCommandString = "INSERT INTO Airport (Guid,Airport,AirportCode) VALUES('"
                                            + AirportGuid.ToString() + "','"
                                             + txtAirportName.Text + "','"
                                             + txtAirportCode.Text + "')";
            MaintenanceSuiteConnection.Open();

            SQLiteCommand sqlInsertAirport = new SQLiteCommand(mySQLCommandString, MaintenanceSuiteConnection);
            sqlInsertAirport.ExecuteNonQuery();
            // SqlDataAdapter MaintenanceSuiteDataAdapter = new SqlDataAdapter(mySQLCommandString, MaintenanceSuiteConnection);
            // MaintenanceSuiteDataAdapter.SelectCommand.ExecuteNonQuery();
            MaintenanceSuiteConnection.Close();
            lblAirportAdded.Visible = true;
            MessageBox.Show("INSERTED SUCCESSFULLY ! NEW RECORD ADDED !");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
             if (txtAirportName.Text != "" && txtAirportCode.Text != "")
                {
                AddAirport();
                ReloadDataINDGV();
                txtAirportName.Text = "";
                txtAirportCode.Text = "";

            }

        }

        private void dgvAirports_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //dgvAirports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteRow();
            ReloadDataINDGV();

        }

        private void ReloadDataINDGV()
        {
            //SQL 
            SQLiteConnection MaintenanceSuiteConnection = new SQLiteConnection(@"Data Source = C:\\data\\Cyanair.db");
            //CREATES A NEW GUID FOR THE INSERT INTO THE DB 
            Guid AirportGuid = Guid.NewGuid();

            MaintenanceSuiteConnection.Open();
            //add guid later?                           //WHERE Deleted=0
            string mySQLCommandString = "SELECT * FROM Airport;";
            SQLiteDataAdapter MaintenanceSuiteDataAdapter = new SQLiteDataAdapter(mySQLCommandString, MaintenanceSuiteConnection);
            DataTable dtDGV = new DataTable();
            MaintenanceSuiteDataAdapter.Fill(dtDGV);
            dgvAirports.DataSource = dtDGV;
            dgvAirports.Visible = true;
            MaintenanceSuiteConnection.Close();
        }

        private void LoadDataFromAirportsINDGV()
        {
            //DATA GRID VIEWER
            SQLiteConnection MaintenanceSuiteConnection = new SQLiteConnection(@"Data Source = C:\\data\\Cyanair.db");
            MaintenanceSuiteConnection.Open();
            //add guid later?                           //WHERE Deleted=0
            string mySQLCommandString = "SELECT * FROM Airport";
            SQLiteDataAdapter MaintenanceSuiteDataAdapter = new SQLiteDataAdapter(mySQLCommandString, MaintenanceSuiteConnection);
            DataTable dtDGV = new DataTable();
            MaintenanceSuiteDataAdapter.Fill(dtDGV);
            dgvAirports.DataSource = dtDGV;
            dgvAirports.Visible = true;
            MaintenanceSuiteConnection.Close();
        }


        private void LoadDataFromBookingsINDGV()
        {
            //SQL 
            SQLiteConnection MaintenanceSuiteConnection = new SQLiteConnection(@"Data Source = C:\\data\\Cyanair.db");
           

            MaintenanceSuiteConnection.Open();
            //add guid later?                           //WHERE Deleted=0
            string mySQLCommandString = "Select * FROM PassengerDetails LEFT JOIN Booking ON PassengerDetails.Uid = Booking.Uid; ";
            SQLiteDataAdapter MaintenanceSuiteDataAdapter = new SQLiteDataAdapter(mySQLCommandString, MaintenanceSuiteConnection);
            DataTable dtDGV = new DataTable();
            MaintenanceSuiteDataAdapter.Fill(dtDGV);
            dgvBookings.DataSource = dtDGV;
            dgvBookings.Visible = true;
            MaintenanceSuiteConnection.Close();
        }
        //FUNCTION THAT ALLOWS A ROW SELECTED IN THE DATAGRID VIEW TO BE DELETED ! 
        private void DeleteRow()
        {
            SQLiteConnection MaintenanceSuiteConnection = new SQLiteConnection(@"Data Source = C:\\data\\Cyanair.db");
            SQLiteCommand DeleteCommand = new SQLiteCommand();
            //MaintenanceSuiteConnection.ConnectionString=

            if (dgvAirports.Rows.Count > 1 && dgvAirports.SelectedRows[0].Index != dgvAirports.Rows.Count -1)
                {
                DeleteCommand.CommandText = "DELETE FROM Airport WHERE Uid=" + dgvAirports.SelectedRows[0].Cells[0].Value.ToString()
                    + "";
                MaintenanceSuiteConnection.Open();
                DeleteCommand.Connection = MaintenanceSuiteConnection;
                DeleteCommand.ExecuteNonQuery();
                MaintenanceSuiteConnection.Close();
                dgvAirports.Rows.RemoveAt(dgvAirports.SelectedRows[0].Index);
                MessageBox.Show("The record you have selected has successfully been deleted!");
            }


            /*
            //CREATES A NEW GUID FOR THE INSERT INTO THE DB 
            Guid AirportGuid = Guid.NewGuid();

            MaintenanceSuiteConnection.Open();
            //add guid later?                           //WHERE Deleted=0
            string mySQLCommandString = "DELETE FROM Airport WHERE Uid= '" + txtAirportName.Text + "'";
            SQLiteDataAdapter MaintenanceSuiteDataAdapter = new SQLiteDataAdapter(mySQLCommandString, MaintenanceSuiteConnection);
            MaintenanceSuiteDataAdapter.SelectCommand.ExecuteNonQuery();

            MaintenanceSuiteConnection.Close();
            MessageBox.Show("RECORD DELETED !");*/
        }

        private void ViewAirports()
        {
            //DATA GRID VIEWER
            SQLiteConnection MaintenanceSuiteConnection = new SQLiteConnection(@"Data Source = C:\\data\\Cyanair.db");
            MaintenanceSuiteConnection.Open();
            //add guid later?                           //WHERE Deleted=0
            string mySQLCommandString = "SELECT * FROM Airport";
            SQLiteDataAdapter MaintenanceSuiteDataAdapter = new SQLiteDataAdapter(mySQLCommandString, MaintenanceSuiteConnection);
            DataTable dtDGV = new DataTable();
            MaintenanceSuiteDataAdapter.Fill(dtDGV);
            dgvAirports.DataSource = dtDGV;
            dgvAirports.Visible = true;
            MaintenanceSuiteConnection.Close();
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            ViewAirports();
        }

        private void btnAddAirport_Click(object sender, EventArgs e)
        {
            grpAirportManagement.Visible = true;
            btnAddAirport.Visible = true;
            btnAddAirport.Enabled = false;
            pbxMaintenance.Visible = false;
            pnlAddAirport.Visible = true;
            btnDeleteRecord.Enabled = true;
            txtAirportName.Focus();

        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            grpAirportManagement.Visible = true;
            btnAddAirport.Visible = true;
            pnlAddAirport.Visible = false;
            btnAddAirport.Enabled = true;
            btnDeleteRecord.Enabled = false;
            pnlDeleteAirport.Visible = true;
            pbxMaintenance.Visible = false;

            
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            //this stores the SELECT function from SQL into the DGV 
            //basically loads the bookings table from the database !
            LoadDataFromBookingsINDGV();
            grpBookings.Visible = true;
            grpAirportCode.Visible = false;
            btnAirports.Enabled = true;
            btnBookings.Enabled = false;
            pnlDeleteAirport.Visible = false;
            pnlAddAirport.Visible = false;
            grpAirportManagement.Visible = false;
            pbxMaintenance.Visible = true;



        }

        private void grpManage_Enter(object sender, EventArgs e)
        {

        }

        private void dgvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp Help = new frmHelp();
            Help.ShowDialog();
        }
    }
}
