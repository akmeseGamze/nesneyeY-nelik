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

namespace nesneyeYönelik
{
    public partial class Rezervasyon : Form
    {
        SqlConnection sct = new SqlConnection(@"Data Source=WIN-HS80J72Q22T\MYSQLSERVER1;Initial Catalog=yemekhaneRandevuSistemi;Integrated Security=True");
        SqlCommand scd;
        SqlDataAdapter sdt;
        DataSet ds;
        SqlDataReader dr;

        public int numara;
        public Rezervasyon()
        {
            InitializeComponent();
        }

        void GenelBilgi()
        {
            sct = new SqlConnection(@"Data Source=WIN-HS80J72Q22T\MYSQLSERVER1;Initial Catalog=yemekhaneRandevuSistemi;Integrated Security=True");
            sct.Open();
            sdt = new SqlDataAdapter("select Ad_Soyad, Gunler, Corba, Anayemek, Tatli, Salata from KullanıcıBilgi kb JOIN Yemek y on kb.YemekID = y.YemekID JOIN Gunler g on y.GunlerID = g.GunlerID where OgrenciNumara='"+this.numara+"'", sct);
            ds = new DataSet();
            sdt.Fill(ds);//gelen verileri datatable içerisine doldurur.
            dataGridView1.DataSource = ds.Tables[0];
            sct.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenelBilgi();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            frmAnaSayfa anasayfa=new frmAnaSayfa();
            anasayfa.no = this.numara;
            this.Hide();
            anasayfa.Show();
        }
    }
}
