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
using System.Data.SqlClient;

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

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Aimée\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where BENUTZERNAME = '" + textBox3.Text + "' and PASSWORD = '" + textBox2.Text + "' ",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows[0][0].ToString() == "1")
            {

                this.Hide();
                LoginsSeite Seite = new LoginsSeite();
                Seite.Show();
            }
            else
            {
                MessageBox.Show("Überprüfen Sie Bitte Ihre Benutzername sowie Ihr Password");
            }

            var serviceCreds = new System.Net.NetworkCredential("root", "ork123");
            Uri ork_Uri = new Uri("http://141.45.160.108:7000/OpenResKitHub", UriKind.Absolute);
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            NeuerKonto Konto = new NeuerKonto();
            Konto.Show();
        }
    }
}
