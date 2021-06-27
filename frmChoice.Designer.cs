namespace Cyanair_Airline_Booking_System
{
    partial class frmChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChoice));
            this.pnlChoice = new System.Windows.Forms.Panel();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBookingSystem = new System.Windows.Forms.Button();
            this.lblChoice = new System.Windows.Forms.Label();
            this.btnMaintenanceSuite = new System.Windows.Forms.Button();
            this.pnlChoice.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChoice
            // 
            this.pnlChoice.Controls.Add(this.btnHelp);
            this.pnlChoice.Controls.Add(this.btnClose);
            this.pnlChoice.Controls.Add(this.btnBookingSystem);
            this.pnlChoice.Controls.Add(this.lblChoice);
            this.pnlChoice.Controls.Add(this.btnMaintenanceSuite);
            this.pnlChoice.Location = new System.Drawing.Point(-1, -4);
            this.pnlChoice.Name = "pnlChoice";
            this.pnlChoice.Size = new System.Drawing.Size(323, 452);
            this.pnlChoice.TabIndex = 19;
            this.pnlChoice.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlChoice_Paint);
            // 
            // btnHelp
            // 
            this.btnHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.Location = new System.Drawing.Point(257, 3);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(66, 57);
            this.btnHelp.TabIndex = 32;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(178)))), ((int)(((byte)(27)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(59, 263);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(196, 59);
            this.btnClose.TabIndex = 18;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBookingSystem
            // 
            this.btnBookingSystem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(178)))), ((int)(((byte)(27)))));
            this.btnBookingSystem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBookingSystem.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookingSystem.Location = new System.Drawing.Point(59, 133);
            this.btnBookingSystem.Name = "btnBookingSystem";
            this.btnBookingSystem.Size = new System.Drawing.Size(196, 59);
            this.btnBookingSystem.TabIndex = 16;
            this.btnBookingSystem.Text = "Booking System";
            this.btnBookingSystem.UseVisualStyleBackColor = false;
            this.btnBookingSystem.Click += new System.EventHandler(this.btnBookingSystem_Click);
            // 
            // lblChoice
            // 
            this.lblChoice.Font = new System.Drawing.Font("League Spartan", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblChoice.Location = new System.Drawing.Point(36, 100);
            this.lblChoice.Name = "lblChoice";
            this.lblChoice.Size = new System.Drawing.Size(262, 30);
            this.lblChoice.TabIndex = 0;
            this.lblChoice.Text = "Please select an option";
            // 
            // btnMaintenanceSuite
            // 
            this.btnMaintenanceSuite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(178)))), ((int)(((byte)(27)))));
            this.btnMaintenanceSuite.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMaintenanceSuite.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaintenanceSuite.Location = new System.Drawing.Point(59, 198);
            this.btnMaintenanceSuite.Name = "btnMaintenanceSuite";
            this.btnMaintenanceSuite.Size = new System.Drawing.Size(196, 59);
            this.btnMaintenanceSuite.TabIndex = 17;
            this.btnMaintenanceSuite.Text = "Maintenance Suite";
            this.btnMaintenanceSuite.UseVisualStyleBackColor = false;
            this.btnMaintenanceSuite.Click += new System.EventHandler(this.btnMaintenanceSuite_Click);
            // 
            // frmChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(323, 446);
            this.Controls.Add(this.pnlChoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmChoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cyanair: Affordable Business Travel | Selection";
            this.Load += new System.EventHandler(this.frmChoice_Load);
            this.pnlChoice.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChoice;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBookingSystem;
        private System.Windows.Forms.Label lblChoice;
        private System.Windows.Forms.Button btnMaintenanceSuite;
        private System.Windows.Forms.Button btnHelp;
    }
}