using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LukujenJarjestys
{
    public partial class LukujenJarjestys : Form
    {
        List<int> jono = new List<int>();
        public LukujenJarjestys()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {

                if(uusilukuTB.Text == "-999")
                {
                    VastausLB.Text = "";
                    int[] jonot = jono.ToArray();
                    Array.Sort(jonot);
                    foreach (var item in jonot)
                    {
                        VastausLB.Text += item + " ";
                    }

                    else
                    {

                        jono.Add(Int32.Parse(uusilukuTB.Text));
                        uusilukuTB.Text = "";

                    }

                    

                }
                 
                if (e.KeyChar == (char)Keys.Escape)
                {

                    TyhjaaLomake();


                }


            }
        }
    }
}
