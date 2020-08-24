using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enums
{
    class Programmeur : Werknemer
    {
        public double BrutoWagen { get; set; }
        public double NettoWagen { get; set; }


        List<string> Talen = new List<string>()
        {
            "HTML",
            "JAVA SE 11"
        };

        public Programmeur(string name, Salaris salary, string country = "België", double brutowagen = 123.00, double nettowagen = 50.00) : base(name, salary, country)
        {
            Name = name;
            Country = country;
            BrutoWagen = brutowagen;
            NettoWagen = nettowagen;

        
        }

    }
}
