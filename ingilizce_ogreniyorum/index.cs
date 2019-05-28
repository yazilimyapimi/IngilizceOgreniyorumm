using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ingilizce_ogreniyorum
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
        }
        static string conString = "Server=DESKTOP-FKJU7DE;Database=yyDB;Integrated Security=True";
        //Bu veritabanına bağlanmak için gerekli olan bağlantı cümlemiz.Bu satıra dikkat edelim.
        //Sql Servera bağlanırken kullandığımız bilgileri ve veritabanı ismini yazıyoruz.
        SqlConnection baglanti = new SqlConnection(conString);
        //bağlantı cümlemizi kullanarak bir SqlConnection bağlantısı oluşturuyoruz.

        
           
        private void BtnTesteBasla_Click(object sender, EventArgs e)
        {
            
            

            //kullanıcının teste başlama tarihi
            DateTime tarih = DateTime.Today;
            txtTestBasTarihi.Text = tarih.ToShortDateString();
            gonder = txtTestBasTarihi.Text;
            



            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                string kayit = "insert into kullanici(teste_baslama_tarihi) values (@tarihh)";
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                
                komut.Parameters.AddWithValue("@tarihh", txtTestBasTarihi.Text);
                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                baglanti.Close();
                MessageBox.Show("BAŞARILAR.");

                Sorular soru = new Sorular();
                soru.Show();
                this.Hide();

                
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }
        //ilk giriş tarihi verisini sorular adlı forma göndermek için kullanıldı. 
        public static string gonder;
        private void İndex_Load(object sender, EventArgs e)
        {
            //giriş yap sayfasındaki kullanıcı adını index formuna getir
            txtTestBaslaKulAdi.Text = GirisYap.gonderilecekVeri;
        }

        private void BtnKelimeEkle_Click(object sender, EventArgs e)
        {
            KelimeEkle kelime = new KelimeEkle();
            this.Hide();
            kelime.Show();
            
        }

        private void BtnIstatistik_Click(object sender, EventArgs e)
        {

            istatistik deger = new istatistik();
            this.Hide();
            deger.Show();

        }
    }
}
