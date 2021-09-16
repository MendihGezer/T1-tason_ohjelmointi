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

namespace Muistio
{
    public partial class MuistioForm : Form
    {
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;
        public MuistioForm()
        {
            InitializeComponent();
        }
        private void UusiTiedosto()
        {
            try
            {
                if (!string.IsNullOrEmpty(TekstiTB.Text))
                {
                    MessageBox.Show("You must save first!");
                }
                else
                {
                    TekstiTB.Text = string.Empty;
                    Text = "Untitled";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void TallennaTiedosto()
        {
            try
            {
                if (!string.IsNullOrEmpty(TekstiTB.Text))
                {
                    saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Textfile (*.txt) | *.txt|Rich Text Format (*.rtf | *.rtf)";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        File.WriteAllText(saveFileDialog.FileName, TekstiTB.Text);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void AvaaTiedosto()
        {
            try
            {
                openFileDialog = new OpenFileDialog();
                if(openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    TekstiTB.Text = File.ReadAllText(openFileDialog.FileName);
                    Text = openFileDialog.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening file" + ex);
            }
        }   

        private void MuistioForm_Load(object sender, EventArgs e)
        {
            fontDialog = new FontDialog();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UusiTiedosto();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AvaaTiedosto();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TallennaTiedosto();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(TekstiTB.Text))
                {
                    TallennaTiedosto();
                    }
                else
                {
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (fontDialog.ShowDialog() == DialogResult.OK);
                {
                    TekstiTB.Font = fontDialog.Font;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
    }
}
