using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace pManagement
{
    public partial class messdatenAnzeigen : Form
    {
        List<Messwert> Mlist = new List<Messwert>();
        Messwert[] Marray;
        private int i;
        private XElement root;
        private double average=0;
        private int min;
        private int max;
        

        public messdatenAnzeigen(XElement root)
        {
            InitializeComponent();
            this.root = root;
            IEnumerable<XElement> elements = root.Elements();
            foreach (XElement item in elements)
            {
                Messwert temp = new Messwert(item.Element("Ort").Value, Convert.ToInt16(item.Element("Wert").Value),
                    Convert.ToInt16(item.Element("Xwert").Value), Convert.ToInt16(item.Element("YWert").Value));
                Mlist.Add(temp);
            }
            Marray = new Messwert[Mlist.Count];
            Mlist.CopyTo(Marray);
            i = 0;

            textBox2.Text = Mlist.First().Ort;
            textBox5.Text = Convert.ToString(Mlist.First().Wert);
            min = Mlist.First().Wert;
            max = Mlist.First().Wert;
            foreach (Messwert wert in Mlist)
            {
                if(min>wert.Wert)
                    min = wert.Wert;
                if (max < wert.Wert)
                    max = wert.Wert;

                average = average+wert.Wert;
            }
            average = average/Mlist.Count;
            textBox1.Text = Convert.ToString(min);
            textBox3.Text = Convert.ToString(max);
            textBox4.Text = Convert.ToString(average);
            LabelTotal.Text = Convert.ToString(Mlist.Count);
            LabelActual.Text = Convert.ToString(i+1);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void schliessen_button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void schließen_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void weiter_button_Click(object sender, EventArgs e)
        {
 
            i++;
            zurück_button.Enabled = true;
            textBox2.Text = Marray[i].Ort;
            textBox5.Text = Convert.ToString(Marray[i].Wert);
            LabelActual.Visible = true;
            LabelActual.Text = Convert.ToString(i+1);
            if (i+1 == Marray.Length)
                weiter_button.Enabled = false;
        }

        private void zurück_button_Click(object sender, EventArgs e)
        {
            i--;
            weiter_button.Enabled = true;
            textBox2.Text = Marray[i].Ort;
            textBox5.Text = Convert.ToString(Marray[i].Wert);
            LabelActual.Visible = true;
            LabelActual.Text = Convert.ToString(i+1);
            if (i == 0)
                zurück_button.Enabled= false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
