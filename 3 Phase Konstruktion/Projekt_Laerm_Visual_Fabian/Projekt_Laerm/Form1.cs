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
    public partial class Form1 : Form
    {
        const int MaxDatensätze = 100;
        int M;                                                                              //Ist Mauszeiger über Messwert, dann >= 0
        public static double Form2return;

        string[] MS = new string[MaxDatensätze];
        int[] TimeStamp = new int[MaxDatensätze];
        double[] dB = new double[MaxDatensätze]; 
        
        const int AuflX = 512;
        const int AuflY = 512;

        int MinWert = 0, MaxWert = 0;
        string Pfad = "C:\\Media\\Uni\\ProjektManagement\\Projekt\\3 Phase Konstruktion\\Projekt_Laerm_Visual_Fabian\\Projekt_Laerm\\BDB.TXT";
        int MessDauer;
        int AnzMesspunkte;

        uint[] Data = new uint[AuflX * AuflY];
        uint[] DataHG = new uint[AuflX * AuflY];

        uint[] Data2 = new uint[AuflX * AuflY];
        uint[] Data2HG = new uint[AuflX * AuflY];

        int[] Messungen = new int[AuflX * AuflY];

        int xpos, ypos, xpos2, ypos2;

        public void SetPixel(int x, int y, uint Farbe)
        {
            if (x < AuflX && x > 0 && y < AuflY && y > 0)
                Data[x + y * AuflX] = Farbe;
        }
        public void SetPixel2(int x, int y, uint Farbe)
        {
            if (x < AuflX && x > 0 && y < AuflY && y > 0)
                Data2[x + y * AuflX] = Farbe;
        }
        public void SetKreis(int xpos, int ypos, int rad, uint Farbe)
        {
            int x, y;

            for (x = xpos - rad * 2; x < xpos + rad * 2; x++)
                for (y = ypos - rad * 2; y < ypos + rad * 2; y++)
                    if (Math.Sqrt((x - xpos) * (x - xpos) + (y - ypos) * (y - ypos)) < rad)
                        SetPixel(x, y, Farbe);
        }
        public void SetKreis2(int xpos, int ypos, int rad, int Messung, uint Farbe)
        {
            int x, y;

            for (x = xpos - rad * 2; x < xpos + rad * 2; x++)
                for (y = ypos - rad * 2; y < ypos + rad * 2; y++)
                    if (Math.Sqrt((x - xpos) * (x - xpos) + (y - ypos) * (y - ypos)) < rad)
                    {
                        SetPixel2(x, y, Farbe);
                        if ( Messung != -1 && x > 0 && x < AuflX && y > 0 && y < AuflY)
                             Messungen[x + y * 512] = Messung;
                    }
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
                    Farbe = ((Bitmap)pictureBox1.Image).GetPixel(x, y);
                    F = 0;
                    F = (uint)Farbe.A;
                    F = F << 8;
                    F += (uint)Farbe.R;
                    F = F << 8;
                    F += (uint)Farbe.G;
                    F = F << 8;
                    F += (uint)Farbe.B;
                    DataHG[x + AuflY * y] = F;
                    
                    Farbe = ((Bitmap)pictureBox2.Image).GetPixel(x, y);
                    F = 0;
                    F = (uint)Farbe.A;
                    F = F << 8;
                    F += (uint)Farbe.R;
                    F = F << 8;
                    F += (uint)Farbe.G;
                    F = F << 8;
                    F += (uint)Farbe.B;
                    Data2HG[x + AuflY * y] = F;

                    Messungen[x + AuflY * y] = -1;
                }

            DatenausDateilesen();

            /*aTimer = new System.Timers.Timer();
            aTimer.Elapsed += new ElapsedEventHandler(BildSetzen);
            aTimer.Interval = 20;                                           // alle 20 ms die Mal-Prozedur aufrufen -> entspricht 50 Hertz
            aTimer.Enabled = true;*/
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //System.IO.StreamWriter DateiDel = new System.IO.StreamWriter(Pfad);
            //DateiDel.Close();
            Form3 frm = new Form3();
            frm.ShowDialog();
            DatenausDateilesen();

            BildSetzen2(null,null);
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e) 
        {
            xpos = e.X;
            ypos = e.Y;
            BildSetzen1(null, null);

            label1.Text = "XPosition: " + xpos.ToString() + ", YPosition: " + ypos.ToString();
        }
        private void pictureBox2_MouseMove(object sender, MouseEventArgs e)
        {
            xpos2 = e.X;
            ypos2 = e.Y;

            M = Messungen[xpos2 + ypos2 * AuflY];

            label1.Text = "XPosition: " + xpos2.ToString() + ", YPosition: " + ypos2.ToString();

            BildSetzen2(null, null);
        }
        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        { //if (e.Button == MouseButtons.Left) Werte[Jahr] = Wert;
            SetKreis(xpos, ypos, 15, 0x7fff6622);
                        //aTimer.Enabled = false;             // Timer abschalten und 30 ms warten. Dann Hintergrund neu zeichnen und Timer wieder anschalten
                        //Thread.Sleep(30);

            //Hintergrund();
            //            aTimer.Enabled = true;

        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Datenbankverbindung();
            SetKreis(xpos, ypos, 10, 0xff6622);

        }
        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        { //if (e.Button == MouseButtons.Left) Werte[Jahr] = Wert;
            //SetKreis2(xpos, ypos, 15, 0x7fff6622);
            //            aTimer.Enabled = false;             // Timer abschalten und 30 ms warten. Dann Hintergrund neu zeichnen und Timer wieder anschalten
            //            Thread.Sleep(30);

            //Hintergrund();
            //            aTimer.Enabled = true;

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (M >= 0)
            {
                Form2return = dB[M];
                Form2 DatenDialog = new Form2(M, TimeStamp[M], dB[M]);
                //string Text;

                if (DatenDialog.ShowDialog(this) == DialogResult.OK)
                {
                    //DatenDialog.
                    //Text = DatenDialog.p;
                }

                DatenDialog.Dispose();
                dB[M] = Form2return;
                BildSetzen2(null,null);
            }
            //Form.ActiveForm.Visible = false;
            //Form.ActiveForm.ShowDialog();
            //Application.Run(new Form2());
            //Form2.ActiveForm.ShowDialog();
            //            Form2.ActiveForm.Visible = true;
        }
        public void BildSetzen1(object source, ElapsedEventArgs e)
        {
            //            Hintergrund_copy();

            // Bild generieren

            //System.Drawing.Color Farbe;
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
                    Data[x + AuflY * y] = DataHG[x + AuflY * y];
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
                    pictureBox1.Image = flag;
                }
            }

        }
        public void BildSetzen2(object source, ElapsedEventArgs e)
        {

            //            Hintergrund_copy();

            // Bild generieren

            //System.Drawing.Color Farbe;
            int i, x, y, nx, ny, prenx = 0, preny = 0 ;
            double dx, dy;

            if (AnzMesspunkte > 0)
            {
                for (y = 0; y < AuflY; y++)
                    for (x = 0; x < AuflX; x++)
                        if ((y & 0x3f) == 0 || (x & 0x3f) == 0)
                            SetPixel2(x, y, 0x7f880048);
                        else
                            SetPixel2(x, y, 0x7f180018);
                
                for(i = 0 ; i <= AnzMesspunkte ; i++)
                {
                    dx = ( TimeStamp[i] - TimeStamp[0]);
                    dx = dx / MessDauer;
                    nx = Convert.ToInt32(dx * AuflX);

                    dy = dB[i] - 20;
                    dy = (dy / 100) * AuflY;
                    ny = Convert.ToInt32(dy);
                    SetKreis2(nx, AuflY - ny, 10, i, 0xffff1111);

                    if (preny + prenx > 0)
                        //SetKreis2((nx + prenx) / 2, AuflY - ((ny + preny) / 2), 6, 0xffaa66dd);

                    prenx = nx; preny = ny;
                }


            }
            else
            {
                for (y = 0; y < AuflY; y++)
                    for (x = 0; x < AuflX; x++)
                    {
                        Data2[x + AuflY * y] = Data2HG[x + AuflY * y];
                    }
            }

            // Cursor zeichnen
            SetKreis2(xpos2, ypos2, 5, -1, 0x7f226622);
            for (x = 0; x < xpos2; x++)
            {
                SetPixel2(x, ypos2, 0x111111);
            }

            for (y = ypos2; y < AuflY; y++)
            {
                SetPixel2(xpos2, y, 0x111111);
            }

            unsafe
            {
                fixed (uint* pointer = Data2)
                {
                    System.IntPtr ptr = new System.IntPtr(pointer);
                    System.Drawing.Bitmap flag = new System.Drawing.Bitmap(AuflX, AuflY, AuflX * 4, PixelFormat.Format32bppArgb, ptr);
                    pictureBox2.Image = flag;
                }
            }

        }
        public void DatenausDateilesen()
        {
            string Zeile;
            string TeilString;
            string line;
            int i = 0, j = 0;

            System.DateTime Zeitstempel;

            System.IO.StreamReader Datei = new System.IO.StreamReader(Pfad);
            while (((line = Datei.ReadLine()) != null) & i < MaxDatensätze)
            {
                Zeile = line.ToString();

                if (Zeile.StartsWith("[MS_9]"))
                {
                    Zeile = Zeile.Substring(6);
                    TeilString = Zeile.Substring(0, Zeile.IndexOf('|'));
                    TimeStamp[j] = Convert.ToInt32(TeilString);

                    Zeile = Zeile.Substring(Zeile.IndexOf('|') + 1);
                    TeilString = Zeile.Substring(0, Zeile.IndexOf('|'));
                    dB[j] = Convert.ToDouble(TeilString);

                    j++;
                }
                i++;
            }
            Datei.Close();

            MinWert = Convert.ToInt32(TimeStamp[0]);
            MaxWert = Convert.ToInt32(TimeStamp[j - 1]);

            MessDauer = MaxWert - MinWert;
            AnzMesspunkte = j - 1;

            Zeitstempel = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            Zeitstempel = Zeitstempel.AddSeconds(MinWert);
            Zeitstempel = Zeitstempel.AddHours(1);
            Zeitstempel.ToLocalTime();

            label6.Text = Zeitstempel.ToString();

            Zeitstempel = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            Zeitstempel = Zeitstempel.AddSeconds(MaxWert);
            Zeitstempel = Zeitstempel.AddHours(1);
            Zeitstempel.ToLocalTime();

            label7.Text = Zeitstempel.ToString();

            MessageBox.Show(j.ToString() + " Datensätze gelesen");
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
                MessageBox.Show(ex.ToString());
                return;
            }
            finally
            {
                myAccessConn.Close();
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
