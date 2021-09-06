namespace SuosituimmatNimet
{
    partial class NimiLomake
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
            this.NimiLB = new System.Windows.Forms.Label();
            this.NimesiTB = new System.Windows.Forms.TextBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.TarkastaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NimiLB
            // 
            this.NimiLB.AutoSize = true;
            this.NimiLB.Location = new System.Drawing.Point(12, 29);
            this.NimiLB.Name = "NimiLB";
            this.NimiLB.Size = new System.Drawing.Size(541, 24);
            this.NimiLB.TabIndex = 0;
            this.NimiLB.Text = "Anna nimesi, niin tarkastan, onko se 50 suosituimman joukossa:";
            // 
            // NimesiTB
            // 
            this.NimesiTB.Location = new System.Drawing.Point(559, 26);
            this.NimesiTB.Name = "NimesiTB";
            this.NimesiTB.Size = new System.Drawing.Size(159, 32);
            this.NimesiTB.TabIndex = 1;
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Location = new System.Drawing.Point(12, 76);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(75, 24);
            this.VastausLB.TabIndex = 2;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // TarkastaBT
            // 
            this.TarkastaBT.BackColor = System.Drawing.Color.Snow;
            this.TarkastaBT.Location = new System.Drawing.Point(624, 77);
            this.TarkastaBT.Name = "TarkastaBT";
            this.TarkastaBT.Size = new System.Drawing.Size(94, 37);
            this.TarkastaBT.TabIndex = 3;
            this.TarkastaBT.Text = "Tarkasta";
            this.TarkastaBT.UseVisualStyleBackColor = false;
            this.TarkastaBT.Click += new System.EventHandler(this.TarkastaBT_Click);
            // 
            // NimiLomake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(738, 126);
            this.Controls.Add(this.TarkastaBT);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.NimesiTB);
            this.Controls.Add(this.NimiLB);
            this.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "NimiLomake";
            this.Text = "Onko nimesi suosituimpien joukossa?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NimiLB;
        private System.Windows.Forms.TextBox NimesiTB;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.Button TarkastaBT;
    }
}

