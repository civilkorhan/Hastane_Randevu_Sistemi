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
    public partial class frm_Sekreter_Giris : Form
    {
        public frm_Sekreter_Giris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void btn_giris_Click(object sender, EventArgs e)
        {
            SqlCommand komut=new SqlCommand("Select * From tbl_Sekreter Where sekreter_TC=@p1 and sekreter_sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",msk_tcno.Text);
            komut.Parameters.AddWithValue("@p2",txtbx_sifre.Text);
            SqlDataReader dr=komut.ExecuteReader();
            if(dr.Read())  // while değil sorgu yazıyoruz giriş sekmesindeyiz
            {
                frm_Sekreter_Detay sr=new frm_Sekreter_Detay();
                sr.tc2 = msk_tcno.Text;
                sr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Şifre veya TC no yanlış girdiniz"); //"Dikkat", MessageBoxButtons.OK);
            }
            bgl.baglanti().Close();
        }

        private void frm_Sekreter_Giris_Load(object sender, EventArgs e)
        {

        }
    }
}
