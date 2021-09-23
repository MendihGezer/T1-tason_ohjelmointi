using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kahvila
{
    public partial class RuokalistaForm : Form
    {
        public RuokalistaForm()
        {
            InitializeComponent();
            infoPL.Visible = true;
        }

        private void RuokalistaForm_Load(object sender, EventArgs e)
        {
            MeistaLB.Text = "Keudan oppilaskunnan kahvila palvelee luokassa 320 välituntisin \n";
            MeistaLB.Text += "9:00 - 14.30 joka päivä maanantaista torstaisin ja perjantaisin \n";
            MeistaLB.Text += "9:00 - 12.30. \n\nKeudan oppilaskunnan kahvilasta saa lämpimien \n";
            MeistaLB.Text += "juomien lisäksi virvokkeita sekä pientä purtavaa sekä makeisia \n";
            MeistaLB.Text += "Tervetuloa tutustumaan!";
            MeistaLB.Font = new Font("Arial", 12);

        }

        private void MeistaBT_Click(object sender, EventArgs e)
        {
            infoPL.Visible = true;
            ruoatPL.Visible = false;
            juomatPL.Visible = false;
            jalkiruoatPL.Visible = false;
            koriPL.Visible = false;

        }

        private void RuoatBT_Click(object sender, EventArgs e)
        {
            infoPL.Visible = false;
            ruoatPL.Visible = true;
            juomatPL.Visible = false;
            jalkiruoatPL.Visible = false;
            koriPL.Visible = false;

        }

        private void JuomatBT_Click(object sender, EventArgs e)
        {
            infoPL.Visible = false;
            ruoatPL.Visible = false;
            juomatPL.Visible = true;
            jalkiruoatPL.Visible = false;
            koriPL.Visible = false;

        }

        private void HerkutBT_Click(object sender, EventArgs e)
        {
            infoPL.Visible = false;
            ruoatPL.Visible = false;
            juomatPL.Visible = false;
            jalkiruoatPL.Visible = true;
            koriPL.Visible = false;
        }

        private void KoriBT_Click(object sender, EventArgs e)
        {
            infoPL.Visible = false;
            ruoatPL.Visible = false;
            juomatPL.Visible = false;
            jalkiruoatPL.Visible = false;
            koriPL.Visible = true;
        }

        private void exitBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
