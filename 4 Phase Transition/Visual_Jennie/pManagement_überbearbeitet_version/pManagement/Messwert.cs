using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pManagement
{
    class Messwert
    {
        public string Ort { get; set; }
        public int Wert { get; set; } 
        public int Xwert { get; set; }
        public int Ywert { get; set; }
        public Messwert ( string Ort, int Wert, int Xwert, int Ywert)
        {
            this.Ort = Ort;
            this.Wert = Wert;
            this.Ywert = Ywert;
            this.Xwert = Xwert;
        }
        public Messwert(){}
    }
}
