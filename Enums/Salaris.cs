using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{
    class Salaris
    {
        public double Bruto { get; set; }
        public double Taxation { get; set; }
        public string Contract { get; set; }

        public Salaris(double bruto = 2440.55, double taxation = .21, string contract = "Maand")
        {
            Bruto = bruto;
            Taxation = taxation;
            Contract = contract;
        }
        public double BerekenNetto()
        {
            double netto = Bruto - (Bruto * Taxation);
            if (Contract == "Week")
            {
                netto /= 4;
            }
            return netto;
        }

        public override string ToString()
        {
            return Bruto.ToString();
        }
    }
}
