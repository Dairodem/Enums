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
        List<Bedrijf> BedrijvenList = new List<Bedrijf>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bedrijf bedrijf1 = new Bedrijf("De Fabriek", "4354.298.897");
            Bedrijf bedrijf2 = new Bedrijf("Het Kantoortje", "8251.714.342");
            Bedrijf bedrijf3 = new Bedrijf("Het Derde Bedrijf", "9363.399.366");

            BedrijvenList.Add(bedrijf1);
            BedrijvenList.Add(bedrijf2);
            BedrijvenList.Add(bedrijf3);

            bedrijf1.Werknemers.Add(new Werknemer("Geert",new Salaris(contract : "Week")));
            bedrijf1.Werknemers.Add(new Werknemer("Frank",new Salaris(bruto : 3200.00)));
            bedrijf1.Werknemers.Add(new Werknemer("Mark",new Salaris(contract: "Week"), country: "Nederland"));

            bedrijf2.Werknemers.Add(new Werknemer("Sofia",new Salaris(bruto : 3110.00),"Nederland"));
            bedrijf2.Werknemers.Add(new Werknemer("Geert", new Salaris(contract: "Week")));
            bedrijf2.Werknemers.Add(new Werknemer("Jan", new Salaris(bruto: 2200.00)));

            bedrijf3.Werknemers.Add(new Werknemer("Daniël", new Salaris(contract: "Week"), country: "Frankrijk"));
            bedrijf3.Werknemers.Add(new Werknemer("Sofie", new Salaris(contract: "Week"), country: "Duitsland"));
            bedrijf3.Werknemers.Add(new Werknemer("Bert", new Salaris(bruto: 2450.00)));


            cbBedrijven.DataSource = BedrijvenList;
        }

        private void cbNamen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbNamen.SelectedIndex < 0)
            {
                cbNamen.SelectedIndex = 0;
            }
            lblSalary.Text = "Salaris: €" + BedrijvenList[cbBedrijven.SelectedIndex].Werknemers[cbNamen.SelectedIndex].Salary.ToString();
            lblCountry.Text = "Land: " + BedrijvenList[cbBedrijven.SelectedIndex].Werknemers[cbNamen.SelectedIndex].Country;
            lblNet.Text = "Netto: €" + Math.Round(BedrijvenList[cbBedrijven.SelectedIndex].Werknemers[cbNamen.SelectedIndex].Salary.BerekenNetto(),2) + " " +
                           BedrijvenList[cbBedrijven.SelectedIndex].Werknemers[cbNamen.SelectedIndex].Salary.Contract.ToLower() + "elijks";
        }

        private void cbBedrijven_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbNamen.DataSource = null;
            cbNamen.DataSource = BedrijvenList[cbBedrijven.SelectedIndex].Werknemers;
            lblBtw.Text = "BTW-nr.: " + BedrijvenList[cbBedrijven.SelectedIndex].BtwNummer;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            BedrijvenList[cbBedrijven.SelectedIndex].VerwijderWerknemer(cbNamen.SelectedItem as Werknemer);

            cbNamen.DataSource = null;
            cbNamen.DataSource = BedrijvenList[cbBedrijven.SelectedIndex].Werknemers;

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();


            if (form2.ShowDialog() == DialogResult.OK)
            {

                BedrijvenList[cbBedrijven.SelectedIndex].VoegWerknemerToe(new Werknemer(form2.txtName.Text,new Salaris((double)form2.numSalary.Value),form2.txtCountry.Text));

                cbNamen.DataSource = null;
                cbNamen.DataSource = BedrijvenList[cbBedrijven.SelectedIndex].Werknemers;
            }

        }
    }
}
