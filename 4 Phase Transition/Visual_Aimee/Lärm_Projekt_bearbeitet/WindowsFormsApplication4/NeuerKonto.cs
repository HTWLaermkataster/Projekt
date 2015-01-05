using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public partial class NeuerKonto : Form
    {
        public NeuerKonto()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Validate();
        }
    }
}
