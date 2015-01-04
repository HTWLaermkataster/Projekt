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
    public partial class UserCreate : Form
    {
        public UserCreate()
        {
            InitializeComponent();
        }
        private string path = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName + "\\benutzer.xml";
        private Mitarbeiter temp;
        private void bestätigen_button_Click(object sender, EventArgs e)
        {
            if (TBPasswort.Text != TBPasswortBestätigen.Text||TBPasswort.Text=="")
            {
                PasswortNichtIdentischLabel.Visible = true;
                TBPasswort.Text = "";
                TBPasswortBestätigen.Text = "";
            }
            else
            {
                try
                {
                    temp = new Mitarbeiter(TBBenutzername.Text,TBPasswort.Text);

                    if (File.Exists(@path) == false)
                    {
                        XElement first = new XElement("Personen");
                        first.Save(@path);
                    }

                    XElement root = XElement.Load(@path);

                    XElement Person = new XElement("Person",
                               new XElement("Name", temp.Name),
                               new XElement("Passwort", temp.Passwort));

                    root.Add(Person);
                    root.Save(@path);

                }

                catch (Exception) { }
                this.Close();

            }
        }

        private void abbrechen_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
