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
        
        public Form1()
        {
            InitializeComponent();
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\dbwerte.xml";
            XElement root = XElement.Load(@path);
            Form dummy=new messdatenAnzeigen(root);
            dummy.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Messdateneingeben_button_Click(object sender, EventArgs e)
        {
            Form dummy=new Messdateneingeben();
            dummy.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
