namespace Sekuntikello
{
    partial class KelloForm
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
            this.components = new System.ComponentModel.Container();
            this.TimeLB = new System.Windows.Forms.Label();
            this.StartBT = new System.Windows.Forms.Button();
            this.ResetBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.TimerTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // TimeLB
            // 
            this.TimeLB.AutoSize = true;
            this.TimeLB.Font = new System.Drawing.Font("Microsoft YaHei", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLB.Location = new System.Drawing.Point(15, 9);
            this.TimeLB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TimeLB.Name = "TimeLB";
            this.TimeLB.Size = new System.Drawing.Size(625, 124);
            this.TimeLB.TabIndex = 0;
            this.TimeLB.Text = "00:00:00.000";
           // 
            // StartBT
            // 
            this.StartBT.BackColor = System.Drawing.Color.Snow;
            this.StartBT.Location = new System.Drawing.Point(36, 137);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(104, 50);
            this.StartBT.TabIndex = 1;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = false;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // ResetBT
            // 
            this.ResetBT.BackColor = System.Drawing.Color.Snow;
            this.ResetBT.Location = new System.Drawing.Point(502, 137);
            this.ResetBT.Name = "ResetBT";
            this.ResetBT.Size = new System.Drawing.Size(104, 50);
            this.ResetBT.TabIndex = 2;
            this.ResetBT.Text = "Reset";
            this.ResetBT.UseVisualStyleBackColor = false;
            this.ResetBT.Click += new System.EventHandler(this.ResetBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.BackColor = System.Drawing.Color.Snow;
            this.StopBT.Location = new System.Drawing.Point(269, 137);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(104, 50);
            this.StopBT.TabIndex = 3;
            this.StopBT.Text = "Stop";
            this.StopBT.UseVisualStyleBackColor = false;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // TimerTM
            // 
            this.TimerTM.Enabled = true;
            this.TimerTM.Tick += new System.EventHandler(this.TimerTM_Tick);
            // 
            // KelloForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(668, 208);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.ResetBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.TimeLB);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "KelloForm";
            this.Text = "Sekuntikello";
            this.Load += new System.EventHandler(this.KelloForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeLB;
        private System.Windows.Forms.Button StartBT;
        private System.Windows.Forms.Button ResetBT;
        private System.Windows.Forms.Button StopBT;
        private System.Windows.Forms.Timer TimerTM;
    }
}

