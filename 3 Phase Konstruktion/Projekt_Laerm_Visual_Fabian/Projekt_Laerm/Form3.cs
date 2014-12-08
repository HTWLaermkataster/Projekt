using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Timers;
using System.Threading;
using System.Data.OleDb;
using System.Net;

namespace Projekt_Laerm
{
    public partial class Form3 : Form
    {
        string Pfad = "C:\\Media\\Uni\\ProjektManagement\\Projekt\\3 Phase Konstruktion\\Projekt_Laerm_Visual_Fabian\\Projekt_Laerm\\BDB.TXT";
        System.Timers.Timer aTimer;
        bool Fertig = false;

        public Form3()
        {
            InitializeComponent();
            button1.BackColor = Color.Orange;

            aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(DatenvomGServer);
            aTimer.Interval = 20;                                           // alle 20 ms die Mal-Prozedur aufrufen -> entspricht 50 Hertz
            aTimer.Enabled = true;
        }

        public void FensterSchliessen(object source, ElapsedEventArgs e)
        {
            aTimer.Enabled = false;
            aTimer.Dispose();

            button1_Click(null, null);
        }

        public void DatenvomGServer(object source, ElapsedEventArgs e)
        {
            aTimer.Enabled = false;
            aTimer.Dispose();

            try
            {
                WebClient myClient = new WebClient();
                myClient.DownloadFile("http://xn--grtzner-o2a.com/index.php?f=GetData", Pfad);
                Fertig = true;
                button1.BackColor = Color.Green;

                aTimer = new System.Timers.Timer();
                aTimer.Elapsed += new ElapsedEventHandler(FensterSchliessen);
                aTimer.Interval = 200;                                           // alle 20 ms die Mal-Prozedur aufrufen -> entspricht 50 Hertz
                aTimer.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Fertig)
            {
                this.Dispose();
                this.Close();
            }
        }
    }
}