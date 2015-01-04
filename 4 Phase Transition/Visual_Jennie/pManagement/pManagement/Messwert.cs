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
        public Messwert ( string Ort, int Wert)
        {
            this.Ort = Ort;
            this.Wert = Wert;
        }
        public Messwert(){}
    }
}
