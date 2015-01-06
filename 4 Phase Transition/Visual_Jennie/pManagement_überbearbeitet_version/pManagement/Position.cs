using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pManagement
{
    public class Position
    {
        public int Xwert { get; set; }
        public int Ywert { get; set; }

        public Position(int Xwert, int Ywert)
        {
            this.Xwert = Xwert;
            this.Ywert = Ywert;
        }
    }
}
