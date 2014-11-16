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

namespace Projekt_Laerm
{
    public partial class Form1 : Form
    {
        const int AuflX = 400;
        const int AuflY = 400;

        int[] Data = new int[AuflX * AuflY];
        int[] DataHG = new int[AuflX * AuflY];

        int xpos, ypos;
        System.Timers.Timer aTimer;

        public void SetPixel(int x, int y, int Farbe)
        {
            if (x < AuflX && x > 0 && y < AuflY && y > 0)
                Data[x + y * AuflX] = Farbe;
        }

        public void SetKreis(int xpos, int ypos, int rad, int Farbe)
        {
            int x, y;

            for (x = xpos - rad * 2; x < xpos + rad * 2; x++)
                for (y = ypos - rad * 2; y < ypos + rad * 2; y++)
                    if (Math.Sqrt((x - xpos) * (x - xpos) + (y - ypos) * (y - ypos)) < rad)
                        SetPixel(x, y, Farbe);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);
            this.pictureBox1.MouseClick += new MouseEventHandler(pictureBox1_MouseClick);
            this.Size = new System.Drawing.Size(AuflX + 300, AuflY + 100);
            this.pictureBox1.Size = new System.Drawing.Size(AuflX, AuflY);

            aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(BildSetzen);
            aTimer.Interval = 20;                                           // alle 20 ms die Mal-Prozedur aufrufen -> entspricht 50 Hertz
            aTimer.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datenbankverbindung();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            xpos = e.X;
            ypos = e.Y;

            label1.Text = "XPosition: " + xpos.ToString() + ", YPosition: " + ypos.ToString();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        { //if (e.Button == MouseButtons.Left) Werte[Jahr] = Wert;
            SetKreis(xpos, ypos, 15, 0xff6622);
//            aTimer.Enabled = false;             // Timer abschalten und 30 ms warten. Dann Hintergrund neu zeichnen und Timer wieder anschalten
//            Thread.Sleep(30);

            //Hintergrund();
//            aTimer.Enabled = true;

        }
        public void BildSetzen(object source, ElapsedEventArgs e)
        {
//            Hintergrund_copy();

            // Bild generieren

            unsafe
            {
                fixed (int* pointer = Data)
                {
                    System.IntPtr ptr = new System.IntPtr(pointer);
                    System.Drawing.Bitmap flag = new System.Drawing.Bitmap(AuflX, AuflY, AuflX * 4, PixelFormat.Format32bppArgb, ptr);
                    pictureBox1.Image = flag;
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Datenbankverbindung();
            SetKreis(xpos, ypos, 15, 0xff6622);
        }

        private void flowLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        public void Datenbankverbindung()
        {
            string strAccessConn = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\\..\\..\\DB_Laerm.accdb";
            string strAccessSelect = "SELECT * FROM Daten";
            DataSet myDataSet = new DataSet();
            OleDbConnection myAccessConn = null;
            try
            {
                myAccessConn = new OleDbConnection(strAccessConn);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Failed to create a database connection. \n{0}", ex.Message);
                return;
            }

            try
            {

                OleDbCommand myAccessCommand = new OleDbCommand(strAccessSelect, myAccessConn);
                OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(myAccessCommand);

                myAccessConn.Open();
                myDataAdapter.Fill(myDataSet, "Daten");

            }
            catch (Exception ex)
            {
                //MessageBox();
                return;
            }
            finally
            {
                myAccessConn.Close();
            }
        }
    }
}
