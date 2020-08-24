using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Bedrijf
    {
        public string Name { get; set; }
        public string BtwNummer { get; set; }

        public List<Werknemer> Werknemers { get; set; }

        public Bedrijf(string name, string btwNummer)
        {
            Name = name;
            BtwNummer = btwNummer;
            Werknemers = new List<Werknemer>();
        }
        public void VerwijderWerknemer(Werknemer werknemer)
        {
            Werknemers.Remove(werknemer);
        }
        public void VoegWerknemerToe(Werknemer werknemer)
        {
            Werknemers.Add(werknemer);

        }
        public override string ToString()
        {
            return Name;
        }
    }
}
