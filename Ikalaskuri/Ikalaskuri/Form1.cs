using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ikalaskuri
{
    public partial class Lomake : Form
    {
        public Lomake()
        {
            InitializeComponent();
        }

        private void LaskeBT_Click(object sender, EventArgs e)
        {
            DateTime synttari = SynttariDTP.Value;
            DateTime nyt = DateTime.Now;
            double erotus = Math.Round((nyt - synttari).TotalDays);
            VuodetLB.Text = Math.Ceiling(erotus / 365.25) + " vuotta";
            KkLB.Text = Math.Ceiling(erotus*12 / 365.25) + " kuukautta";
            PaivaLB.Text = (erotus) + " päivää";
            TunnitLB.Text = (erotus * 24 + " tuntia");
            MinLB.Text = (erotus * 24 * 60 + " minuuttia");
            SsLB.Text = (erotus * 24 * 3600 + " sekunttia");
            VuodetLB.Visible = true;
            KkLB.Visible = true;
            PaivaLB.Visible = true;
            TunnitLB.Visible = true;
            MinLB.Visible = true;
            SsLB.Visible = true;

        }
    }
}
