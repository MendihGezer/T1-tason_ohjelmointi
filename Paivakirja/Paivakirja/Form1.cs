using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Paivakirja
{
    public partial class PaivakirjaForm : Form
    {
        public PaivakirjaForm()
        {
            InitializeComponent();
        }

        private void SyotaTB_TextChanged(object sender, EventArgs e)
        {
            string teksti = File.ReadAllText(@"C:\\Users\\mendih.gezer\\source\\repos\\T1-tason_ohjelmointi\\Paivakirja\\paivakirja.txt");
            teksti += SyotaTB.Text;
            teksti += " " + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + "\n";
            TextWriter text = new StreamWriter("C:\\Users\\mendih.gezer\\source\\repos\\T1-tason_ohjelmointi\\Paivakirja\\paivakirja.txt");
            text.Write(teksti);
            text.Close();
            Application.Exit();
        }
    }
}
