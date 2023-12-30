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

namespace Hastane_Uygulamasi
{
    public partial class frm_Hasta_Bilgi_Güncelleme : Form
    {
        public frm_Hasta_Bilgi_Güncelleme()
        {
            InitializeComponent();
        }
        public string TCno;
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void frm_Hasta_Bilgi_Güncelleme_Load(object sender, EventArgs e)
        {
            msk_tcno.Text= TCno;
            SqlCommand komut = new SqlCommand("Select * from tbl_Hastalar where hasta_TC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", msk_tcno.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txt_ad.Text = dr[1].ToString(); // niye 1 den başladık çünkü sql tablomuzda o id kolonuna geliyor
                txtbx_soyad.Text = dr[2].ToString();    
                txt_sifre.Text = dr[4].ToString(); 
                masked_tel.Text = dr[5].ToString();
                cmbo_cinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btn_güncelle_Click(object sender, EventArgs e)                                                 //where sorgusunu yazmayı unutma aynı yere kaydetmesin
        {
            SqlCommand komut2_new = new SqlCommand("update tbl_Hastalar set hasta_ad=@p1,hasta_soyad=@p2,hasta_sifre=@p3,hasta_telefon=@p4,hasta_cinsiyet=@p5 where hasta_TC=@p6",bgl.baglanti());
            komut2_new.Parameters.AddWithValue("@p1",txt_ad.Text);
            komut2_new.Parameters.AddWithValue("@p2",txtbx_soyad.Text);
            komut2_new.Parameters.AddWithValue("@p3",txt_sifre.Text);
            komut2_new.Parameters.AddWithValue("@p4",masked_tel.Text);
            komut2_new.Parameters.AddWithValue("@p5",cmbo_cinsiyet.Text);
            komut2_new.Parameters.AddWithValue("@p6",msk_tcno.Text);
            komut2_new.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellenmiştir.", "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Warning); // formu tamamladıktan sonra form düzenlemelerini yap
        }
    }
}
