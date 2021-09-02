namespace BMI_laskuri
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pituusTB = new System.Windows.Forms.TextBox();
            this.painoTB = new System.Windows.Forms.TextBox();
            this.BMIBT = new System.Windows.Forms.Button();
            this.VastausLB = new System.Windows.Forms.Label();
            this.KuvausLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Anna pituus:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anna paino:";
            // 
            // pituusTB
            // 
            this.pituusTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pituusTB.Location = new System.Drawing.Point(133, 21);
            this.pituusTB.Name = "pituusTB";
            this.pituusTB.Size = new System.Drawing.Size(100, 29);
            this.pituusTB.TabIndex = 2;
            // 
            // painoTB
            // 
            this.painoTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painoTB.Location = new System.Drawing.Point(133, 57);
            this.painoTB.Name = "painoTB";
            this.painoTB.Size = new System.Drawing.Size(100, 29);
            this.painoTB.TabIndex = 3;
            // 
            // BMIBT
            // 
            this.BMIBT.BackColor = System.Drawing.Color.White;
            this.BMIBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIBT.Location = new System.Drawing.Point(93, 103);
            this.BMIBT.Name = "BMIBT";
            this.BMIBT.Size = new System.Drawing.Size(89, 41);
            this.BMIBT.TabIndex = 4;
            this.BMIBT.Text = "Laske";
            this.BMIBT.UseVisualStyleBackColor = false;
            this.BMIBT.Click += new System.EventHandler(this.BMIBT_Click);
            // 
            // VastausLB
            // 
            this.VastausLB.AutoSize = true;
            this.VastausLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VastausLB.Location = new System.Drawing.Point(16, 158);
            this.VastausLB.Name = "VastausLB";
            this.VastausLB.Size = new System.Drawing.Size(0, 24);
            this.VastausLB.TabIndex = 5;
            // 
            // KuvausLB
            // 
            this.KuvausLB.AutoSize = true;
            this.KuvausLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KuvausLB.Location = new System.Drawing.Point(16, 202);
            this.KuvausLB.Name = "KuvausLB";
            this.KuvausLB.Size = new System.Drawing.Size(72, 24);
            this.KuvausLB.TabIndex = 6;
            this.KuvausLB.Text = "Kuvaus";
            // 
            // Lomake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(264, 243);
            this.Controls.Add(this.KuvausLB);
            this.Controls.Add(this.VastausLB);
            this.Controls.Add(this.BMIBT);
            this.Controls.Add(this.painoTB);
            this.Controls.Add(this.pituusTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lomake";
            this.Text = "BMI-laskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pituusTB;
        private System.Windows.Forms.TextBox painoTB;
        private System.Windows.Forms.Button BMIBT;
        private System.Windows.Forms.Label VastausLB;
        private System.Windows.Forms.Label KuvausLB;
    }
}

