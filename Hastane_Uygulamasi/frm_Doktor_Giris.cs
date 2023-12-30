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
    public partial class frm_Doktor_Giris : Form
    {
        public frm_Doktor_Giris()
        {
            InitializeComponent();
        }
        sqlbaglantisi bgl=new sqlbaglantisi();
        private void frm_Doktor_Giris_Load(object sender, EventArgs e)
        {

        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            SqlCommand grs=new SqlCommand("Select * from tbl_Doctor where doktor_TC=@p1 and doktor_sifre=@p2 ",bgl.baglanti());
            grs.Parameters.AddWithValue("@p1", msk_tcno.Text);
            grs.Parameters.AddWithValue("@p2",txtbx_sifre.Text);
            SqlDataReader read=grs.ExecuteReader();
            if (read.Read())
            {
                frm_Doktor_Detay nwfrm = new frm_Doktor_Detay();
                nwfrm.dr_TC=msk_tcno.Text;
                nwfrm.Show();
                //this.Hide();
            }
            else
            {
                MessageBox.Show("Şifre veya Tc No'yu yanlış girdiniz");
            }
            bgl.baglanti().Close();

        }
    }
}
