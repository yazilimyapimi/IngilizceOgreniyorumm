using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ingilizce_ogreniyorum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnUyeOl_Click(object sender, EventArgs e)
        {
            UyeOl uye = new UyeOl();
            this.Hide();
            uye.Show();
        }

        private void BtnGiris_Click(object sender, EventArgs e)
        {
            GirisYap giris = new GirisYap();
            this.Hide();
            giris.Show();
        }
    }
}
