using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalasananTarkistus
{
    public partial class SalasanaForm : Form
    {
        public SalasanaForm()
        {
            InitializeComponent();
        }

        private void SalasanaPanel_Paint(object sender, PaintEventArgs e)
        {



        }

        private void TarkistaBT_Click(object sender, EventArgs e)
        {
            if(KayttajaTB.Text == "Memo" && SalasanaTB.Text == "123")
            {
                SalasanaPanel.Visible = false;
                SalasanaOikeinPanel.Visible = true;

            }
            else
            {

                VirheViestiLB.Text = "Käyttäjätunnus tai salasana virheellinen!";
                VirheViestiLB.Visible = true;

            }

        }


    }
}
