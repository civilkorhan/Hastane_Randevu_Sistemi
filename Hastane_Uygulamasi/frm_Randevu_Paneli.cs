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
    public partial class frm_Randevu_Paneli : Form
    {
        sqlbaglantisi bgl = new sqlbaglantisi();

        public frm_Randevu_Paneli()
        {
            InitializeComponent();
        }
       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_Randevu_Paneli_Load(object sender, EventArgs e)
        {
            DataTable rndvcek = new DataTable();
            SqlDataAdapter rcek = new SqlDataAdapter("Select * from tbl_Randevu", bgl.baglanti());
            rcek.Fill(rndvcek);
            dataGridView1.DataSource= rndvcek;
        }
    }
}
