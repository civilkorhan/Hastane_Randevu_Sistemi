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
    public partial class frm_Girisler : Form
    {
        public frm_Girisler()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm_Doktor_Giris dr = new frm_Doktor_Giris();
            dr.Show();
            this.Hide();
        }



        private void btn_sekreter_Click(object sender, EventArgs e)
        {
            frm_Sekreter_Giris sr=new frm_Sekreter_Giris();
            sr.Show();
            this.Hide();
        }

        private void btn_hasta_Click(object sender, EventArgs e)
        {
            frm_Hasta_Giris hs = new frm_Hasta_Giris();
            hs.Show();
            this.Hide();
            
        }
    }
}
