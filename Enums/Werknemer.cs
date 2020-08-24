using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Werknemer
    {
        public string Name { get; set; }
        public Salaris Salary { get; set; }
        public string Country { get; set; }

        public Werknemer(string name, Salaris salary, string country = "België")
        {
            Name = name;
            Salary = salary;
            Country = country;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
