namespace _10_Kysymysta
{
    partial class LomakeForm
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
            this.KysymysLB = new System.Windows.Forms.Label();
            this.VastausGB = new System.Windows.Forms.GroupBox();
            this.ARB = new System.Windows.Forms.RadioButton();
            this.BRB = new System.Windows.Forms.RadioButton();
            this.CRB = new System.Windows.Forms.RadioButton();
            this.DRB = new System.Windows.Forms.RadioButton();
            this.VastausLB = new System.Windows.Forms.Label();
            this.VastausGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // KysymysLB
            // 
            this.KysymysLB.AutoSize = true;
            this.KysymysLB.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KysymysLB.Location = new System.Drawing.Point(12, 18);
            this.KysymysLB.Name = "KysymysLB";
            this.KysymysLB.Size = new System.Drawing.Size(252, 28);
            this.KysymysLB.TabIndex = 0;
            this.KysymysLB.Text = "Vastaus 1. kysymykseen";
            // 
            // VastausGB
            // 
            this.VastausGB.Controls.Add(this.DRB);
            this.VastausGB.Controls.Add(this.CRB);
            this.VastausGB.Controls.Add(this.BRB);
            this.VastausGB.Controls.Add(this.ARB);
            this.VastausGB.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausGB.Location = new System.Drawing.Point(280, 18);
            this.VastausGB.Name = "VastausGB";
            this.VastausGB.Size = new System.Drawing.Size(105, 159);
            this.VastausGB.TabIndex = 1;
            this.VastausGB.TabStop = false;
            this.VastausGB.Text = "Vastaus";
            // 
            // ARB
            // 
            this.ARB.AutoSize = true;
            this.ARB.Location = new System.Drawing.Point(7, 33);
            this.ARB.Name = "ARB";
            this.ARB.Size = new System.Drawing.Size(45, 32);
            this.ARB.TabIndex = 0;
            this.ARB.TabStop = true;
            this.ARB.Text = "A";
            this.ARB.UseVisualStyleBackColor = true;
            // 
            // BRB
            // 
            this.BRB.AutoSize = true;
            this.BRB.Location = new System.Drawing.Point(7, 62);
            this.BRB.Name = "BRB";
            this.BRB.Size = new System.Drawing.Size(43, 32);
            this.BRB.TabIndex = 1;
            this.BRB.TabStop = true;
            this.BRB.Text = "B";
            this.BRB.UseVisualStyleBackColor = true;
            // 
            // CRB
            // 
            this.CRB.AutoSize = true;
            this.CRB.Location = new System.Drawing.Point(7, 91);
            this.CRB.Name = "CRB";
            this.CRB.Size = new System.Drawing.Size(44, 32);
            this.CRB.TabIndex = 2;
            this.CRB.TabStop = true;
            this.CRB.Text = "C";
            this.CRB.UseVisualStyleBackColor = true;
            // 
            // DRB
            // 
            this.DRB.AutoSize = true;
            this.DRB.Location = new System.Drawing.Point(7, 120);
            this.DRB.Name = "DRB";
            this.DRB.Size = new System.Drawing.Size(46, 32);
            this.DRB.TabIndex = 3;
            this.DRB.TabStop = true;
            this.DRB.Text = "D";
            this.DRB.UseVisualStyleBackColor = true;
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausLB.Location = new System.Drawing.Point(12, 149);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(91, 28);
            this.VastausLB.TabIndex = 2;
            this.VastausLB.Text = "Vastaus";
            // 
            // LomakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(418, 201);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.VastausGB);
            this.Controls.Add(this.KysymysLB);
            this.Name = "LomakeForm";
            this.Text = "Vastauslomake";
            this.Load += new System.EventHandler(this.LomakeForm_Load);
            this.VastausGB.ResumeLayout(false);
            this.VastausGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label KysymysLB;
        private System.Windows.Forms.GroupBox VastausGB;
        private System.Windows.Forms.RadioButton DRB;
        private System.Windows.Forms.RadioButton CRB;
        private System.Windows.Forms.RadioButton BRB;
        private System.Windows.Forms.RadioButton ARB;
        private System.Windows.Forms.Label VastausLB;
    }
}

