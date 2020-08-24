using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enums
{
    public partial class Form1 : Form
    {
        List<Werknemer> werknemersList = new List<Werknemer>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            werknemersList.Add(new Werknemer("Geert",new Salaris(contract : "Week")));
            werknemersList.Add(new Werknemer("Frank",new Salaris(bruto : 2200.00)));
            werknemersList.Add(new Werknemer("Daniël",new Salaris(contract: "Week"), country: "Nederland"));
            werknemersList.Add(new Werknemer("Sofia",new Salaris(bruto : 3110.00),"Nederland"));

            cbNamen.DataSource = werknemersList;
        }

        private void cbNamen_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSalary.Text = "Salaris: €" + werknemersList[cbNamen.SelectedIndex].Salary.ToString();
            lblCountry.Text = "Land: " + werknemersList[cbNamen.SelectedIndex].Country;
            lblNet.Text = "Netto: €" + Math.Round(werknemersList[cbNamen.SelectedIndex].Salary.BerekenNetto(),2) + " " +
                           werknemersList[cbNamen.SelectedIndex].Salary.Contract.ToLower() + "elijks";
        }
    }
}
