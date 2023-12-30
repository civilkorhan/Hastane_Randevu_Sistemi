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
    public partial class frm_Hasta_Kayit : Form
    {
        public frm_Hasta_Kayit()
        {
            InitializeComponent();
        }

       

        sqlbaglantisi bgl = new sqlbaglantisi();
        private void btn_kaydol_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_Hastalar (hasta_ad,hasta_soyad,hasta_TC,hasta_sifre,hasta_telefon,hasta_cinsiyet) values (@p1,@p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txt_ad.Text);
            komut.Parameters.AddWithValue("@p2", txtbx_soyad.Text);
            komut.Parameters.AddWithValue("@p3", msk_tcno.Text);
            komut.Parameters.AddWithValue("@p4",txt_sifre.Text);
            komut.Parameters.AddWithValue("@p5",masked_tel.Text);
            komut.Parameters.AddWithValue("@p6",cmbo_cinsiyet.Text);
            komut.ExecuteNonQuery();

            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir.");
                
        }


    }
}
