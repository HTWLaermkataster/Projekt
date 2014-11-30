using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt_Laerm
{
    public partial class Form2 : Form
    {
        public Form2(int M, int MessZeitpunkt, double deziBel)
        {
            System.DateTime Zeitstempel;

            Zeitstempel = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            Zeitstempel = Zeitstempel.AddSeconds(MessZeitpunkt);
            Zeitstempel = Zeitstempel.AddHours(1);
            Zeitstempel.ToLocalTime();

            InitializeComponent();

            if ( M >= 0)
            {
                textBox1.Text = deziBel.ToString();
                textBox2.Text = Zeitstempel.ToString();
                textBox3.Text = "Messpunkt: " + M.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.Form2return = Convert.ToDouble( textBox1.Text );
            this.Close();
        }
    }
}
