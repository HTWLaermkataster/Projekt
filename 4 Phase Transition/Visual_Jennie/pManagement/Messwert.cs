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
        public int MinWert { get; set; } 
        public int XWert { get; set; }
        public int YWert { get; set; }
        public int MaxWert { get; set; }
        public int Average { get; set; } 
        public Messwert ( string Ort, int MaxWert, int MinWert, int Average, int Xwert, int Ywert)
        {
            this.Ort = Ort;
            this.MinWert = MinWert;
            this.YWert = YWert;
            this.XWert = XWert;
            this.Average = Average;
            this.MaxWert = MaxWert;

        }
        public Messwert(){}
    }
}
