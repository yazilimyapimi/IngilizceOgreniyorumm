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
    public partial class istatistik : Form
    {
        public istatistik()
        {
            InitializeComponent();
        }

        private void İstatistik_Load(object sender, EventArgs e)
        {
            string conString = "Server=DESKTOP-FKJU7DE;Database=yyDB;Integrated Security=True";
            //Bu veritabanına bağlanmak için gerekli olan bağlantı cümlemiz.Bu satıra dikkat edelim.
            //Sql Servera bağlanırken kullandığımız bilgileri ve veritabanı ismini yazıyoruz.
            SqlConnection baglanti = new SqlConnection(conString);
            //bağlantı cümlemizi kullanarak bir SqlConnection bağlantısı oluşturuyoruz.
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT dogrular COUNT(*) FROM dogrular";
            komut.Connection = baglanti;
            komut.CommandType = CommandType.Text;



            SqlDataReader dr;
            baglanti.Open();
            dr = komut.ExecuteReader();
            while (dr.Read())
            {

                txtDogruSayisi.Text = (dr["dogrular"]).ToString();
                
                
            }


            baglanti.Close();
            
        }
    }
}
