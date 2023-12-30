using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;   // sistem kütüpkanesini ekledik

namespace Hastane_Uygulamasi
{
    public partial class frm_Hasta_Giris : Form
    {
        public frm_Hasta_Giris()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl= new sqlbaglantisi();  // tanımlamayı yaptık
        private void linklbl_uyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // butona tıklanınca formu açtırdık
        {
            frm_Hasta_Kayit nw=new frm_Hasta_Kayit();
            nw.Show();

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from tbl_Hastalar Where hasta_TC=@p1 and hasta_sifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",msk_tcno.Text);
            komut.Parameters.AddWithValue("@p2",txtbx_sifre.Text);
            SqlDataReader dr = komut.ExecuteReader(); // komuttan gelen değerleri okuttuk
            if (dr.Read()) // eğer okuyabiliyorsa
            {
                frm_Hasta_Detay newform = new frm_Hasta_Detay();
                newform.tc = msk_tcno.Text;
                newform.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Şifre veya Tc No'yu yanlış girdiniz");
            }
            bgl.baglanti().Close();
        }


    }
}
