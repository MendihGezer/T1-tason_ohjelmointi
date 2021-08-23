namespace Ikalaskuri
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
            this.PaivaDTP = new System.Windows.Forms.DateTimePicker();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.IkaLB = new System.Windows.Forms.Label();
            this.KkLB = new System.Windows.Forms.Label();
            this.PaivaLB = new System.Windows.Forms.Label();
            this.TunnitLB = new System.Windows.Forms.Label();
            this.MinLB = new System.Windows.Forms.Label();
            this.SsLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PaivaDTP
            // 
            this.PaivaDTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaivaDTP.Location = new System.Drawing.Point(27, 39);
            this.PaivaDTP.Name = "PaivaDTP";
            this.PaivaDTP.Size = new System.Drawing.Size(352, 31);
            this.PaivaDTP.TabIndex = 0;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LaskeBT.Location = new System.Drawing.Point(407, 34);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(93, 44);
            this.LaskeBT.TabIndex = 1;
            this.LaskeBT.Text = "Laske";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // IkaLB
            // 
            this.IkaLB.AutoSize = true;
            this.IkaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IkaLB.Location = new System.Drawing.Point(57, 108);
            this.IkaLB.Name = "IkaLB";
            this.IkaLB.Size = new System.Drawing.Size(40, 25);
            this.IkaLB.TabIndex = 2;
            this.IkaLB.Text = "Ikä";
            this.IkaLB.Visible = false;
            // 
            // KkLB
            // 
            this.KkLB.AutoSize = true;
            this.KkLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KkLB.Location = new System.Drawing.Point(57, 145);
            this.KkLB.Name = "KkLB";
            this.KkLB.Size = new System.Drawing.Size(101, 25);
            this.KkLB.TabIndex = 3;
            this.KkLB.Text = "Kuukausi";
            this.KkLB.Visible = false;
            // 
            // PaivaLB
            // 
            this.PaivaLB.AutoSize = true;
            this.PaivaLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaivaLB.Location = new System.Drawing.Point(57, 187);
            this.PaivaLB.Name = "PaivaLB";
            this.PaivaLB.Size = new System.Drawing.Size(72, 25);
            this.PaivaLB.TabIndex = 4;
            this.PaivaLB.Text = "Päivät";
            this.PaivaLB.Visible = false;
            // 
            // TunnitLB
            // 
            this.TunnitLB.AutoSize = true;
            this.TunnitLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TunnitLB.Location = new System.Drawing.Point(206, 108);
            this.TunnitLB.Name = "TunnitLB";
            this.TunnitLB.Size = new System.Drawing.Size(72, 25);
            this.TunnitLB.TabIndex = 5;
            this.TunnitLB.Text = "Tunnit";
            this.TunnitLB.Visible = false;
            // 
            // MinLB
            // 
            this.MinLB.AutoSize = true;
            this.MinLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinLB.Location = new System.Drawing.Point(206, 145);
            this.MinLB.Name = "MinLB";
            this.MinLB.Size = new System.Drawing.Size(88, 25);
            this.MinLB.TabIndex = 6;
            this.MinLB.Text = "Minuutit";
            this.MinLB.Visible = false;
            // 
            // SsLB
            // 
            this.SsLB.AutoSize = true;
            this.SsLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SsLB.Location = new System.Drawing.Point(206, 187);
            this.SsLB.Name = "SsLB";
            this.SsLB.Size = new System.Drawing.Size(96, 25);
            this.SsLB.TabIndex = 7;
            this.SsLB.Text = "Sekunnit";
            this.SsLB.Visible = false;
            // 
            // Lomake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SsLB);
            this.Controls.Add(this.MinLB);
            this.Controls.Add(this.TunnitLB);
            this.Controls.Add(this.PaivaLB);
            this.Controls.Add(this.KkLB);
            this.Controls.Add(this.IkaLB);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.PaivaDTP);
            this.Name = "Lomake";
            this.Text = "Ikälaskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker PaivaDTP;
        private System.Windows.Forms.Button LaskeBT;
        private System.Windows.Forms.Label IkaLB;
        private System.Windows.Forms.Label KkLB;
        private System.Windows.Forms.Label PaivaLB;
        private System.Windows.Forms.Label TunnitLB;
        private System.Windows.Forms.Label MinLB;
        private System.Windows.Forms.Label SsLB;
    }
}

