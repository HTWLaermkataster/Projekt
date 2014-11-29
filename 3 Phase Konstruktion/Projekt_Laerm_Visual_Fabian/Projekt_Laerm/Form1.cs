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
        const int AuflX = 512;
        const int AuflY = 512;

        uint[] Data = new uint[AuflX * AuflY];
        uint[] DataHG = new uint[AuflX * AuflY];

        int xpos, ypos;
        System.Timers.Timer aTimer;

        public void SetPixel(int x, int y, uint Farbe)
        {
            if (x < AuflX && x > 0 && y < AuflY && y > 0)
                Data[x + y * AuflX] = Farbe;
        }

        public void SetKreis(int xpos, int ypos, int rad, uint Farbe)
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

            System.Drawing.Color Farbe;
            int x, y;
            uint F;

            this.pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);
            this.pictureBox1.MouseClick += new MouseEventHandler(pictureBox1_MouseClick);
            this.pictureBox2.MouseMove += new MouseEventHandler(pictureBox2_MouseMove);
            this.pictureBox2.MouseClick += new MouseEventHandler(pictureBox2_MouseClick);
            //this.Size = new System.Drawing.Size(AuflX + 300, AuflY + 100);
            //this.pictureBox1.Size = new System.Drawing.Size(AuflX, AuflY);

            for (y = 0; y < AuflY; y++)
                for (x = 0; x < AuflX; x++)
                {
                    Farbe = ((Bitmap)pictureBox2.Image).GetPixel(x, y);
                    F = 0;
                    F = (uint)Farbe.A;
                    F = F << 8;
                    F += (uint)Farbe.R;
                    F = F << 8;
                    F += (uint)Farbe.G;
                    F = F << 8;
                    F += (uint)Farbe.B;
                    //F = (uint)Farbe.A << 24 + Farbe.R << 16 + Farbe.G << 8 + Farbe.B;
                    //F = 0xff0000ff;
                    DataHG[x + 512 * y] = F;
                    //DataHG[x + 512 * y] = F + Farbe.B;
                }


            /*aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(BildSetzen);
            aTimer.Interval = 20;                                           // alle 20 ms die Mal-Prozedur aufrufen -> entspricht 50 Hertz
            aTimer.Enabled = true;*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datenbankverbindung();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        
        void pictureBox1_MouseMove(object sender, MouseEventArgs e) { }

        void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            xpos = e.X;
            ypos = e.Y;
            BildSetzen(null, null);

            label1.Text = "XPosition: " + xpos.ToString() + ", YPosition: " + ypos.ToString();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        { //if (e.Button == MouseButtons.Left) Werte[Jahr] = Wert;
            SetKreis(xpos, ypos, 15, 0x7fff6622);
                        //aTimer.Enabled = false;             // Timer abschalten und 30 ms warten. Dann Hintergrund neu zeichnen und Timer wieder anschalten
                        //Thread.Sleep(30);

            //Hintergrund();
            //            aTimer.Enabled = true;

        }
        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        { //if (e.Button == MouseButtons.Left) Werte[Jahr] = Wert;
            SetKreis(xpos, ypos, 15, 0x7fff6622);
            //            aTimer.Enabled = false;             // Timer abschalten und 30 ms warten. Dann Hintergrund neu zeichnen und Timer wieder anschalten
            //            Thread.Sleep(30);

            //Hintergrund();
            //            aTimer.Enabled = true;

        }

        public void BildSetzen(object source, ElapsedEventArgs e)
        {
//            Hintergrund_copy();

            // Bild generieren

            System.Drawing.Color Farbe;
            int x, y;

            /*for (y = 0; y < AuflY; y ++)
                for (x = 0; x < AuflX; x++)
                    if ((y & 0x3f) == 0 || (x & 0x3f) == 0)
                        SetPixel(x, y, 0x7f880048);
                    else
                        SetPixel(x, y, 0x7f180018);*/

            for (y = 0; y < AuflY; y++)
                for (x = 0; x < AuflX; x++)
                {
                    Data[x + 512 * y] = DataHG[x + 512 * y];
                }

            SetKreis(xpos, ypos, 15, 0x7f3f6622);
            for (x = 0; x < xpos; x++)
            {
                SetPixel(x, ypos, 0x111111);
            }

            for (y = ypos; y < AuflY; y++)
            {
                SetPixel(xpos, y, 0x111111);
            }

            unsafe
            {
                fixed (uint* pointer = Data)
                {
                    System.IntPtr ptr = new System.IntPtr(pointer);
                    System.Drawing.Bitmap flag = new System.Drawing.Bitmap(AuflX, AuflY, AuflX * 4, PixelFormat.Format32bppArgb, ptr);
                    pictureBox2.Image = flag;
                }
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Datenbankverbindung();
            SetKreis(xpos, ypos, 10, 0xff6622);

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

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 DatenDialog = new Form2();
            //string Text;
            
            if (DatenDialog.ShowDialog(this) == DialogResult.OK)
            {
                //Text = DatenDialog.p;
            }

            DatenDialog.Dispose();
            //Form.ActiveForm.Visible = false;
            //Form.ActiveForm.ShowDialog();
            //Application.Run(new Form2());
            //Form2.ActiveForm.ShowDialog();
//            Form2.ActiveForm.Visible = true;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
