namespace Ajastin
{
    partial class TimerForm
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
            this.MinuutitLB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StartBT = new System.Windows.Forms.Button();
            this.StopBT = new System.Windows.Forms.Button();
            this.AikaLB = new System.Windows.Forms.Label();
            this.MinCB = new System.Windows.Forms.ComboBox();
            this.SecCB = new System.Windows.Forms.ComboBox();
            this.TimerTM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // MinuutitLB
            // 
            this.MinuutitLB.AutoSize = true;
            this.MinuutitLB.Location = new System.Drawing.Point(20, 9);
            this.MinuutitLB.Name = "MinuutitLB";
            this.MinuutitLB.Size = new System.Drawing.Size(96, 25);
            this.MinuutitLB.TabIndex = 0;
            this.MinuutitLB.Text = "Minuutit:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sekunnit:";
            // 
            // StartBT
            // 
            this.StartBT.BackColor = System.Drawing.Color.Snow;
            this.StartBT.Location = new System.Drawing.Point(19, 182);
            this.StartBT.Name = "StartBT";
            this.StartBT.Size = new System.Drawing.Size(104, 58);
            this.StartBT.TabIndex = 2;
            this.StartBT.Text = "Start";
            this.StartBT.UseVisualStyleBackColor = false;
            this.StartBT.Click += new System.EventHandler(this.StartBT_Click);
            // 
            // StopBT
            // 
            this.StopBT.BackColor = System.Drawing.Color.Snow;
            this.StopBT.Location = new System.Drawing.Point(156, 182);
            this.StopBT.Name = "StopBT";
            this.StopBT.Size = new System.Drawing.Size(104, 58);
            this.StopBT.TabIndex = 3;
            this.StopBT.Text = "Stop";
            this.StopBT.UseVisualStyleBackColor = false;
            this.StopBT.Click += new System.EventHandler(this.StopBT_Click);
            // 
            // AikaLB
            // 
            this.AikaLB.AutoSize = true;
            this.AikaLB.BackColor = System.Drawing.Color.MistyRose;
            this.AikaLB.Font = new System.Drawing.Font("Microsoft YaHei", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AikaLB.Location = new System.Drawing.Point(34, 83);
            this.AikaLB.Name = "AikaLB";
            this.AikaLB.Size = new System.Drawing.Size(202, 83);
            this.AikaLB.TabIndex = 4;
            this.AikaLB.Text = "00:00";
            // 
            // MinCB
            // 
            this.MinCB.BackColor = System.Drawing.Color.Snow;
            this.MinCB.FormattingEnabled = true;
            this.MinCB.Location = new System.Drawing.Point(19, 37);
            this.MinCB.Name = "MinCB";
            this.MinCB.Size = new System.Drawing.Size(101, 33);
            this.MinCB.TabIndex = 5;
            // 
            // SecCB
            // 
            this.SecCB.BackColor = System.Drawing.Color.Snow;
            this.SecCB.FormattingEnabled = true;
            this.SecCB.Location = new System.Drawing.Point(144, 37);
            this.SecCB.Name = "SecCB";
            this.SecCB.Size = new System.Drawing.Size(101, 33);
            this.SecCB.TabIndex = 6;
            // 
            // TimerTM
            // 
            this.TimerTM.Interval = 1000;
            this.TimerTM.Tick += new System.EventHandler(this.TimerTM_Tick);
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(270, 257);
            this.Controls.Add(this.SecCB);
            this.Controls.Add(this.MinCB);
            this.Controls.Add(this.AikaLB);
            this.Controls.Add(this.StopBT);
            this.Controls.Add(this.StartBT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MinuutitLB);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TimerForm";
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.TimerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MinuutitLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button StartBT;
        private System.Windows.Forms.Button StopBT;
        private System.Windows.Forms.Label AikaLB;
        private System.Windows.Forms.ComboBox MinCB;
        private System.Windows.Forms.ComboBox SecCB;
        private System.Windows.Forms.Timer TimerTM;
    }
}

