using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace ingilizce_ogreniyorum
{
    public partial class UyeOl : Form
    {
       
        public void BosTxtKontrolu()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    if ((ctrl as TextBox).Text == "")
                    {
                        MessageBox.Show("Lütfen tüm alanları doldurunuz.!.");
                        break;
                    }
                   
                }
            }
        }

        public UyeOl()
        {
            InitializeComponent();
        }
        static string conString = "Server=DESKTOP-FKJU7DE;Database=yyDB;Integrated Security=True";
        //Bu veritabanına bağlanmak için gerekli olan bağlantı cümlemiz.Bu satıra dikkat edelim.
        //Sql Servera bağlanırken kullandığımız bilgileri ve veritabanı ismini yazıyoruz.
        SqlConnection baglanti = new SqlConnection(conString);
        //bağlantı cümlemizi kullanarak bir SqlConnection bağlantısı oluşturuyoruz.
        private void BtnKayitOl_Click(object sender, EventArgs e)
        {

            BosTxtKontrolu();
            
            //Hataları engellemeye yönelik olarak, tüm veritabanı işlemlerini try-catch blokları arasında yapmaya özen gösterdik.
            try
            {
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                // Bağlantımızı kontrol ediyoruz, eğer kapalıysa açıyoruz.
                string kayit = "insert into kullanici(kullanici_adi,sifre,email) values (@kullaniciadi,@sifre,@mail)";
                // müşteriler tablomuzun ilgili alanlarına kayıt ekleme işlemini gerçekleştirecek sorgumuz.
                SqlCommand komut = new SqlCommand(kayit, baglanti);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@kullaniciadi", txtKullaniciAdi.Text);
                komut.Parameters.AddWithValue("@sifre", txtSifre.Text);
                komut.Parameters.AddWithValue("@mail", txtEmail.Text);
                

                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                baglanti.Close();
                //MessageBox.Show("Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
            GirisYap giris = new GirisYap();
            this.Hide();
            giris.Show();
        }

        private void UyeOl_Load(object sender, EventArgs e)
        {

        }
    }
}
