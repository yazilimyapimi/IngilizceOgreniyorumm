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
    public partial class Sorular : Form
    {
        public Sorular()
        {
            InitializeComponent();
        }
        public void rdnYanlislar()
        {
            string conString = "Server=DESKTOP-FKJU7DE;Database=yyDB;Integrated Security=True";          
            SqlConnection baglanti = new SqlConnection(conString);
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT TOP 25 *FROM kelimeler order by NEWID()";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lstRandomYanlislar.Items.Add(dr["turkcesi"]);
                
            }
            baglanti.Close();
            var yanlisVeriler = new List<string>();
            string test = "";
            foreach (var item in lstRandomYanlislar.Items)
            {
                test += item.ToString();
                yanlisVeriler.Add(test);

                    rdn2Soru1.Text = lstRandomYanlislar.Items[0].ToString();
                    rdn3Soru1.Text = lstRandomYanlislar.Items[1].ToString();
                    rdn4Soru1.Text = lstRandomYanlislar.Items[2].ToString();

                    rdn1Soru2.Text = lstRandomYanlislar.Items[3].ToString();
                    rdn2Soru2.Text = lstRandomYanlislar.Items[4].ToString();
                    rdn4Soru2.Text = lstRandomYanlislar.Items[5].ToString();

                    rdn1Soru3.Text = lstRandomYanlislar.Items[6].ToString();
                    rdn2Soru3.Text = lstRandomYanlislar.Items[7].ToString();
                    rdn3Soru3.Text = lstRandomYanlislar.Items[8].ToString();

                    rdn1Soru4.Text = lstRandomYanlislar.Items[9].ToString();
                    rdn3Soru4.Text = lstRandomYanlislar.Items[10].ToString();
                    rdn4Soru4.Text = lstRandomYanlislar.Items[11].ToString();

                    rdn1Soru5.Text = lstRandomYanlislar.Items[12].ToString();
                    rdn2Soru5.Text = lstRandomYanlislar.Items[13].ToString();
                    rdn3Soru5.Text = lstRandomYanlislar.Items[14].ToString();

            }
  
        }
        static string conString = "Server=DESKTOP-FKJU7DE;Database=yyDB;Integrated Security=True";     
        SqlConnection baglanti = new SqlConnection(conString);
     
        public void DogruYanlisSysDBEkle()
        {

            baglanti.Open();
            try
            {
                SqlCommand deger = new SqlCommand("insert into dogru_yanlis_sayisi(dogru_sayisi, yanlis_sayisi,kullaniciAdi) values (@dsys,@ysys,@ad)", baglanti);
                deger.Parameters.AddWithValue("@dsys", lstDogrular.Items.Count);
                deger.Parameters.AddWithValue("@ysys", lstYanlislar.Items.Count);
                deger.Parameters.AddWithValue("@ad", txtUserName.Text);
                deger.ExecuteNonQuery();

            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
            finally
            {
                baglanti.Close();
            }

        }
        public void DogrularDBEkle()
        {
            baglanti.Open();

            try
            {
                

                for (int i = 0; i < lstDogrular.Items.Count; i++)
                {
                    SqlCommand cmd = new SqlCommand("insert into dogrular(dogrular,kullaniciAdi) values (@d,@ad)", baglanti);
                    cmd.Parameters.AddWithValue("@d", lstDogrular.Items[i].ToString());
                    cmd.Parameters.AddWithValue("@ad", txtUserName.Text);
                    cmd.ExecuteNonQuery();
                }

            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
            finally
            {
                baglanti.Close();
            }

        }

        public void YanlislarDBEKle()
        {
            baglanti.Open();

            try
            {
                //YANLIŞLAR HER EKLENDİĞİNDE KULLANICI ADI DA LSTYANLİSLAR.ITEMS.COUNT KADAR EKLENSİN

                for (int i = 0; i < lstYanlislar.Items.Count; i++)
                {
                    SqlCommand cmd = new SqlCommand("insert into yanlislar(yanlislar,kullaniciAdi) values (@y,@ad)", baglanti);

                    cmd.Parameters.AddWithValue("@y", lstYanlislar.Items[i].ToString());
                    cmd.Parameters.AddWithValue("@ad", txtUserName.Text);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception hata)
            {

                MessageBox.Show(hata.ToString());
            }
            finally
            {
                baglanti.Close();
            }
        }
        public void lsEkleYanlisCevap()
        {
            if (rdn1Soru1.Checked==false)
            {
                if (rdn2Soru1.Checked)
                {
                    lstYanlislar.Items.Add(rdn2Soru1.Text);
                }
                if (rdn3Soru1.Checked)
                {
                    lstYanlislar.Items.Add(rdn3Soru1.Text);
                }
                if (rdn4Soru1.Checked)
                {
                    lstYanlislar.Items.Add(rdn4Soru1.Text);
                }           
            }
            if (rdn3Soru2.Checked == false)
            {
                if (rdn1Soru2.Checked)
                {
                    lstYanlislar.Items.Add(rdn1Soru2);
                }
                if (rdn2Soru2.Checked)
                {
                    lstYanlislar.Items.Add(rdn2Soru2.Text);
                }
                if (rdn4Soru2.Checked)
                {
                    lstYanlislar.Items.Add(rdn4Soru2.Text);
                }

            }
            if (rdn4Soru3.Checked == false)
            {
                if (rdn1Soru3.Checked)
                {
                    lstYanlislar.Items.Add(rdn1Soru3);
                }
                if (rdn2Soru3.Checked)
                {
                    lstYanlislar.Items.Add(rdn2Soru3.Text);
                }
                if (rdn3Soru3.Checked)
                {
                    lstYanlislar.Items.Add(rdn3Soru3.Text);
                }

            }
            if (rdn2Soru4.Checked == false)
            {
                if (rdn1Soru4.Checked)
                {
                    lstYanlislar.Items.Add(rdn1Soru4);
                }
                if (rdn3Soru4.Checked)
                {
                    lstYanlislar.Items.Add(rdn3Soru4.Text);
                }
                if (rdn4Soru4.Checked)
                {
                    lstYanlislar.Items.Add(rdn4Soru4.Text);
                }

            }
            if (rdn4Soru5.Checked == false)
            {
                if (rdn1Soru5.Checked)
                {
                    lstYanlislar.Items.Add(rdn1Soru5);
                }
                if (rdn2Soru5.Checked)
                {
                    lstYanlislar.Items.Add(rdn2Soru5.Text);
                }
                if (rdn3Soru5.Checked)
                {
                    lstYanlislar.Items.Add(rdn3Soru5.Text);
                }

            }
        }
        public void lsEkleDogruCevap()
        {
            if (rdn1Soru1.Checked)
            {
                lstDogrular.Items.Add(rdn1Soru1.Text);
                              
            }
            if (rdn3Soru2.Checked)
            {

                lstDogrular.Items.Add(rdn3Soru2.Text);

            }
            if (rdn4Soru3.Checked)
            {

                lstDogrular.Items.Add(rdn4Soru3.Text);
            }
            if (rdn2Soru4.Checked)
            {
                lstDogrular.Items.Add(rdn2Soru4.Text);
            }
            if (rdn4Soru5.Checked)
            {
                lstDogrular.Items.Add(rdn4Soru5.Text);

            }          
        }
        

        
        private void BtnTestBitir_Click(object sender, EventArgs e)
        {
            lsEkleDogruCevap();
            lsEkleYanlisCevap();

        }
        public void TabloOlustur()
        {
            string baglantiCumlesi = "Server=DESKTOP-FKJU7DE;Database=yyDB;Integrated Security=True";
            using (SqlConnection baglanti = new SqlConnection(baglantiCumlesi))
            {
                try
                {

                    baglanti.Open();                 
                    using (SqlCommand command = new SqlCommand("CREATE TABLE KullaniciTestBilgileri(KulllaniciAdi char(50),Dogrular char(50),Yanlislar char(50), Dogru_Sayisi int, Yanlis_Sayisi int, Toplam_Soru_Sayisi int);", baglanti))
                    
                        command.ExecuteNonQuery();

                    MessageBox.Show("Tablo oluşturuldu");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        public static string dogru, yanlis;

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnTamam_Click(object sender, EventArgs e)
        {
            DogruYanlisSysDBEkle();
            DogrularDBEkle();
            YanlislarDBEKle();
            index anasayfa = new index();
            this.Hide();
            anasayfa.Show();
        }

        public void YeniTabloBilgileri()
        {
            try
            {
                string conString = "Server=DESKTOP-FKJU7DE;Database=yyDB;Integrated Security=True";              
                SqlConnection baglanti = new SqlConnection(conString);             
                if (baglanti.State == ConnectionState.Closed)
                    baglanti.Open();
                
                string kayit = "insert into KullaniciTestBilgileri(Kullanici_Adi, Dogrular, Yanlislar,Dogru_Sayisi, Yanlis_Sayisi,Toplam_Soru_Sayisi) values (@kullaniciadi,@dogrular,@yanlislar,@d_sayisi,@y_sayisi,@top_sayi )";
                

                int dogruCevapSayisi = lstDogrular.Items.Count;
                int yanlisCevapSayisi = lstYanlislar.Items.Count;

               

                    SqlCommand komut = new SqlCommand(kayit, baglanti);
                //Sorgumuzu ve baglantimizi parametre olarak alan bir SqlCommand nesnesi oluşturuyoruz.
                komut.Parameters.AddWithValue("@top_sayi", 5);
                komut.Parameters.AddWithValue("@d_sayisi", dogruCevapSayisi);
                komut.Parameters.AddWithValue("@y_sayisi", yanlisCevapSayisi);
                komut.Parameters.AddWithValue("@kullaniciadi", txtUserName.Text);
                komut.Parameters.AddWithValue("@dogrular", dogru);
                komut.Parameters.AddWithValue("@yanlislar", yanlis);
                //Parametrelerimize Form üzerinde ki kontrollerden girilen verileri aktarıyoruz.
                komut.ExecuteNonQuery();
                //Veritabanında değişiklik yapacak komut işlemi bu satırda gerçekleşiyor.
                baglanti.Close();
                MessageBox.Show("Kayıt İşlemi Gerçekleşti.");
            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }

        }

        public void IlkGunSorulari()
        {
            string conString = "Server=DESKTOP-FKJU7DE;Database=yyDB;Integrated Security=True";
            SqlConnection baglanti = new SqlConnection(conString);
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT TOP 5 *FROM kelimeler";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {

                lstIlkGunSorulari.Items.Add(dr["ingilizcesi"]);
                lstIlkGunCevaplari.Items.Add(dr["turkcesi"]);
            }

            baglanti.Close();         
            var veriler2 = new List<string>();
            string test = "";
            foreach (var item in lstIlkGunSorulari.Items)
            {
                test += item.ToString();
                veriler2.Add(test);

            }
            txtSoru1.Text = lstIlkGunSorulari.Items[0].ToString();
            txtSoru2.Text = lstIlkGunSorulari.Items[1].ToString();
            txtSoru3.Text = lstIlkGunSorulari.Items[2].ToString();
            txtSoru4.Text = lstIlkGunSorulari.Items[3].ToString();
            txtSoru5.Text = lstIlkGunSorulari.Items[4].ToString();
            //soruların türkçelerini alacağız
            var veriler1 = new List<string>();
            string test1 = "";
            foreach (var item in lstIlkGunCevaplari.Items)
            {
                test1 += item.ToString();
                veriler1.Add(test1);

            }
            rdn1Soru1.Text = lstIlkGunCevaplari.Items[0].ToString();
            rdn3Soru2.Text = lstIlkGunCevaplari.Items[1].ToString();
            rdn4Soru3.Text = lstIlkGunCevaplari.Items[2].ToString();
            rdn2Soru4.Text = lstIlkGunCevaplari.Items[3].ToString();
            rdn4Soru5.Text = lstIlkGunCevaplari.Items[4].ToString();

        }
        public void IkinciGunSorulari()
        {
            string conString = "Server=DESKTOP-FKJU7DE;Database=yyDB;Integrated Security=True";
            SqlConnection baglanti = new SqlConnection(conString);
            SqlCommand komutt = new SqlCommand
            {
                CommandText = "SELECT TOP 5 *FROM kelimeler",
                Connection = baglanti,
                CommandType = CommandType.Text
            };
            SqlDataReader drrr;
            baglanti.Open();
            drrr = komutt.ExecuteReader();
            while (drrr.Read())
            {
                lstIlkGunSorulari.Items.Add(drrr["ingilizcesi"]);
                lstIlkGunCevaplari.Items.Add(drrr["turkcesi"]);
            }

            baglanti.Close();
            //listbox taki ilkgün sorulması gereken soruları textboxa dağıtacak kod:
            var veriler2 = new List<string>();

            string test = "";
            foreach (var item in lstIlkGunSorulari.Items)
            {
                test += item.ToString();
                veriler2.Add(test);
            }

            txtSoru1.Text = lstIlkGunSorulari.Items[0].ToString();
            txtSoru2.Text = lstIlkGunSorulari.Items[1].ToString();
            txtSoru3.Text = lstIlkGunSorulari.Items[2].ToString();
            txtSoru4.Text = lstIlkGunSorulari.Items[3].ToString();
            txtSoru5.Text = lstIlkGunSorulari.Items[4].ToString();
            var veriler1 = new List<string>();

            string test1 = "";
            foreach (var item in lstIlkGunCevaplari.Items)
            {
                test1 += item.ToString();
                veriler1.Add(test1);

            }
            rdn1Soru1.Text = lstIlkGunCevaplari.Items[0].ToString();
            rdn3Soru2.Text = lstIlkGunCevaplari.Items[1].ToString();
            rdn4Soru3.Text = lstIlkGunCevaplari.Items[2].ToString();
            rdn2Soru4.Text = lstIlkGunCevaplari.Items[3].ToString();
            rdn4Soru5.Text = lstIlkGunCevaplari.Items[4].ToString();
        }
        public void BirHaftaSonraSorulari()
        {
            string conString = "Server=DESKTOP-FKJU7DE;Database=yyDB;Integrated Security=True";
            SqlConnection baglanti = new SqlConnection(conString);
            SqlCommand kmt = new SqlCommand
            {
                CommandText = "SELECT TOP 5 *FROM bir_hafta_sonra",
                Connection = baglanti,
                CommandType = CommandType.Text
            };
            SqlDataReader d;
            baglanti.Open();
            d = kmt.ExecuteReader();
            while (d.Read())
            {
                lstIlkGunSorulari.Items.Add(d["ingilizcesi"]);
                lstIlkGunCevaplari.Items.Add(d["turkcesi"]);
            }
            baglanti.Close();
            //listbox taki ilkgün sorulması gereken soruları textboxa dağıtacak kod:
            var veriler2 = new List<string>();
            string test = "";
            foreach (var item in lstIlkGunSorulari.Items)
            {
                test += item.ToString();
                veriler2.Add(test);

            }
            txtSoru1.Text = lstIlkGunSorulari.Items[0].ToString();
            txtSoru2.Text = lstIlkGunSorulari.Items[1].ToString();
            txtSoru3.Text = lstIlkGunSorulari.Items[2].ToString();
            txtSoru4.Text = lstIlkGunSorulari.Items[3].ToString();
            txtSoru5.Text = lstIlkGunSorulari.Items[4].ToString();
            var veriler1 = new List<string>();

            string test1 = "";
            foreach (var item in lstIlkGunCevaplari.Items)
            {
                test1 += item.ToString();
                veriler1.Add(test1);

            }
            rdn1Soru1.Text = lstIlkGunCevaplari.Items[0].ToString();
            rdn3Soru2.Text = lstIlkGunCevaplari.Items[1].ToString();
            rdn4Soru3.Text = lstIlkGunCevaplari.Items[2].ToString();
            rdn2Soru4.Text = lstIlkGunCevaplari.Items[3].ToString();
            rdn4Soru5.Text = lstIlkGunCevaplari.Items[4].ToString();
        }
        public void BirAySonraSorulari()
        {
            string conString = "Server=DESKTOP-FKJU7DE;Database=yyDB;Integrated Security=True";
            SqlConnection baglanti = new SqlConnection(conString);
            SqlCommand cmd = new SqlCommand
            {
                CommandText = "SELECT TOP 5 *FROM bir_ay_sonra",
                Connection = baglanti,
                CommandType = CommandType.Text
            };
            SqlDataReader r;
            baglanti.Open();
            r = cmd.ExecuteReader();
            while (r.Read())
            {

                lstIlkGunSorulari.Items.Add(r["ingilizcesi"]);
                lstIlkGunCevaplari.Items.Add(r["turkcesi"]);
            }

            baglanti.Close();
            var veriler2 = new List<string>();
            string test = "";
            foreach (var item in lstIlkGunSorulari.Items)
            {
                test += item.ToString();
                veriler2.Add(test);
            }
            txtSoru1.Text = lstIlkGunSorulari.Items[0].ToString();
            txtSoru2.Text = lstIlkGunSorulari.Items[1].ToString();
            txtSoru3.Text = lstIlkGunSorulari.Items[2].ToString();
            txtSoru4.Text = lstIlkGunSorulari.Items[3].ToString();
            txtSoru5.Text = lstIlkGunSorulari.Items[4].ToString();
            var veriler1 = new List<string>();
            string test1 = "";
            foreach (var item in lstIlkGunCevaplari.Items)
            {
                test1 += item.ToString();
                veriler1.Add(test1);

            }
            rdn1Soru1.Text = lstIlkGunCevaplari.Items[0].ToString();
            rdn3Soru2.Text = lstIlkGunCevaplari.Items[1].ToString();
            rdn4Soru3.Text = lstIlkGunCevaplari.Items[2].ToString();
            rdn2Soru4.Text = lstIlkGunCevaplari.Items[3].ToString();
            rdn4Soru5.Text = lstIlkGunCevaplari.Items[4].ToString();
        }
        public void AltiAySonraSorulari()
        {
            string conString = "Server=DESKTOP-FKJU7DE;Database=yyDB;Integrated Security=True";
            SqlConnection baglanti = new SqlConnection(conString);
            SqlCommand komut = new SqlCommand
            {
                CommandText = "SELECT TOP 5 *FROM alti_ay_sonra",
                Connection = baglanti,
                CommandType = CommandType.Text
            };
            SqlDataReader drr;
            baglanti.Open();
            drr = komut.ExecuteReader();
            while (drr.Read())
            {

                lstIlkGunSorulari.Items.Add(drr["ingilizcesi"]);
                lstIlkGunCevaplari.Items.Add(drr["turkcesi"]);
            }
            baglanti.Close();
            var veriler2 = new List<string>();
            string test = "";
            foreach (var item in lstIlkGunSorulari.Items)
            {
                test += item.ToString();
                veriler2.Add(test);

            }
            txtSoru1.Text = lstIlkGunSorulari.Items[0].ToString();
            txtSoru2.Text = lstIlkGunSorulari.Items[1].ToString();
            txtSoru3.Text = lstIlkGunSorulari.Items[2].ToString();
            txtSoru4.Text = lstIlkGunSorulari.Items[3].ToString();
            txtSoru5.Text = lstIlkGunSorulari.Items[4].ToString();
            var veriler1 = new List<string>();

            string test1 = "";
            foreach (var item in lstIlkGunCevaplari.Items)
            {
                test1 += item.ToString();
                veriler1.Add(test1);

            }
            rdn1Soru1.Text = lstIlkGunCevaplari.Items[0].ToString();
            rdn3Soru2.Text = lstIlkGunCevaplari.Items[1].ToString();
            rdn4Soru3.Text = lstIlkGunCevaplari.Items[2].ToString();
            rdn2Soru4.Text = lstIlkGunCevaplari.Items[3].ToString();
            rdn4Soru5.Text = lstIlkGunCevaplari.Items[4].ToString();
        }
        public void SoruTarihiHesapla()
        {     
            string conString = "Server=DESKTOP-FKJU7DE;Database=yyDB;Integrated Security=True";
            SqlConnection baglanti = new SqlConnection(conString);
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT *FROM kullanici";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;
            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lstTarih.Items.Add(dr["teste_baslama_tarihi"]);
            }
            baglanti.Close();
        }
        private void Sorular_Load(object sender, EventArgs e)
        {
           
            SoruTarihiHesapla();
            DateTime birGunSonra, birHaftaSonra, birAySonra, altiAySonra;
            DateTime tarih = Convert.ToDateTime(lstTarih.Items[1]);
            string suan = txtIlkGirisTarihi.Text;
            birGunSonra = tarih.AddDays(1);
            birHaftaSonra = tarih.AddDays(7);
            birAySonra = tarih.AddDays(30);
            altiAySonra = tarih.AddDays(180);
            txtBirGunSonra.Text = birGunSonra.ToShortDateString();
            txtBirHaftaSonra.Text = birHaftaSonra.ToShortDateString();
            txtBirAySonra.Text = birAySonra.ToShortDateString();
            txtAltiAySonra.Text = altiAySonra.ToShortDateString();         
            string simdi = DateTime.Now.ToShortDateString();
            if (simdi ==suan)
            {
                IlkGunSorulari();
                
            }
            if (txtBirGunSonra.Text==suan)
            {
                IkinciGunSorulari();
            }
            else if (txtBirHaftaSonra.Text==suan)
            {
                BirHaftaSonraSorulari();
            }
            else if (txtAltiAySonra.Text==suan)
            {
                AltiAySonraSorulari();
               
            }
            else if (txtBirAySonra.Text==suan)
            {

                BirAySonraSorulari();
            }

            txtUserName.Text = GirisYap.gonderilecekVeri;
            lstRandomYanlislar.Visible = false;
            txtIlkGirisTarihi.Text = index.gonder;
            rdnYanlislar();
            for (int i = 0; i < 6; i++)
            {
                Random konum = new Random();
                int randomSayi = konum.Next(1, 5);
                switch (randomSayi)
                {
                    case 1:
                        {
                            grp1.Location = new Point(x: 30, y: 12);
                            grp2.Location = new Point(x: 30, y: 167);
                            grp3.Location = new Point(x: 30, y: 320);
                            grp4.Location = new Point(x: 30, y: 473);
                            grp5.Location = new Point(x: 30, y: 622);
                        }
                        break;
                    case 2:
                        {
                            grp5.Location = new Point(x: 30, y: 12);
                            grp4.Location = new Point(x: 30, y: 167);
                            grp3.Location = new Point(x: 30, y: 320);
                            grp1.Location = new Point(x: 30, y: 473);
                            grp2.Location = new Point(x: 30, y: 622);
                        }
                        break;
                    case 3:
                        {
                            grp3.Location = new Point(x: 30, y: 12);
                            grp1.Location = new Point(x: 30, y: 167);
                            grp5.Location = new Point(x: 30, y: 320);
                            grp2.Location = new Point(x: 30, y: 473);
                            grp4.Location = new Point(x: 30, y: 622);
                        }
                        break;
                    case 4:
                        {
                            grp1.Location = new Point(x: 30, y: 12);
                            grp5.Location = new Point(x: 30, y: 167);
                            grp4.Location = new Point(x: 30, y: 320);
                            grp3.Location = new Point(x: 30, y: 473);
                            grp2.Location = new Point(x: 30, y: 622);
                        }
                        break;
                    default:
                        {
                            grp1.Location = new Point(x: 30, y: 12);
                            grp5.Location = new Point(x: 30, y: 167);
                            grp4.Location = new Point(x: 30, y: 320);
                            grp3.Location = new Point(x: 30, y: 473);
                            grp2.Location = new Point(x: 30, y: 622);
                        }
                        break;
                }

              

            }
        }

        

        private void GrpTestSonucu_Enter(object sender, EventArgs e)
        {

        }
    }
}


