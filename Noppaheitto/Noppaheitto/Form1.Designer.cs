namespace Noppaheitto
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
            this.NoppaLB = new System.Windows.Forms.Label();
            this.noppa01PB = new System.Windows.Forms.PictureBox();
            this.noppa02PB = new System.Windows.Forms.PictureBox();
            this.HeitaBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.noppa01PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa02PB)).BeginInit();
            this.SuspendLayout();
            // 
            // NoppaLB
            // 
            this.NoppaLB.AutoSize = true;
            this.NoppaLB.Font = new System.Drawing.Font("Lucida Calligraphy", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoppaLB.Location = new System.Drawing.Point(12, 18);
            this.NoppaLB.Name = "NoppaLB";
            this.NoppaLB.Size = new System.Drawing.Size(266, 45);
            this.NoppaLB.TabIndex = 0;
            this.NoppaLB.Text = "Nopan heitto";
            this.NoppaLB.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // noppa01PB
            // 
            this.noppa01PB.Image = global::Noppaheitto.Properties.Resources.Noppa6;
            this.noppa01PB.Location = new System.Drawing.Point(20, 66);
            this.noppa01PB.Name = "noppa01PB";
            this.noppa01PB.Size = new System.Drawing.Size(113, 113);
            this.noppa01PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noppa01PB.TabIndex = 1;
            this.noppa01PB.TabStop = false;
            // 
            // noppa02PB
            // 
            this.noppa02PB.Image = global::Noppaheitto.Properties.Resources.Noppa1;
            this.noppa02PB.Location = new System.Drawing.Point(165, 66);
            this.noppa02PB.Name = "noppa02PB";
            this.noppa02PB.Size = new System.Drawing.Size(113, 113);
            this.noppa02PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.noppa02PB.TabIndex = 2;
            this.noppa02PB.TabStop = false;
            // 
            // HeitaBT
            // 
            this.HeitaBT.BackColor = System.Drawing.Color.Snow;
            this.HeitaBT.Font = new System.Drawing.Font("Lucida Calligraphy", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeitaBT.Location = new System.Drawing.Point(20, 196);
            this.HeitaBT.Name = "HeitaBT";
            this.HeitaBT.Size = new System.Drawing.Size(258, 54);
            this.HeitaBT.TabIndex = 3;
            this.HeitaBT.Text = "Heitä";
            this.HeitaBT.UseVisualStyleBackColor = false;
            this.HeitaBT.Click += new System.EventHandler(this.HeitaBT_Click);
            // 
            // Lomake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(303, 270);
            this.Controls.Add(this.HeitaBT);
            this.Controls.Add(this.noppa02PB);
            this.Controls.Add(this.noppa01PB);
            this.Controls.Add(this.NoppaLB);
            this.Name = "Lomake";
            this.Text = "Heitä noppaa";
            ((System.ComponentModel.ISupportInitialize)(this.noppa01PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.noppa02PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NoppaLB;
        private System.Windows.Forms.PictureBox noppa01PB;
        private System.Windows.Forms.PictureBox noppa02PB;
        private System.Windows.Forms.Button HeitaBT;
    }
}

