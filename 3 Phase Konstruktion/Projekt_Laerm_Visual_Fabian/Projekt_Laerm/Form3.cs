using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Projekt_Laerm
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "Daten werden geldaden. Bitte waren";
            button1.BackColor = Color.Red;
            this.Invalidate();

            try
            {
                string Pfad = "C:\\Media\\Uni\\ProjektManagement\\Projekt\\3 Phase Konstruktion\\Projekt_Laerm_Visual_Fabian\\Projekt_Laerm\\BDB.TXT";

                WebClient myClient = new WebClient();
                myClient.DownloadFile("http://xn--grtzner-o2a.com/index.php?f=GetData", Pfad);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }
    }
}