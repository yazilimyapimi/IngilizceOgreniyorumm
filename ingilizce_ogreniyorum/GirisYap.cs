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
    public partial class GirisYap : Form
    {
        public GirisYap()
        {
            InitializeComponent();
        }
        static string conString = "Server=DESKTOP-FKJU7DE;Database=yyDB;Integrated Security=True";
        //Bu veritabanına bağlanmak için gerekli olan bağlantı cümlemiz.Bu satıra dikkat edelim.
        //Sql Servera bağlanırken kullandığımız bilgileri ve veritabanı ismini yazıyoruz.
        SqlConnection baglanti = new SqlConnection(conString);
        //bağlantı cümlemizi kullanarak bir SqlConnection bağlantısı oluşturuyoruz.
        public bool Giris(string us, string pass)
        {
            baglanti.Open();
            SqlCommand kmt = new SqlCommand("Select * from kullanici Where kullanici_adi=@k and sifre=@s", baglanti);
            kmt.Parameters.AddWithValue("@k", us);
            kmt.Parameters.AddWithValue("@s", pass);
            SqlDataReader oku = kmt.ExecuteReader();
            if (oku.Read())
            {
                baglanti.Close(); //Eğer veri döndüyse bağlantımızı kapatıyoruz 
                return true; //ve oluşturduğumuz bool değişkeninin değerini true olarak döndürüyoruz yani giris değişkenimizin değeri true oluyor.
            }
            else
            {
                baglanti.Close(); //Eğer veri dönmediyse bağlantımızı kapatıyoruz.Kapatmadığımız takdirde kullanıcı 2. kez üyeliğe girmeyi denediğinde hata ile karşılaşacaktır.
                return false; //ve oluşturduğumuz bool değişkeninin değerini false olarak döndürüyoruz yani giris değişkenimizin değeri false oluyor.
            }
        }
        public static string gonderilecekVeri;
    
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            

            bool girisislemi = Giris(txtKullaniciAdiGY.Text , txtSifreGY.Text);
            if (girisislemi == true)
            {
                MessageBox.Show("Giriş Başarılı Hoş Geldiniz");
                //giriş yapan kişinin kullanıcı adını index sayfasındaki textboxa gönder
                gonderilecekVeri = txtKullaniciAdiGY.Text;
                index anasayfa = new index();
                this.Hide();
                anasayfa.Show();

                //sözcükekle formuna göndereceğimiz değer ile diğer form yönlendirme yapıldı

                //gonderilecekveri = txtKullaniciAdiGY.Text; 
                //KelimeEkle wordInsert = new KelimeEkle();
                //wordInsert.Show();
            }
            else
            {
                MessageBox.Show("Bilgileriniz Hatalı Lütfen Tekrar Deneyin");
            }

          
        }
        //İlk olarak txtKullaniciAdina yazdığım yazıyı kelimeekle formuna gönderebilmek için public form sınıfının dışına genel bir değişken tanımlıyorum.
        public static string gonderilecekveri;
        private void GirisYap_Load(object sender, EventArgs e)
        {

        }
    }
}
