using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laerm
{
    class Messwerte
    {
        public double ywert { get ;  set ;  }
        public double xwert { get ;  set; } 
        public double dbwert { get ; set ;  }
        public string OrtsName { get; set; }
        public DateTime datum { get; set; }

        //Konstruktoren
        public Messwerte () {}
        public Messwerte(double x, double y, double dbwert, string Ort,  string datum)
        {
            xwert = x;
            ywert = y;
            this.dbwert = dbwert;
            this.OrtsName = Ort;
            this.datum = Convert.ToDateTime(datum);
        }
    }
}
