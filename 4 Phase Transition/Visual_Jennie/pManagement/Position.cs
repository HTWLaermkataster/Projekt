using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pManagement
{
    public class Position
    {
        public int XWert { get; set; }
        public int YWert { get; set; }

        public Position(int XWert, int YWert)
        {
            this.XWert = XWert;
            this.YWert = YWert;
        }
    }
}
