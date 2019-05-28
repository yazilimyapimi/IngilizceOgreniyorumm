namespace ingilizce_ogreniyorum
{
    partial class KelimeEkle
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtIngilizcesi = new System.Windows.Forms.TextBox();
            this.txtTurkcesi = new System.Windows.Forms.TextBox();
            this.btnKelimeEkle = new System.Windows.Forms.Button();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.txtKulllaniciAdi = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "EKLEYECEĞİNİZ KELİMENİN:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "İNGİLİZCESİ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(97, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "TÜRKÇESİ:";
            // 
            // txtIngilizcesi
            // 
            this.txtIngilizcesi.Location = new System.Drawing.Point(191, 114);
            this.txtIngilizcesi.Multiline = true;
            this.txtIngilizcesi.Name = "txtIngilizcesi";
            this.txtIngilizcesi.Size = new System.Drawing.Size(175, 36);
            this.txtIngilizcesi.TabIndex = 3;
            // 
            // txtTurkcesi
            // 
            this.txtTurkcesi.Location = new System.Drawing.Point(191, 202);
            this.txtTurkcesi.Multiline = true;
            this.txtTurkcesi.Name = "txtTurkcesi";
            this.txtTurkcesi.Size = new System.Drawing.Size(175, 36);
            this.txtTurkcesi.TabIndex = 4;
            // 
            // btnKelimeEkle
            // 
            this.btnKelimeEkle.Location = new System.Drawing.Point(217, 314);
            this.btnKelimeEkle.Name = "btnKelimeEkle";
            this.btnKelimeEkle.Size = new System.Drawing.Size(75, 23);
            this.btnKelimeEkle.TabIndex = 5;
            this.btnKelimeEkle.Text = "EKLE";
            this.btnKelimeEkle.UseVisualStyleBackColor = true;
            this.btnKelimeEkle.Click += new System.EventHandler(this.BtnKelimeEkle_Click);
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(683, 46);
            this.txtTarih.Multiline = true;
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Size = new System.Drawing.Size(114, 36);
            this.txtTarih.TabIndex = 6;
            // 
            // txtKulllaniciAdi
            // 
            this.txtKulllaniciAdi.Location = new System.Drawing.Point(688, 12);
            this.txtKulllaniciAdi.Name = "txtKulllaniciAdi";
            this.txtKulllaniciAdi.Size = new System.Drawing.Size(100, 20);
            this.txtKulllaniciAdi.TabIndex = 7;
            this.txtKulllaniciAdi.TextChanged += new System.EventHandler(this.TxtKulllaniciAdi_TextChanged);
            // 
            // KelimeEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKulllaniciAdi);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.btnKelimeEkle);
            this.Controls.Add(this.txtTurkcesi);
            this.Controls.Add(this.txtIngilizcesi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KelimeEkle";
            this.Text = "KelimeEkle";
            this.Load += new System.EventHandler(this.KelimeEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIngilizcesi;
        private System.Windows.Forms.TextBox txtTurkcesi;
        private System.Windows.Forms.Button btnKelimeEkle;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.TextBox txtKulllaniciAdi;
    }
}