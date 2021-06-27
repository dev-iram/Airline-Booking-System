namespace Cyanair_Airline_Booking_System
{
    partial class frmMaintenanceSuite
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMaintenanceSuite));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlMaintenanceSuite = new System.Windows.Forms.Panel();
            this.grpMaintenanceSuite = new System.Windows.Forms.GroupBox();
            this.grpBookings = new System.Windows.Forms.GroupBox();
            this.dgvBookings = new System.Windows.Forms.DataGridView();
            this.grpAirportManagement = new System.Windows.Forms.GroupBox();
            this.pnlAddAirport = new System.Windows.Forms.Panel();
            this.pnlDeleteAirport = new System.Windows.Forms.Panel();
            this.lblDelete2 = new System.Windows.Forms.Label();
            this.lblDelete1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblDelete = new System.Windows.Forms.Label();
            this.lblDepartureLeg1 = new System.Windows.Forms.Label();
            this.txtAirportName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAirportCode = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblAirportAdded = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.grpManage = new System.Windows.Forms.GroupBox();
            this.btnBookings = new System.Windows.Forms.Button();
            this.btnAirports = new System.Windows.Forms.Button();
            this.pbxMaintenance = new System.Windows.Forms.PictureBox();
            this.grpAirportCode = new System.Windows.Forms.GroupBox();
            this.btnDeleteRecord = new System.Windows.Forms.Button();
            this.btnAddAirport = new System.Windows.Forms.Button();
            this.dgvAirports = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnHelp = new System.Windows.Forms.Button();
            this.pnlMaintenanceSuite.SuspendLayout();
            this.grpMaintenanceSuite.SuspendLayout();
            this.grpBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).BeginInit();
            this.grpAirportManagement.SuspendLayout();
            this.pnlAddAirport.SuspendLayout();
            this.pnlDeleteAirport.SuspendLayout();
            this.grpManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaintenance)).BeginInit();
            this.grpAirportCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMaintenanceSuite
            // 
            this.pnlMaintenanceSuite.Controls.Add(this.grpMaintenanceSuite);
            this.pnlMaintenanceSuite.Controls.Add(this.pictureBox1);
            this.pnlMaintenanceSuite.Location = new System.Drawing.Point(12, 12);
            this.pnlMaintenanceSuite.Name = "pnlMaintenanceSuite";
            this.pnlMaintenanceSuite.Size = new System.Drawing.Size(1270, 986);
            this.pnlMaintenanceSuite.TabIndex = 10;
            // 
            // grpMaintenanceSuite
            // 
            this.grpMaintenanceSuite.Controls.Add(this.grpBookings);
            this.grpMaintenanceSuite.Controls.Add(this.grpAirportManagement);
            this.grpMaintenanceSuite.Controls.Add(this.grpManage);
            this.grpMaintenanceSuite.Controls.Add(this.pbxMaintenance);
            this.grpMaintenanceSuite.Controls.Add(this.grpAirportCode);
            this.grpMaintenanceSuite.Font = new System.Drawing.Font("League Spartan", 15.75F, System.Drawing.FontStyle.Bold);
            this.grpMaintenanceSuite.Location = new System.Drawing.Point(3, 161);
            this.grpMaintenanceSuite.Name = "grpMaintenanceSuite";
            this.grpMaintenanceSuite.Size = new System.Drawing.Size(1260, 795);
            this.grpMaintenanceSuite.TabIndex = 22;
            this.grpMaintenanceSuite.TabStop = false;
            this.grpMaintenanceSuite.Text = "Maintenance Suite";
            // 
            // grpBookings
            // 
            this.grpBookings.Controls.Add(this.dgvBookings);
            this.grpBookings.Font = new System.Drawing.Font("League Spartan", 15.75F, System.Drawing.FontStyle.Bold);
            this.grpBookings.Location = new System.Drawing.Point(12, 318);
            this.grpBookings.Name = "grpBookings";
            this.grpBookings.Size = new System.Drawing.Size(1221, 466);
            this.grpBookings.TabIndex = 27;
            this.grpBookings.TabStop = false;
            this.grpBookings.Text = "View Bookings";
            this.grpBookings.Visible = false;
            // 
            // dgvBookings
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 10F);
            this.dgvBookings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookings.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBookings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBookings.Location = new System.Drawing.Point(17, 33);
            this.dgvBookings.Name = "dgvBookings";
            this.dgvBookings.ReadOnly = true;
            this.dgvBookings.RowHeadersWidth = 50;
            this.dgvBookings.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookings.Size = new System.Drawing.Size(1182, 411);
            this.dgvBookings.TabIndex = 25;
            this.dgvBookings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBookings_CellContentClick);
            // 
            // grpAirportManagement
            // 
            this.grpAirportManagement.Controls.Add(this.pnlDeleteAirport);
            this.grpAirportManagement.Controls.Add(this.pnlAddAirport);
            this.grpAirportManagement.Controls.Add(this.lblAirportAdded);
            this.grpAirportManagement.Controls.Add(this.btnView);
            this.grpAirportManagement.Font = new System.Drawing.Font("League Spartan", 15.75F, System.Drawing.FontStyle.Bold);
            this.grpAirportManagement.Location = new System.Drawing.Point(660, 33);
            this.grpAirportManagement.Name = "grpAirportManagement";
            this.grpAirportManagement.Size = new System.Drawing.Size(510, 279);
            this.grpAirportManagement.TabIndex = 26;
            this.grpAirportManagement.TabStop = false;
            this.grpAirportManagement.Text = "Airport Management";
            this.grpAirportManagement.Visible = false;
            // 
            // pnlAddAirport
            // 
            this.pnlAddAirport.Controls.Add(this.lblDepartureLeg1);
            this.pnlAddAirport.Controls.Add(this.txtAirportName);
            this.pnlAddAirport.Controls.Add(this.label1);
            this.pnlAddAirport.Controls.Add(this.txtAirportCode);
            this.pnlAddAirport.Controls.Add(this.btnSave);
            this.pnlAddAirport.Location = new System.Drawing.Point(56, 41);
            this.pnlAddAirport.Name = "pnlAddAirport";
            this.pnlAddAirport.Size = new System.Drawing.Size(397, 197);
            this.pnlAddAirport.TabIndex = 63;
            this.pnlAddAirport.Visible = false;
            // 
            // pnlDeleteAirport
            // 
            this.pnlDeleteAirport.Controls.Add(this.lblDelete2);
            this.pnlDeleteAirport.Controls.Add(this.lblDelete1);
            this.pnlDeleteAirport.Controls.Add(this.btnDelete);
            this.pnlDeleteAirport.Controls.Add(this.lblDelete);
            this.pnlDeleteAirport.Location = new System.Drawing.Point(56, 33);
            this.pnlDeleteAirport.Name = "pnlDeleteAirport";
            this.pnlDeleteAirport.Size = new System.Drawing.Size(397, 197);
            this.pnlDeleteAirport.TabIndex = 64;
            this.pnlDeleteAirport.Visible = false;
            // 
            // lblDelete2
            // 
            this.lblDelete2.AutoSize = true;
            this.lblDelete2.Font = new System.Drawing.Font("Montserrat", 12F);
            this.lblDelete2.Location = new System.Drawing.Point(59, 75);
            this.lblDelete2.Name = "lblDelete2";
            this.lblDelete2.Size = new System.Drawing.Size(270, 22);
            this.lblDelete2.TabIndex = 67;
            this.lblDelete2.Text = "To erase, click the Delete Button";
            // 
            // lblDelete1
            // 
            this.lblDelete1.AutoSize = true;
            this.lblDelete1.Font = new System.Drawing.Font("Montserrat", 12F);
            this.lblDelete1.Location = new System.Drawing.Point(71, 41);
            this.lblDelete1.Name = "lblDelete1";
            this.lblDelete1.Size = new System.Drawing.Size(256, 22);
            this.lblDelete1.TabIndex = 66;
            this.lblDelete1.Text = "Select a row in the table below";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(178)))), ((int)(((byte)(27)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Montserrat", 12F);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDelete.Location = new System.Drawing.Point(148, 118);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(92, 38);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "&Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Montserrat", 12F);
            this.lblDelete.Location = new System.Drawing.Point(91, 13);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(209, 22);
            this.lblDelete.TabIndex = 65;
            this.lblDelete.Text = "Delete an Airport Record";
            // 
            // lblDepartureLeg1
            // 
            this.lblDepartureLeg1.AutoSize = true;
            this.lblDepartureLeg1.Font = new System.Drawing.Font("Montserrat", 12F);
            this.lblDepartureLeg1.Location = new System.Drawing.Point(12, 18);
            this.lblDepartureLeg1.Name = "lblDepartureLeg1";
            this.lblDepartureLeg1.Size = new System.Drawing.Size(118, 22);
            this.lblDepartureLeg1.TabIndex = 59;
            this.lblDepartureLeg1.Text = "Airport Name";
            // 
            // txtAirportName
            // 
            this.txtAirportName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAirportName.Location = new System.Drawing.Point(16, 43);
            this.txtAirportName.Name = "txtAirportName";
            this.txtAirportName.Size = new System.Drawing.Size(239, 34);
            this.txtAirportName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F);
            this.label1.Location = new System.Drawing.Point(18, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 60;
            this.label1.Text = "Airport Code";
            // 
            // txtAirportCode
            // 
            this.txtAirportCode.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAirportCode.Location = new System.Drawing.Point(22, 123);
            this.txtAirportCode.Name = "txtAirportCode";
            this.txtAirportCode.Size = new System.Drawing.Size(177, 34);
            this.txtAirportCode.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(178)))), ((int)(((byte)(27)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Font = new System.Drawing.Font("Montserrat", 12F);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSave.Location = new System.Drawing.Point(274, 80);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(92, 38);
            this.btnSave.TabIndex = 22;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblAirportAdded
            // 
            this.lblAirportAdded.AutoSize = true;
            this.lblAirportAdded.Font = new System.Drawing.Font("Montserrat", 12F);
            this.lblAirportAdded.Location = new System.Drawing.Point(608, 53);
            this.lblAirportAdded.Name = "lblAirportAdded";
            this.lblAirportAdded.Size = new System.Drawing.Size(245, 22);
            this.lblAirportAdded.TabIndex = 62;
            this.lblAirportAdded.Text = "New record has been added !";
            this.lblAirportAdded.Visible = false;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(178)))), ((int)(((byte)(27)))));
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnView.Font = new System.Drawing.Font("Montserrat", 12F);
            this.btnView.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnView.Location = new System.Drawing.Point(859, 33);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(92, 46);
            this.btnView.TabIndex = 24;
            this.btnView.Text = "&View";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // grpManage
            // 
            this.grpManage.Controls.Add(this.btnBookings);
            this.grpManage.Controls.Add(this.btnAirports);
            this.grpManage.Location = new System.Drawing.Point(107, 33);
            this.grpManage.Name = "grpManage";
            this.grpManage.Size = new System.Drawing.Size(510, 279);
            this.grpManage.TabIndex = 63;
            this.grpManage.TabStop = false;
            this.grpManage.Text = "Manage";
            this.grpManage.Enter += new System.EventHandler(this.grpManage_Enter);
            // 
            // btnBookings
            // 
            this.btnBookings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(178)))), ((int)(((byte)(27)))));
            this.btnBookings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBookings.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookings.Location = new System.Drawing.Point(129, 148);
            this.btnBookings.Name = "btnBookings";
            this.btnBookings.Size = new System.Drawing.Size(243, 59);
            this.btnBookings.TabIndex = 23;
            this.btnBookings.Text = "Bookings";
            this.btnBookings.UseVisualStyleBackColor = false;
            this.btnBookings.Click += new System.EventHandler(this.btnBookings_Click);
            // 
            // btnAirports
            // 
            this.btnAirports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(178)))), ((int)(((byte)(27)))));
            this.btnAirports.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAirports.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAirports.Location = new System.Drawing.Point(129, 66);
            this.btnAirports.Name = "btnAirports";
            this.btnAirports.Size = new System.Drawing.Size(243, 59);
            this.btnAirports.TabIndex = 22;
            this.btnAirports.Text = "Airports";
            this.btnAirports.UseVisualStyleBackColor = false;
            this.btnAirports.Click += new System.EventHandler(this.button1_Click);
            // 
            // pbxMaintenance
            // 
            this.pbxMaintenance.Image = ((System.Drawing.Image)(resources.GetObject("pbxMaintenance.Image")));
            this.pbxMaintenance.Location = new System.Drawing.Point(660, 33);
            this.pbxMaintenance.Name = "pbxMaintenance";
            this.pbxMaintenance.Size = new System.Drawing.Size(487, 269);
            this.pbxMaintenance.TabIndex = 24;
            this.pbxMaintenance.TabStop = false;
            // 
            // grpAirportCode
            // 
            this.grpAirportCode.Controls.Add(this.btnDeleteRecord);
            this.grpAirportCode.Controls.Add(this.btnAddAirport);
            this.grpAirportCode.Controls.Add(this.dgvAirports);
            this.grpAirportCode.Font = new System.Drawing.Font("League Spartan", 15.75F, System.Drawing.FontStyle.Bold);
            this.grpAirportCode.Location = new System.Drawing.Point(18, 318);
            this.grpAirportCode.Name = "grpAirportCode";
            this.grpAirportCode.Size = new System.Drawing.Size(1221, 466);
            this.grpAirportCode.TabIndex = 23;
            this.grpAirportCode.TabStop = false;
            this.grpAirportCode.Text = "Airports";
            this.grpAirportCode.Visible = false;
            // 
            // btnDeleteRecord
            // 
            this.btnDeleteRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(178)))), ((int)(((byte)(27)))));
            this.btnDeleteRecord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteRecord.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteRecord.Location = new System.Drawing.Point(616, 33);
            this.btnDeleteRecord.Name = "btnDeleteRecord";
            this.btnDeleteRecord.Size = new System.Drawing.Size(243, 59);
            this.btnDeleteRecord.TabIndex = 26;
            this.btnDeleteRecord.Text = "Delete Airport Record";
            this.btnDeleteRecord.UseVisualStyleBackColor = false;
            this.btnDeleteRecord.Click += new System.EventHandler(this.btnDeleteRecord_Click);
            // 
            // btnAddAirport
            // 
            this.btnAddAirport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(178)))), ((int)(((byte)(27)))));
            this.btnAddAirport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddAirport.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAirport.Location = new System.Drawing.Point(356, 33);
            this.btnAddAirport.Name = "btnAddAirport";
            this.btnAddAirport.Size = new System.Drawing.Size(243, 59);
            this.btnAddAirport.TabIndex = 24;
            this.btnAddAirport.Text = "Add a New Airport";
            this.btnAddAirport.UseVisualStyleBackColor = false;
            this.btnAddAirport.Click += new System.EventHandler(this.btnAddAirport_Click);
            // 
            // dgvAirports
            // 
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 12F);
            this.dgvAirports.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAirports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAirports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAirports.Location = new System.Drawing.Point(17, 98);
            this.dgvAirports.Name = "dgvAirports";
            this.dgvAirports.ReadOnly = true;
            this.dgvAirports.RowHeadersWidth = 50;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Montserrat", 12F);
            this.dgvAirports.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAirports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAirports.Size = new System.Drawing.Size(1182, 346);
            this.dgvAirports.TabIndex = 25;
            this.dgvAirports.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAirports_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cyanair_Airline_Booking_System.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(343, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.Location = new System.Drawing.Point(1415, 0);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(66, 57);
            this.btnHelp.TabIndex = 32;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmMaintenanceSuite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1482, 998);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.pnlMaintenanceSuite);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMaintenanceSuite";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cyanair: Affordable Business Travel | Maintenance Suite";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMaintenanceSuite_Load);
            this.pnlMaintenanceSuite.ResumeLayout(false);
            this.grpMaintenanceSuite.ResumeLayout(false);
            this.grpBookings.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookings)).EndInit();
            this.grpAirportManagement.ResumeLayout(false);
            this.grpAirportManagement.PerformLayout();
            this.pnlAddAirport.ResumeLayout(false);
            this.pnlAddAirport.PerformLayout();
            this.pnlDeleteAirport.ResumeLayout(false);
            this.pnlDeleteAirport.PerformLayout();
            this.grpManage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaintenance)).EndInit();
            this.grpAirportCode.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAirports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMaintenanceSuite;
        private System.Windows.Forms.GroupBox grpMaintenanceSuite;
        private System.Windows.Forms.GroupBox grpAirportCode;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pbxMaintenance;
        private System.Windows.Forms.Button btnAirports;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dgvAirports;
        private System.Windows.Forms.Button btnBookings;
        private System.Windows.Forms.GroupBox grpAirportManagement;
        private System.Windows.Forms.TextBox txtAirportName;
        private System.Windows.Forms.TextBox txtAirportCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDepartureLeg1;
        private System.Windows.Forms.Label lblAirportAdded;
        private System.Windows.Forms.GroupBox grpManage;
        private System.Windows.Forms.Button btnAddAirport;
        private System.Windows.Forms.Panel pnlDeleteAirport;
        private System.Windows.Forms.Label lblDelete2;
        private System.Windows.Forms.Label lblDelete1;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Panel pnlAddAirport;
        private System.Windows.Forms.Button btnDeleteRecord;
        private System.Windows.Forms.GroupBox grpBookings;
        private System.Windows.Forms.DataGridView dgvBookings;
        private System.Windows.Forms.Button btnHelp;
    }
}