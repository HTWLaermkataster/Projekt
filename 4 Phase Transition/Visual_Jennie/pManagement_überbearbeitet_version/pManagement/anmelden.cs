using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace pManagement
{
    public partial class anmelden : Form
    {
        private Mitarbeiter M1;
        private string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\benutzer.xml";
        private XElement root;


        public anmelden()
        {
            InitializeComponent();
        }

        private void anmelden_button_Click(object sender, EventArgs e)
        {
            M1=new Mitarbeiter(mitarbeiter_textBox.Text,passwort_textBox.Text);
            if (File.Exists(@path))
            {
                root = XElement.Load(@path);
                IEnumerable<XElement> elements = root.Elements();
                foreach (XElement item in elements)
                {
                    if (item.Element("Name").Value == M1.Name && item.Element("Passwort").Value == M1.Passwort)
                    {
                        Form dummy = new Form1();
                        dummy.Show();
                        this.Hide();
                        break;
                    }
                    else
                    {
                        AnmeldungFailed.Visible = true;
                        mitarbeiter_textBox.Clear();
                        passwort_textBox.Clear();
                    }
                }
            }
            else
            {
                AnmeldungFailed.Text = "Keine Benutzer bekannt";
                AnmeldungFailed.Visible = true;
            }


        }

        private void schließen_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mitarbeiter_textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form temp= new UserCreate();
            temp.ShowDialog();
        }

        private void AnmeldungFailed_Click(object sender, EventArgs e)
        {

        }
    }
}
