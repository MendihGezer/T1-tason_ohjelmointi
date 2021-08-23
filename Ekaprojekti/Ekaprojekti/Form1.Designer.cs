namespace Ekaprojekti
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TekstiLB = new System.Windows.Forms.Label();
            this.muutatekstiBt = new System.Windows.Forms.Button();
            this.PeruutaC = new System.Windows.Forms.Button();
            this.TB = new System.Windows.Forms.TextBox();
            this.ViestiLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TekstiLB
            // 
            this.TekstiLB.AutoSize = true;
            this.TekstiLB.Location = new System.Drawing.Point(244, 190);
            this.TekstiLB.Name = "TekstiLB";
            this.TekstiLB.Size = new System.Drawing.Size(183, 29);
            this.TekstiLB.TabIndex = 0;
            this.TekstiLB.Text = "Anna etunimesi:";
            // 
            // muutatekstiBt
            // 
            this.muutatekstiBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.muutatekstiBt.Location = new System.Drawing.Point(433, 237);
            this.muutatekstiBt.Name = "muutatekstiBt";
            this.muutatekstiBt.Size = new System.Drawing.Size(185, 71);
            this.muutatekstiBt.TabIndex = 1;
            this.muutatekstiBt.Text = "Muuta teksti";
            this.muutatekstiBt.UseVisualStyleBackColor = false;
            this.muutatekstiBt.Click += new System.EventHandler(this.muutatekstiBt_Click);
            // 
            // PeruutaC
            // 
            this.PeruutaC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PeruutaC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PeruutaC.Location = new System.Drawing.Point(735, 237);
            this.PeruutaC.Name = "PeruutaC";
            this.PeruutaC.Size = new System.Drawing.Size(185, 71);
            this.PeruutaC.TabIndex = 2;
            this.PeruutaC.Text = "Peruuta";
            this.PeruutaC.UseVisualStyleBackColor = false;
            this.PeruutaC.Click += new System.EventHandler(this.PeruutaC_Click);
            // 
            // TB
            // 
            this.TB.Location = new System.Drawing.Point(433, 187);
            this.TB.Name = "TB";
            this.TB.Size = new System.Drawing.Size(487, 35);
            this.TB.TabIndex = 3;
            // 
            // ViestiLB
            // 
            this.ViestiLB.AutoSize = true;
            this.ViestiLB.Location = new System.Drawing.Point(267, 393);
            this.ViestiLB.Name = "ViestiLB";
            this.ViestiLB.Size = new System.Drawing.Size(72, 29);
            this.ViestiLB.TabIndex = 4;
            this.ViestiLB.Text = "Viesti";
            this.ViestiLB.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 747);
            this.Controls.Add(this.ViestiLB);
            this.Controls.Add(this.TB);
            this.Controls.Add(this.PeruutaC);
            this.Controls.Add(this.muutatekstiBt);
            this.Controls.Add(this.TekstiLB);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TekstiLB;
        private System.Windows.Forms.Button muutatekstiBt;
        private System.Windows.Forms.Button PeruutaC;
        private System.Windows.Forms.TextBox TB;
        private System.Windows.Forms.Label ViestiLB;
    }
}

