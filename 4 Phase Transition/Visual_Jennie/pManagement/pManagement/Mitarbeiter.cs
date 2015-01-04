using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pManagement
{
    class Mitarbeiter
    {
        public string Name { get; set; }
        public string Passwort { get; set; }
        public Mitarbeiter(){}

        public Mitarbeiter(string Name, string Passwort)
        {
            this.Name = Name;
            this.Passwort = Passwort;
        }
    }
}
