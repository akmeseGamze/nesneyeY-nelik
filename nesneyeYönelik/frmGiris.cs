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
    public partial class frmGiris : Form
    {

        public frmGiris()
        {
            InitializeComponent();
        }

        SqlConnection sct = new SqlConnection(@"Data Source=WIN-HS80J72Q22T\MYSQLSERVER1;Initial Catalog=yemekhaneRandevuSistemi;Integrated Security=True");
        SqlCommand scd;
        private void button1_Click_1(object sender, EventArgs e)
        {

            SqlConnection sqlcon = new SqlConnection(@"Data Source=WIN-HS80J72Q22T\MYSQLSERVER1;Initial Catalog=yemekhaneRandevuSistemi;Integrated Security=True");
            string sorgu = "Select * From kullanıcı where kullanıcı_adı='" + kullanıcıAdıTb.Text.Trim() + "'AND sıfre='" + sifreTb.Text.Trim() + "'";
            scd = new SqlCommand(sorgu, sct);
            scd.Parameters.AddWithValue("@kullanici", kullanıcıAdıTb.Text.ToString());
            scd.Parameters.AddWithValue("@parola", sifreTb.Text.ToString());

            sct.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(scd);
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
               
                frmAnaSayfa anasayfa = new frmAnaSayfa();
                anasayfa.no = Convert.ToInt32(dt.Rows[0]["OgrenciNumara"]);
                anasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı adı veya şifre");
            }
            


            sct.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kullanıcıAdıTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
