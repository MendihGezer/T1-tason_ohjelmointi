namespace Oppilaitosten_avainhenkilot
{
    partial class OppilaitosForm
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
            this.AvainhenkilotLB = new System.Windows.Forms.Label();
            this.OppilaitosLB = new System.Windows.Forms.Label();
            this.VastuuhenkiloLB = new System.Windows.Forms.Label();
            this.OppilaitosCB = new System.Windows.Forms.ComboBox();
            this.VastuuhenkiloCB = new System.Windows.Forms.ComboBox();
            this.OsoiteLB = new System.Windows.Forms.Label();
            this.PostinumeroLB = new System.Windows.Forms.Label();
            this.PostitoimipaikkaLB = new System.Windows.Forms.Label();
            this.Puhnum1LB = new System.Windows.Forms.Label();
            this.NimikeLB = new System.Windows.Forms.Label();
            this.OsastoLB = new System.Windows.Forms.Label();
            this.SpostiLB = new System.Windows.Forms.Label();
            this.Puhnum2LB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AvainhenkilotLB
            // 
            this.AvainhenkilotLB.AutoSize = true;
            this.AvainhenkilotLB.Font = new System.Drawing.Font("Microsoft YaHei", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvainhenkilotLB.Location = new System.Drawing.Point(12, 19);
            this.AvainhenkilotLB.Name = "AvainhenkilotLB";
            this.AvainhenkilotLB.Size = new System.Drawing.Size(664, 62);
            this.AvainhenkilotLB.TabIndex = 0;
            this.AvainhenkilotLB.Text = "Oppilaitosten avainhenkilöt";
            // 
            // OppilaitosLB
            // 
            this.OppilaitosLB.AutoSize = true;
            this.OppilaitosLB.Location = new System.Drawing.Point(21, 99);
            this.OppilaitosLB.Name = "OppilaitosLB";
            this.OppilaitosLB.Size = new System.Drawing.Size(174, 25);
            this.OppilaitosLB.TabIndex = 1;
            this.OppilaitosLB.Text = "Valitse oppilaitos:";
            // 
            // VastuuhenkiloLB
            // 
            this.VastuuhenkiloLB.AutoSize = true;
            this.VastuuhenkiloLB.Location = new System.Drawing.Point(382, 99);
            this.VastuuhenkiloLB.Name = "VastuuhenkiloLB";
            this.VastuuhenkiloLB.Size = new System.Drawing.Size(212, 25);
            this.VastuuhenkiloLB.TabIndex = 2;
            this.VastuuhenkiloLB.Text = "Valitse vastuuhenkilö:";
            // 
            // OppilaitosCB
            // 
            this.OppilaitosCB.FormattingEnabled = true;
            this.OppilaitosCB.Location = new System.Drawing.Point(21, 147);
            this.OppilaitosCB.Name = "OppilaitosCB";
            this.OppilaitosCB.Size = new System.Drawing.Size(174, 33);
            this.OppilaitosCB.TabIndex = 3;
            this.OppilaitosCB.SelectedIndexChanged += new System.EventHandler(this.OppilaitosCB_SelectedIndexChanged);
            // 
            // VastuuhenkiloCB
            // 
            this.VastuuhenkiloCB.FormattingEnabled = true;
            this.VastuuhenkiloCB.Location = new System.Drawing.Point(382, 147);
            this.VastuuhenkiloCB.Name = "VastuuhenkiloCB";
            this.VastuuhenkiloCB.Size = new System.Drawing.Size(273, 33);
            this.VastuuhenkiloCB.TabIndex = 4;
            this.VastuuhenkiloCB.TextChanged += new System.EventHandler(this.VastuuhenkiloCB_TextChanged);
            // 
            // OsoiteLB
            // 
            this.OsoiteLB.AutoSize = true;
            this.OsoiteLB.Location = new System.Drawing.Point(21, 203);
            this.OsoiteLB.Name = "OsoiteLB";
            this.OsoiteLB.Size = new System.Drawing.Size(71, 25);
            this.OsoiteLB.TabIndex = 5;
            this.OsoiteLB.Text = "Osoite";
            // 
            // PostinumeroLB
            // 
            this.PostinumeroLB.AutoSize = true;
            this.PostinumeroLB.Location = new System.Drawing.Point(21, 251);
            this.PostinumeroLB.Name = "PostinumeroLB";
            this.PostinumeroLB.Size = new System.Drawing.Size(129, 25);
            this.PostinumeroLB.TabIndex = 6;
            this.PostinumeroLB.Text = "Postinumero";
            // 
            // PostitoimipaikkaLB
            // 
            this.PostitoimipaikkaLB.AutoSize = true;
            this.PostitoimipaikkaLB.Location = new System.Drawing.Point(21, 299);
            this.PostitoimipaikkaLB.Name = "PostitoimipaikkaLB";
            this.PostitoimipaikkaLB.Size = new System.Drawing.Size(163, 25);
            this.PostitoimipaikkaLB.TabIndex = 7;
            this.PostitoimipaikkaLB.Text = "Postitoimipaikka";
            // 
            // Puhnum1LB
            // 
            this.Puhnum1LB.AutoSize = true;
            this.Puhnum1LB.Location = new System.Drawing.Point(21, 347);
            this.Puhnum1LB.Name = "Puhnum1LB";
            this.Puhnum1LB.Size = new System.Drawing.Size(153, 25);
            this.Puhnum1LB.TabIndex = 8;
            this.Puhnum1LB.Text = "Puhelinnumero";
            // 
            // NimikeLB
            // 
            this.NimikeLB.AutoSize = true;
            this.NimikeLB.Location = new System.Drawing.Point(382, 203);
            this.NimikeLB.Name = "NimikeLB";
            this.NimikeLB.Size = new System.Drawing.Size(76, 25);
            this.NimikeLB.TabIndex = 9;
            this.NimikeLB.Text = "Nimike";
            // 
            // OsastoLB
            // 
            this.OsastoLB.AutoSize = true;
            this.OsastoLB.Location = new System.Drawing.Point(382, 251);
            this.OsastoLB.Name = "OsastoLB";
            this.OsastoLB.Size = new System.Drawing.Size(75, 25);
            this.OsastoLB.TabIndex = 10;
            this.OsastoLB.Text = "Osasto";
            // 
            // SpostiLB
            // 
            this.SpostiLB.AutoSize = true;
            this.SpostiLB.Location = new System.Drawing.Point(382, 299);
            this.SpostiLB.Name = "SpostiLB";
            this.SpostiLB.Size = new System.Drawing.Size(113, 25);
            this.SpostiLB.TabIndex = 11;
            this.SpostiLB.Text = "Sähköposti";
            // 
            // Puhnum2LB
            // 
            this.Puhnum2LB.AutoSize = true;
            this.Puhnum2LB.Location = new System.Drawing.Point(382, 347);
            this.Puhnum2LB.Name = "Puhnum2LB";
            this.Puhnum2LB.Size = new System.Drawing.Size(153, 25);
            this.Puhnum2LB.TabIndex = 12;
            this.Puhnum2LB.Text = "Puhelinnumero";
            // 
            // OppilaitosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(681, 399);
            this.Controls.Add(this.Puhnum2LB);
            this.Controls.Add(this.SpostiLB);
            this.Controls.Add(this.OsastoLB);
            this.Controls.Add(this.NimikeLB);
            this.Controls.Add(this.Puhnum1LB);
            this.Controls.Add(this.PostitoimipaikkaLB);
            this.Controls.Add(this.PostinumeroLB);
            this.Controls.Add(this.OsoiteLB);
            this.Controls.Add(this.VastuuhenkiloCB);
            this.Controls.Add(this.OppilaitosCB);
            this.Controls.Add(this.VastuuhenkiloLB);
            this.Controls.Add(this.OppilaitosLB);
            this.Controls.Add(this.AvainhenkilotLB);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "OppilaitosForm";
            this.Text = "Oppilaitosten avainhenkilöt";
            this.Load += new System.EventHandler(this.OppilaitosForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AvainhenkilotLB;
        private System.Windows.Forms.Label OppilaitosLB;
        private System.Windows.Forms.Label VastuuhenkiloLB;
        private System.Windows.Forms.ComboBox OppilaitosCB;
        private System.Windows.Forms.ComboBox VastuuhenkiloCB;
        private System.Windows.Forms.Label OsoiteLB;
        private System.Windows.Forms.Label PostinumeroLB;
        private System.Windows.Forms.Label PostitoimipaikkaLB;
        private System.Windows.Forms.Label Puhnum1LB;
        private System.Windows.Forms.Label NimikeLB;
        private System.Windows.Forms.Label OsastoLB;
        private System.Windows.Forms.Label SpostiLB;
        private System.Windows.Forms.Label Puhnum2LB;
    }
}

