namespace SalasananTarkistus
{
    partial class SalasanaForm
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
            this.SalasanaPanel = new System.Windows.Forms.Panel();
            this.KayttajaLB = new System.Windows.Forms.Label();
            this.SalasanaLB = new System.Windows.Forms.Label();
            this.KayttajaTB = new System.Windows.Forms.TextBox();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.TarkistaBT = new System.Windows.Forms.Button();
            this.VirheViestiLB = new System.Windows.Forms.TextBox();
            this.SalasanaOikeinPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SalasanaPanel.SuspendLayout();
            this.SalasanaOikeinPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalasanaPanel
            // 
            this.SalasanaPanel.BackColor = System.Drawing.Color.MidnightBlue;
            this.SalasanaPanel.Controls.Add(this.SalasanaOikeinPanel);
            this.SalasanaPanel.Controls.Add(this.VirheViestiLB);
            this.SalasanaPanel.Controls.Add(this.TarkistaBT);
            this.SalasanaPanel.Controls.Add(this.SalasanaTB);
            this.SalasanaPanel.Controls.Add(this.KayttajaTB);
            this.SalasanaPanel.Controls.Add(this.SalasanaLB);
            this.SalasanaPanel.Controls.Add(this.KayttajaLB);
            this.SalasanaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaPanel.Font = new System.Drawing.Font("Myriad Hebrew", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaPanel.ForeColor = System.Drawing.Color.Gold;
            this.SalasanaPanel.Location = new System.Drawing.Point(0, 0);
            this.SalasanaPanel.Name = "SalasanaPanel";
            this.SalasanaPanel.Size = new System.Drawing.Size(748, 182);
            this.SalasanaPanel.TabIndex = 0;
            this.SalasanaPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SalasanaPanel_Paint);
            // 
            // KayttajaLB
            // 
            this.KayttajaLB.AutoSize = true;
            this.KayttajaLB.Font = new System.Drawing.Font("Myriad Hebrew", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayttajaLB.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KayttajaLB.Location = new System.Drawing.Point(12, 18);
            this.KayttajaLB.Name = "KayttajaLB";
            this.KayttajaLB.Size = new System.Drawing.Size(172, 29);
            this.KayttajaLB.TabIndex = 0;
            this.KayttajaLB.Text = "Käyttäjätunnus:";
            this.KayttajaLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SalasanaLB
            // 
            this.SalasanaLB.AutoSize = true;
            this.SalasanaLB.Font = new System.Drawing.Font("Myriad Hebrew", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaLB.Location = new System.Drawing.Point(75, 66);
            this.SalasanaLB.Name = "SalasanaLB";
            this.SalasanaLB.Size = new System.Drawing.Size(109, 29);
            this.SalasanaLB.TabIndex = 1;
            this.SalasanaLB.Text = "Salasana:";
            this.SalasanaLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // KayttajaTB
            // 
            this.KayttajaTB.Font = new System.Drawing.Font("Myriad Hebrew", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KayttajaTB.Location = new System.Drawing.Point(190, 18);
            this.KayttajaTB.Name = "KayttajaTB";
            this.KayttajaTB.Size = new System.Drawing.Size(440, 36);
            this.KayttajaTB.TabIndex = 2;
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Font = new System.Drawing.Font("Myriad Hebrew", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaTB.Location = new System.Drawing.Point(190, 63);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(440, 36);
            this.SalasanaTB.TabIndex = 3;
            // 
            // TarkistaBT
            // 
            this.TarkistaBT.BackColor = System.Drawing.SystemColors.Window;
            this.TarkistaBT.Font = new System.Drawing.Font("Myriad Hebrew", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TarkistaBT.ForeColor = System.Drawing.Color.Black;
            this.TarkistaBT.Location = new System.Drawing.Point(45, 118);
            this.TarkistaBT.Name = "TarkistaBT";
            this.TarkistaBT.Size = new System.Drawing.Size(139, 50);
            this.TarkistaBT.TabIndex = 4;
            this.TarkistaBT.Text = "Tarkista";
            this.TarkistaBT.UseVisualStyleBackColor = false;
            this.TarkistaBT.Click += new System.EventHandler(this.TarkistaBT_Click);
            // 
            // VirheViestiLB
            // 
            this.VirheViestiLB.BackColor = System.Drawing.Color.MidnightBlue;
            this.VirheViestiLB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VirheViestiLB.Font = new System.Drawing.Font("Myriad Hebrew", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VirheViestiLB.ForeColor = System.Drawing.Color.Gold;
            this.VirheViestiLB.Location = new System.Drawing.Point(200, 129);
            this.VirheViestiLB.Name = "VirheViestiLB";
            this.VirheViestiLB.Size = new System.Drawing.Size(498, 29);
            this.VirheViestiLB.TabIndex = 5;
            this.VirheViestiLB.Text = "Virhe";
            this.VirheViestiLB.Visible = false;
            // 
            // SalasanaOikeinPanel
            // 
            this.SalasanaOikeinPanel.BackColor = System.Drawing.Color.DarkRed;
            this.SalasanaOikeinPanel.Controls.Add(this.label1);
            this.SalasanaOikeinPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaOikeinPanel.Font = new System.Drawing.Font("Segoe Script", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalasanaOikeinPanel.ForeColor = System.Drawing.Color.Snow;
            this.SalasanaOikeinPanel.Location = new System.Drawing.Point(0, 0);
            this.SalasanaOikeinPanel.Name = "SalasanaOikeinPanel";
            this.SalasanaOikeinPanel.Size = new System.Drawing.Size(748, 182);
            this.SalasanaOikeinPanel.TabIndex = 1;
            this.SalasanaOikeinPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(590, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tervetuloa sivuilleni!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SalasanaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(748, 182);
            this.Controls.Add(this.SalasanaPanel);
            this.Name = "SalasanaForm";
            this.Text = "Salasanan Tarkistus";
            this.SalasanaPanel.ResumeLayout(false);
            this.SalasanaPanel.PerformLayout();
            this.SalasanaOikeinPanel.ResumeLayout(false);
            this.SalasanaOikeinPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SalasanaPanel;
        private System.Windows.Forms.TextBox VirheViestiLB;
        private System.Windows.Forms.Button TarkistaBT;
        private System.Windows.Forms.TextBox SalasanaTB;
        private System.Windows.Forms.TextBox KayttajaTB;
        private System.Windows.Forms.Label SalasanaLB;
        private System.Windows.Forms.Label KayttajaLB;
        private System.Windows.Forms.Panel SalasanaOikeinPanel;
        private System.Windows.Forms.Label label1;
    }
}

