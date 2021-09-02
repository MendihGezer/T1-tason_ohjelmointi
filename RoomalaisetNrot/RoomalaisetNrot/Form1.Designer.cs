namespace RoomalaisetNrot
{
    partial class Lomake
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
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.NumeroLB = new System.Windows.Forms.Label();
            this.RomTB = new System.Windows.Forms.TextBox();
            this.VastausLB = new System.Windows.Forms.Label();
            this.MuutaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.BackColor = System.Drawing.Color.White;
            this.OtsikkoLB.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtsikkoLB.Location = new System.Drawing.Point(21, 20);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(731, 63);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Roomalaiset numerot";
            // 
            // NumeroLB
            // 
            this.NumeroLB.AutoSize = true;
            this.NumeroLB.BackColor = System.Drawing.Color.White;
            this.NumeroLB.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumeroLB.Location = new System.Drawing.Point(12, 126);
            this.NumeroLB.Name = "NumeroLB";
            this.NumeroLB.Size = new System.Drawing.Size(675, 36);
            this.NumeroLB.TabIndex = 1;
            this.NumeroLB.Text = "Anna numero välillä, 1-3999, niin muutan sen roomalaiseksi:";
            // 
            // RomTB
            // 
            this.RomTB.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RomTB.Location = new System.Drawing.Point(693, 123);
            this.RomTB.Name = "RomTB";
            this.RomTB.Size = new System.Drawing.Size(100, 45);
            this.RomTB.TabIndex = 2;
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.BackColor = System.Drawing.Color.White;
            this.VastausLB.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausLB.Location = new System.Drawing.Point(12, 216);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(97, 33);
            this.VastausLB.TabIndex = 3;
            this.VastausLB.Text = "Vastaus";
            this.VastausLB.Visible = false;
            // 
            // MuutaBT
            // 
            this.MuutaBT.BackColor = System.Drawing.Color.White;
            this.MuutaBT.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MuutaBT.Location = new System.Drawing.Point(577, 204);
            this.MuutaBT.Name = "MuutaBT";
            this.MuutaBT.Size = new System.Drawing.Size(110, 45);
            this.MuutaBT.TabIndex = 4;
            this.MuutaBT.Text = "Muuta";
            this.MuutaBT.UseVisualStyleBackColor = false;
            // 
            // Lomake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RoomalaisetNrot.Properties.Resources.romannumerals_jpg;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MuutaBT);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.RomTB);
            this.Controls.Add(this.NumeroLB);
            this.Controls.Add(this.OtsikkoLB);
            this.Name = "Lomake";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OtsikkoLB;
        private System.Windows.Forms.Label NumeroLB;
        private System.Windows.Forms.TextBox RomTB;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.Button MuutaBT;
    }
}

