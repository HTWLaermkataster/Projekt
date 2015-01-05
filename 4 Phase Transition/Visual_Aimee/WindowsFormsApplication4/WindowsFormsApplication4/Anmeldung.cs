using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication4.OpenResKitHub;

namespace WindowsFormsApplication4
{
    public partial class Anmeldung : Form
    {

        
        public Anmeldung()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Validate();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            this.Hide();
            LoginsSeite zentrale = new LoginsSeite();
            zentrale.Show();

            var serviceCreds = new System.Net.NetworkCredential("root", "ork123");
            Uri ork_Uri = new Uri("http://141.45.160.108:7000/OpenResKitHub", UriKind.Absolute);
           
        }
    }
}
