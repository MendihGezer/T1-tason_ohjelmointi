namespace Paivakirja
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
            this.SyotaTB = new System.Windows.Forms.TextBox();
            this.TallennaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SyotaTB
            // 
            this.SyotaTB.Location = new System.Drawing.Point(13, 13);
            this.SyotaTB.Multiline = true;
            this.SyotaTB.Name = "SyotaTB";
            this.SyotaTB.Size = new System.Drawing.Size(575, 312);
            this.SyotaTB.TabIndex = 0;
            // 
            // TallennaBT
            // 
            this.TallennaBT.BackColor = System.Drawing.Color.Cornsilk;
            this.TallennaBT.Location = new System.Drawing.Point(13, 332);
            this.TallennaBT.Name = "TallennaBT";
            this.TallennaBT.Size = new System.Drawing.Size(575, 74);
            this.TallennaBT.TabIndex = 1;
            this.TallennaBT.Text = "Tallenna päivääsi";
            this.TallennaBT.UseVisualStyleBackColor = false;
            this.TallennaBT.Click += new System.EventHandler(this.TallennaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(600, 418);
            this.Controls.Add(this.TallennaBT);
            this.Controls.Add(this.SyotaTB);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Päiväkirja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SyotaTB;
        private System.Windows.Forms.Button TallennaBT;
    }
}

