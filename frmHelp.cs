using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cyanair_Airline_Booking_System
{
    public partial class frmHelp : Form
    {
        public frmHelp()
        {
            InitializeComponent();
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {
            
            //RELATIVE URL - CONNECTS THE URL TO THE FOLDER ! in debug/bin/help system/index.html
            string appDir = Path.GetDirectoryName(
            Assembly.GetExecutingAssembly().GetName().CodeBase);
            webBrowser1.Url = new Uri(Path.Combine(appDir, @"Help System\index.html"));
        }
    }
}
