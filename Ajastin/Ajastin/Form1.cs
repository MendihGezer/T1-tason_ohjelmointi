using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Ajastin
{
    public partial class TimerForm : Form
    {
        public TimerForm()
        {
            InitializeComponent();
        }

        private int kokonaisaika;
        private void TimerForm_Load(object sender, EventArgs e)
        {
            StopBT.Enabled = false;
            for(int i=0; i < 60; i++)
            {
                MinCB.Items.Add(i.ToString());
                SecCB.Items.Add(i.ToString());
            }
            MinCB.SelectedIndex = 30;
            SecCB.SelectedIndex = 0;
        }

        private void StartBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = false;
            StopBT.Enabled = true;

            int minuutit = int.Parse(MinCB.SelectedItem.ToString());
            int sekunnit = int.Parse(SecCB.SelectedItem.ToString());
            kokonaisaika = (minuutit * 60) + sekunnit;
            TimerTM.Enabled = true;
        }

        private void StopBT_Click(object sender, EventArgs e)
        {
            StartBT.Enabled = true;
            StopBT.Enabled = false;
            kokonaisaika = 0;
            TimerTM.Enabled = false;
            AikaLB.Text = "00:00";
        }

        private void TimerTM_Tick(object sender, EventArgs e)
        {
            if(kokonaisaika > 0)
            {
                kokonaisaika--;
                int minuutit = kokonaisaika / 60;
                int sekunnit = kokonaisaika - (minuutit * 60);
                AikaLB.Text = minuutit.ToString() + ":" + sekunnit.ToString();
            }
            else
            {
                TimerTM.Stop();
                MessageBox.Show("Aikasi loppui!");
            }
        }
    }
}
