using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuosituimmatNimet
{
    public partial class NimiLomake : Form
    {
        public NimiLomake()
        {
            InitializeComponent();
        }

        private void TarkastaBT_Click(object sender, EventArgs e)
        {
            VastausLB.Text = "";
            VastausLB.Visible = false;
            string[] pojat = File.ReadAllLines("C:\\Users\\mendih.gezer\\source\\repos\\T1-tason_ohjelmointi\\SuosituimmatNimet\\pojat.txt");
            string[] tytot = File.ReadAllLines("C:\\Users\\mendih.gezer\\source\\repos\\T1-tason_ohjelmointi\\SuosituimmatNimet\\tytot.txt");
            string nimi = NimesiTB.Text;
            int laskurip = 1;
            int laskurit = 1;
            foreach (string poju in pojat)
            {
                if(nimi == poju)
                {
                    VastausLB.Text = "Nimesi on " + laskurip + ". suosituin nimi vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskurip++;
            }
            foreach (string friidu in tytot)
            {
                if (nimi == friidu)
                {
                    VastausLB.Text = "Nimesi on " + laskurit + ". suosituin tyttöjen nimi vuonna 2020";
                    VastausLB.Visible = true;
                }
                laskurit++;
            }
            if (VastausLB.Visible == false)
            {
                VastausLB.Text = "Nimesi ei löytynyt suosituimpien joukosta!";
                VastausLB.Visible = true;
            }
        
        }
    }
}
