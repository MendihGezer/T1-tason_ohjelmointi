using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMI_laskuri
{
    public partial class Lomake : Form
    {
        public Lomake()
        {
            InitializeComponent();
        }

        private void BMIBT_Click(object sender, EventArgs e)
        {
            double paino = 0, pituus = 0;
            paino = Convert.ToDouble(painoTB.Text);
            pituus = Convert.ToDouble(pituusTB.Text);
            double bmi = Math.Round(paino / (pituus * pituus),2);
            if (bmi < 18.5)
            {
                VastausLB.Text = "Painoindeksisi on: " + bmi;
                VastausLB.ForeColor = Color.DarkRed;
                KuvausLB.Text = "Alipaino";
                KuvausLB.ForeColor = Color.Aqua;
                KuvausLB.Visible = true;
            }
            else if (bmi < 25)
            {
                VastausLB.Text = "Painoindeksisi on: " + bmi;
                VastausLB.ForeColor = Color.OrangeRed;
                KuvausLB.Text = "Normaalipaino";
                KuvausLB.ForeColor = Color.OrangeRed;
                KuvausLB.Visible = true;
            }
            else if (bmi < 40)
            {
                VastausLB.Text = "Painoindeksisi on: " + bmi;
                VastausLB.ForeColor = Color.Green;
                KuvausLB.Text = "Ylipaino";
                KuvausLB.ForeColor = Color.Green;
                KuvausLB.Visible = true;
            }
            else
            {
                VastausLB.Text = "Painoindeksisi on: " + bmi;
                VastausLB.ForeColor = Color.Gold;
                KuvausLB.Text = "Huomattava ylipaino";
                KuvausLB.ForeColor = Color.Gold;
                KuvausLB.Visible = true;
            }
        }
    }
}
