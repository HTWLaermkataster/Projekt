using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pManagement.Properties;
using System.Collections.ObjectModel;
using System.Data.Services.Client;
using System.Net;
using pManagement.ServiceReference1;

namespace pManagement
{
    public delegate MeasuringPoint MessOrtHandler();

    public partial class Ort : Form
    {
        public MeasuringPoint O;
        public NoiseMapPosition P;
        public MessOrtHandler _MOrtAusgewaehlt;
        
        public Ort()
        {
            InitializeComponent();
        }
        public Ort(MeasuringPoint O, NoiseMapPosition P)
        {
            InitializeComponent();
            this.O = O;
            this.P = P;
        }
        private MeasuringPoint MortAuswahl()
        {
                return O;       
        }

        private void BOrtOk_Click(object sender, EventArgs e )
        {
            O.Name=TBOrtName.Text;
            O.Notes=TBOrtNotes.Text;
            O.Position = P;
            this.Hide();
        }
    }
}
