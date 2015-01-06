using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;


namespace pManagement
{
    

    public partial class Form1 : Form
    {
        private Position Pos;
        public int Xpos { get; set; } int Ypos { get; set; }
        private Image bmp;
        
       
        private string pathImage = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\hallenplan_2.JPG";
        public Form1()
        {
            InitializeComponent();

            this.bmp = new Bitmap(pathImage);
            
            pictureBox1.Image = bmp;
            Draw();

            this.pictureBox1.MouseMove += new MouseEventHandler(pictureBox1_MouseMove);
            this.pictureBox1.MouseClick+=pictureBox1_Click;
            this.pictureBox1.Paint += pictureBox1_Paint;
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\dbwerte.xml";
            XElement root = XElement.Load(@path);
            Form dummy=new messdatenAnzeigen(root);
            dummy.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Messdateneingeben_button_Click(object sender, EventArgs e)
        {
            //Form dummy=new Messdateneingeben();
            //dummy.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form dummy = new Messdateneingeben(Pos );
            dummy.ShowDialog();
            Draw(Pos);
                             
        }

        private void Draw(Position Pos)
        {
            using (Graphics g = Graphics.FromImage(bmp))
            {
                string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\dbwerte.xml";

                XElement root = XElement.Load(@path);
                IEnumerable<XElement> elements = root.Elements();
                foreach (XElement item in elements)
                {
                    Color Farbe=Color.Black;
                    if (Convert.ToInt16(item.Element("Wert").Value) < 30)
                        Farbe = Color.GreenYellow;
                    else if (Convert.ToInt16(item.Element("Wert").Value) < 60)
                        Farbe = Color.Orange;
                    else if (Convert.ToInt16(item.Element("Wert").Value) > 59)
                        Farbe = Color.Red;

                    if (Pos.Xwert == Convert.ToInt16(item.Element("Xwert").Value) &&
                        Pos.Ywert == Convert.ToInt16(item.Element("YWert").Value))
                    {
                        g.DrawLine(new Pen(Farbe, 20), Pos.Xwert * bmp.Width / pictureBox1.Width,
                        Pos.Ywert * bmp.Height / pictureBox1.Height, (Pos.Xwert + 5) * bmp.Width / pictureBox1.Width,
                        (Pos.Ywert + 5) * bmp.Height / pictureBox1.Height);
                        
                        g.Flush();

                        pictureBox1.Invalidate();
                        
                        //pictureBox1.Image.
                    }
                }
            }      
        }

        private void Draw()
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\dbwerte.xml";

            XElement root = XElement.Load(@path);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                IEnumerable<XElement> elements = root.Elements();
                foreach (XElement item in elements)
                {
                    Color Farbe = Color.Black;
                    if (Convert.ToInt16(item.Element("Wert").Value) < 30)
                        Farbe = Color.GreenYellow;
                    else if (Convert.ToInt16(item.Element("Wert").Value) < 60)
                        Farbe = Color.Orange;
                    else if (Convert.ToInt16(item.Element("Wert").Value) > 59)
                        Farbe = Color.Red;


                    g.DrawLine(new Pen(Farbe, 20),
                        Convert.ToInt16(item.Element("Xwert").Value)*bmp.Width/pictureBox1.Width,
                        Convert.ToInt16(item.Element("YWert").Value)*bmp.Height/pictureBox1.Height,
                        (Convert.ToInt16(item.Element("Xwert").Value) + 5)*bmp.Width/pictureBox1.Width,
                        (Convert.ToInt16(item.Element("YWert").Value) + 5)*bmp.Height/pictureBox1.Height);

                    g.Flush();

                    pictureBox1.Invalidate();
                }
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Xpos = e.X;
            Ypos = e.Y;
            Pos= new Position(Xpos,Ypos);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
