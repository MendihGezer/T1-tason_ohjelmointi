using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10_Kysymysta
{
    public partial class LomakeForm : Form
    {
        int laskuri = 0;
        int oikein = 0;
        string[] oikeatVastaukset = new string[] { "B", "D", "A", "A", "C", "A", "B", "A", "C", "D" };
        string[] vastaukset = new string[10];
        public LomakeForm()
        {
            InitializeComponent();
            ARB.CheckedChanged += new EventHandler(radioButton_CheckedChanged);

        }

        private void LomakeForm_Load(object sender, EventArgs e)
        {

        }
        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton && laskuri < 10)
            {
                RadioButton radioButton = (RadioButton)sender;
                vastaukset[laskuri] = radioButton.Text;
                laskuri++;
                KysymysLB.Text = "Vastaus " + laskuri + ". kysymykseen:";
            }
            else
            {
                VastausLB.Text = "";
                ARB.Enabled = false;
                BRB.Enabled = false;
                CRB.Enabled = false;
                DRB.Enabled = false;
                for (int j = 0; j < 10; j++)
                { 
                    if(vastaukset[j] == oikeatVastaukset[j])
                    {
                        oikein++;
                    }
                }
                VastausLB.Text = "Oikeita vastauksia oli: " + oikein;
                VastausLB.Visible = true;
            }
            TyhjaaVastaus();
        }
        private void TyhjaaVastaus()
        {
            if(ARB.Checked == true)
            {
                ARB.Checked = false;
                laskuri--;
            }
            if (BRB.Checked == true)
            {
                BRB.Checked = false;
                laskuri--;
            }
            if (CRB.Checked == true)
            {
                CRB.Checked = false;
                laskuri--;
            }
            if (DRB.Checked == true)
            {
                DRB.Checked = false;
                laskuri--;
            }
        }
    }
}
