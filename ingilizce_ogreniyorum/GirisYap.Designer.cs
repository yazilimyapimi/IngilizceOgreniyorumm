namespace ingilizce_ogreniyorum
{
    partial class GirisYap
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
            this.txtKullaniciAdiGY = new System.Windows.Forms.TextBox();
            this.txtSifreGY = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ŞİFRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "KULLANICI ADI:";
            // 
            // txtKullaniciAdiGY
            // 
            this.txtKullaniciAdiGY.Location = new System.Drawing.Point(213, 29);
            this.txtKullaniciAdiGY.Multiline = true;
            this.txtKullaniciAdiGY.Name = "txtKullaniciAdiGY";
            this.txtKullaniciAdiGY.Size = new System.Drawing.Size(178, 35);
            this.txtKullaniciAdiGY.TabIndex = 2;
            // 
            // txtSifreGY
            // 
            this.txtSifreGY.Location = new System.Drawing.Point(213, 106);
            this.txtSifreGY.Multiline = true;
            this.txtSifreGY.Name = "txtSifreGY";
            this.txtSifreGY.Size = new System.Drawing.Size(178, 35);
            this.txtSifreGY.TabIndex = 3;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(215, 203);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(75, 23);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "GİRİŞ ";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.BtnGiris_Click);
            // 
            // GirisYap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifreGY);
            this.Controls.Add(this.txtKullaniciAdiGY);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GirisYap";
            this.Text = "GirisYap";
            this.Load += new System.EventHandler(this.GirisYap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKullaniciAdiGY;
        private System.Windows.Forms.TextBox txtSifreGY;
        private System.Windows.Forms.Button btnGiris;
    }
}