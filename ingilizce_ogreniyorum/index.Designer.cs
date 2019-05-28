namespace ingilizce_ogreniyorum
{
    partial class index
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
            this.btnTesteBasla = new System.Windows.Forms.Button();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.btnKelimeEkle = new System.Windows.Forms.Button();
            this.txtTestBasTarihi = new System.Windows.Forms.TextBox();
            this.txtTestBaslaKulAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTesteBasla
            // 
            this.btnTesteBasla.Location = new System.Drawing.Point(265, 64);
            this.btnTesteBasla.Name = "btnTesteBasla";
            this.btnTesteBasla.Size = new System.Drawing.Size(176, 59);
            this.btnTesteBasla.TabIndex = 0;
            this.btnTesteBasla.Text = "TESTE BAŞLA";
            this.btnTesteBasla.UseVisualStyleBackColor = true;
            this.btnTesteBasla.Click += new System.EventHandler(this.BtnTesteBasla_Click);
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.Location = new System.Drawing.Point(265, 172);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(176, 59);
            this.btnIstatistik.TabIndex = 1;
            this.btnIstatistik.Text = "İSTATİSTİK";
            this.btnIstatistik.UseVisualStyleBackColor = true;
            this.btnIstatistik.Click += new System.EventHandler(this.BtnIstatistik_Click);
            // 
            // btnKelimeEkle
            // 
            this.btnKelimeEkle.Location = new System.Drawing.Point(265, 273);
            this.btnKelimeEkle.Name = "btnKelimeEkle";
            this.btnKelimeEkle.Size = new System.Drawing.Size(176, 59);
            this.btnKelimeEkle.TabIndex = 2;
            this.btnKelimeEkle.Text = "KELİME EKLE";
            this.btnKelimeEkle.UseVisualStyleBackColor = true;
            this.btnKelimeEkle.Click += new System.EventHandler(this.BtnKelimeEkle_Click);
            // 
            // txtTestBasTarihi
            // 
            this.txtTestBasTarihi.Location = new System.Drawing.Point(651, 38);
            this.txtTestBasTarihi.Name = "txtTestBasTarihi";
            this.txtTestBasTarihi.Size = new System.Drawing.Size(100, 20);
            this.txtTestBasTarihi.TabIndex = 3;
            // 
            // txtTestBaslaKulAdi
            // 
            this.txtTestBaslaKulAdi.Location = new System.Drawing.Point(651, 64);
            this.txtTestBaslaKulAdi.Name = "txtTestBaslaKulAdi";
            this.txtTestBaslaKulAdi.Size = new System.Drawing.Size(100, 20);
            this.txtTestBaslaKulAdi.TabIndex = 4;
            // 
            // index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtTestBaslaKulAdi);
            this.Controls.Add(this.txtTestBasTarihi);
            this.Controls.Add(this.btnKelimeEkle);
            this.Controls.Add(this.btnIstatistik);
            this.Controls.Add(this.btnTesteBasla);
            this.Name = "index";
            this.Text = "index";
            this.Load += new System.EventHandler(this.İndex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTesteBasla;
        private System.Windows.Forms.Button btnIstatistik;
        private System.Windows.Forms.Button btnKelimeEkle;
        private System.Windows.Forms.TextBox txtTestBasTarihi;
        private System.Windows.Forms.TextBox txtTestBaslaKulAdi;
    }
}