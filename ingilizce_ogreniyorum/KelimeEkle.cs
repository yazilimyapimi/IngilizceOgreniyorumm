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
    public partial class KelimeEkle : Form
    {
        public KelimeEkle()
        {
            InitializeComponent();
        }
        static string conString = "Server=DESKTOP-FKJU7DE;Database=yyDB;Integrated Security=True";
        //Bu veritabanına bağlanmak için gerekli olan bağlantı cümlemiz.Bu satıra dikkat edelim.
        //Sql Servera bağlanırken kullandığımız bilgileri ve veritabanı ismini yazıyoruz.
        SqlConnection baglanti = new SqlConnection(conString);
        //bağlantı cümlemizi kullanarak bir SqlConnection bağlantısı oluşturuyoruz.
        private void BtnKelimeEkle_Click(object sender, EventArgs e)
        {
            
            //Hataları engellemeye yönelik olarak, tüm veritabanı işlemlerini try-catch blokları arasında yapmaya özen gösterdik.
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                string kayit = "insert into kelimeler(ingilizcesi,turkcesi,ekleyen,giristarihi) values (@ingilizce,@turkce,@ekleyen,@tarih)";
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@ingilizce", txtIngilizcesi.Text.ToLower());
                komut.Parameters.AddWithValue("@turkce", txtTurkcesi.Text.ToLower());
                komut.Parameters.AddWithValue("@ekleyen", txtKulllaniciAdi.Text);
                komut.Parameters.AddWithValue("@tarih", txtTarih.Text);
                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                baglanti.Close();
                MessageBox.Show("Kelime ekleme İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }
        
        private void KelimeEkle_Load(object sender, EventArgs e)
        {
            //kullanıcın veritabanına kelime ekleme tarihi
            DateTime tarih = DateTime.Today;
            txtTarih.Text = tarih.ToShortDateString();
            txtKulllaniciAdi.Text = GirisYap.gonderilecekVeri;




        }

        private void TxtKulllaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
