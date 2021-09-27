namespace Oppilashallintajarjestelma
{
    partial class opiskelijarekisteriForm
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
            this.TietotauluDG = new System.Windows.Forms.DataGridView();
            this.oidLB = new System.Windows.Forms.Label();
            this.enimiLB = new System.Windows.Forms.Label();
            this.snimiLB = new System.Windows.Forms.Label();
            this.puhLB = new System.Windows.Forms.Label();
            this.spostiLB = new System.Windows.Forms.Label();
            this.onroLB = new System.Windows.Forms.Label();
            this.OidTB = new System.Windows.Forms.TextBox();
            this.EnimiTB = new System.Windows.Forms.TextBox();
            this.SnimiTB = new System.Windows.Forms.TextBox();
            this.ONroTB = new System.Windows.Forms.TextBox();
            this.SpostiTB = new System.Windows.Forms.TextBox();
            this.PuhTB = new System.Windows.Forms.TextBox();
            this.tyhjennaBT = new System.Windows.Forms.Button();
            this.tallennaBT = new System.Windows.Forms.Button();
            this.paivitaBT = new System.Windows.Forms.Button();
            this.poistaBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).BeginInit();
            this.SuspendLayout();
            // 
            // TietotauluDG
            // 
            this.TietotauluDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TietotauluDG.Location = new System.Drawing.Point(15, 185);
            this.TietotauluDG.Margin = new System.Windows.Forms.Padding(6);
            this.TietotauluDG.Name = "TietotauluDG";
            this.TietotauluDG.Size = new System.Drawing.Size(1115, 379);
            this.TietotauluDG.TabIndex = 0;
            this.TietotauluDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TietotauluDG_CellClick);
            this.TietotauluDG.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TietotauluDG_CellContentClick);
            // 
            // oidLB
            // 
            this.oidLB.AutoSize = true;
            this.oidLB.Location = new System.Drawing.Point(10, 24);
            this.oidLB.Name = "oidLB";
            this.oidLB.Size = new System.Drawing.Size(37, 25);
            this.oidLB.TabIndex = 1;
            this.oidLB.Text = "ID:";
            // 
            // enimiLB
            // 
            this.enimiLB.AutoSize = true;
            this.enimiLB.Location = new System.Drawing.Point(10, 63);
            this.enimiLB.Name = "enimiLB";
            this.enimiLB.Size = new System.Drawing.Size(98, 25);
            this.enimiLB.TabIndex = 2;
            this.enimiLB.Text = "ETUNIMI:";
            // 
            // snimiLB
            // 
            this.snimiLB.AutoSize = true;
            this.snimiLB.Location = new System.Drawing.Point(10, 102);
            this.snimiLB.Name = "snimiLB";
            this.snimiLB.Size = new System.Drawing.Size(114, 25);
            this.snimiLB.TabIndex = 3;
            this.snimiLB.Text = "SUKUNIMI:";
            // 
            // puhLB
            // 
            this.puhLB.AutoSize = true;
            this.puhLB.Location = new System.Drawing.Point(335, 24);
            this.puhLB.Name = "puhLB";
            this.puhLB.Size = new System.Drawing.Size(99, 25);
            this.puhLB.TabIndex = 4;
            this.puhLB.Text = "PUHELIN:";
            // 
            // spostiLB
            // 
            this.spostiLB.AutoSize = true;
            this.spostiLB.Location = new System.Drawing.Point(335, 63);
            this.spostiLB.Name = "spostiLB";
            this.spostiLB.Size = new System.Drawing.Size(138, 25);
            this.spostiLB.TabIndex = 5;
            this.spostiLB.Text = "SÄHKÖPOSTI:";
            // 
            // onroLB
            // 
            this.onroLB.AutoSize = true;
            this.onroLB.Location = new System.Drawing.Point(335, 102);
            this.onroLB.Name = "onroLB";
            this.onroLB.Size = new System.Drawing.Size(162, 25);
            this.onroLB.TabIndex = 6;
            this.onroLB.Text = "OPISKELIJANRO:";
            // 
            // OidTB
            // 
            this.OidTB.Enabled = false;
            this.OidTB.Location = new System.Drawing.Point(125, 21);
            this.OidTB.Name = "OidTB";
            this.OidTB.Size = new System.Drawing.Size(195, 33);
            this.OidTB.TabIndex = 7;
            // 
            // EnimiTB
            // 
            this.EnimiTB.Location = new System.Drawing.Point(125, 60);
            this.EnimiTB.Name = "EnimiTB";
            this.EnimiTB.Size = new System.Drawing.Size(195, 33);
            this.EnimiTB.TabIndex = 8;
            // 
            // SnimiTB
            // 
            this.SnimiTB.Location = new System.Drawing.Point(125, 99);
            this.SnimiTB.Name = "SnimiTB";
            this.SnimiTB.Size = new System.Drawing.Size(195, 33);
            this.SnimiTB.TabIndex = 9;
            // 
            // ONroTB
            // 
            this.ONroTB.Location = new System.Drawing.Point(498, 102);
            this.ONroTB.Name = "ONroTB";
            this.ONroTB.Size = new System.Drawing.Size(266, 33);
            this.ONroTB.TabIndex = 12;
            // 
            // SpostiTB
            // 
            this.SpostiTB.Location = new System.Drawing.Point(498, 63);
            this.SpostiTB.Name = "SpostiTB";
            this.SpostiTB.Size = new System.Drawing.Size(266, 33);
            this.SpostiTB.TabIndex = 11;
            // 
            // PuhTB
            // 
            this.PuhTB.Location = new System.Drawing.Point(498, 24);
            this.PuhTB.Name = "PuhTB";
            this.PuhTB.Size = new System.Drawing.Size(266, 33);
            this.PuhTB.TabIndex = 10;
            // 
            // tyhjennaBT
            // 
            this.tyhjennaBT.Location = new System.Drawing.Point(15, 142);
            this.tyhjennaBT.Name = "tyhjennaBT";
            this.tyhjennaBT.Size = new System.Drawing.Size(159, 34);
            this.tyhjennaBT.TabIndex = 13;
            this.tyhjennaBT.Text = "TYHJENNÄ";
            this.tyhjennaBT.UseVisualStyleBackColor = true;
            this.tyhjennaBT.Click += new System.EventHandler(this.tyhjennaBT_Click);
            // 
            // tallennaBT
            // 
            this.tallennaBT.Location = new System.Drawing.Point(187, 142);
            this.tallennaBT.Name = "tallennaBT";
            this.tallennaBT.Size = new System.Drawing.Size(159, 34);
            this.tallennaBT.TabIndex = 14;
            this.tallennaBT.Text = "TALLENNA";
            this.tallennaBT.UseVisualStyleBackColor = true;
            this.tallennaBT.Click += new System.EventHandler(this.tallennaBT_Click);
            // 
            // paivitaBT
            // 
            this.paivitaBT.Location = new System.Drawing.Point(359, 142);
            this.paivitaBT.Name = "paivitaBT";
            this.paivitaBT.Size = new System.Drawing.Size(159, 34);
            this.paivitaBT.TabIndex = 15;
            this.paivitaBT.Text = "PÄIVITÄ";
            this.paivitaBT.UseVisualStyleBackColor = true;
            this.paivitaBT.Click += new System.EventHandler(this.paivitaBT_Click);
            // 
            // poistaBT
            // 
            this.poistaBT.Location = new System.Drawing.Point(531, 142);
            this.poistaBT.Name = "poistaBT";
            this.poistaBT.Size = new System.Drawing.Size(159, 34);
            this.poistaBT.TabIndex = 16;
            this.poistaBT.Text = "POISTA";
            this.poistaBT.UseVisualStyleBackColor = true;
            this.poistaBT.Click += new System.EventHandler(this.poistaBT_Click);
            // 
            // opiskelijarekisteriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 574);
            this.Controls.Add(this.poistaBT);
            this.Controls.Add(this.paivitaBT);
            this.Controls.Add(this.tallennaBT);
            this.Controls.Add(this.tyhjennaBT);
            this.Controls.Add(this.ONroTB);
            this.Controls.Add(this.SpostiTB);
            this.Controls.Add(this.PuhTB);
            this.Controls.Add(this.SnimiTB);
            this.Controls.Add(this.EnimiTB);
            this.Controls.Add(this.OidTB);
            this.Controls.Add(this.onroLB);
            this.Controls.Add(this.spostiLB);
            this.Controls.Add(this.puhLB);
            this.Controls.Add(this.snimiLB);
            this.Controls.Add(this.enimiLB);
            this.Controls.Add(this.oidLB);
            this.Controls.Add(this.TietotauluDG);
            this.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "opiskelijarekisteriForm";
            this.Text = "Opiskelijarekisterin ylläpito";
            this.Load += new System.EventHandler(this.opiskelijarekisteriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TietotauluDG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TietotauluDG;
        private System.Windows.Forms.Label oidLB;
        private System.Windows.Forms.Label enimiLB;
        private System.Windows.Forms.Label snimiLB;
        private System.Windows.Forms.Label puhLB;
        private System.Windows.Forms.Label spostiLB;
        private System.Windows.Forms.Label onroLB;
        private System.Windows.Forms.TextBox OidTB;
        private System.Windows.Forms.TextBox EnimiTB;
        private System.Windows.Forms.TextBox SnimiTB;
        private System.Windows.Forms.TextBox ONroTB;
        private System.Windows.Forms.TextBox SpostiTB;
        private System.Windows.Forms.TextBox PuhTB;
        private System.Windows.Forms.Button tyhjennaBT;
        private System.Windows.Forms.Button tallennaBT;
        private System.Windows.Forms.Button paivitaBT;
        private System.Windows.Forms.Button poistaBT;
    }
}

