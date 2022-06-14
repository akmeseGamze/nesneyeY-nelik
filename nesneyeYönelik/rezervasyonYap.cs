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
    public partial class rezervasyonYap : Form
    { 

        SqlConnection sct = new SqlConnection(@"Data Source=WIN-HS80J72Q22T\MYSQLSERVER1;Initial Catalog=yemekhaneRandevuSistemi;Integrated Security=True");
        SqlCommand scd;
        SqlDataAdapter sdt;
        DataSet ds;
        SqlDataReader dr;

        public int no;
        int GunID;
    public rezervasyonYap()
        {
            InitializeComponent();

        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {
            // sct = new SqlConnection(@"Data Source=WIN-HS80J72Q22T\MYSQLSERVER1;Initial Catalog=yemekhaneRandevuSistemi;Integrated Security=True");
            // sct.Open();
            // sdt = new SqlDataAdapter("insert into Yemek(YemekID, Corba, Anayemek, Tatli, Salata, GunlerID) values(@)", sct);
            


        }

        private void rezervasyonYap_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'yemekhaneRandevuSistemiDataSet8.KullanıcıBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullanıcıBilgiTableAdapter.Fill(this.yemekhaneRandevuSistemiDataSet8.KullanıcıBilgi);
            // TODO: Bu kod satırı 'yemekhaneRandevuSistemiDataSet6.Yemek' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yemekTableAdapter.Fill(this.yemekhaneRandevuSistemiDataSet6.Yemek);
            // TODO: Bu kod satırı 'yemekhaneRandevuSistemiDataSet4.Gunler' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.gunlerTableAdapter.Fill(this.yemekhaneRandevuSistemiDataSet4.Gunler);

            sct = new SqlConnection(@"Data Source=WIN-HS80J72Q22T\MYSQLSERVER1;Initial Catalog=yemekhaneRandevuSistemi;Integrated Security=True");
            sct.Open();
            scd = new SqlCommand("select*from kullanıcıBilgi where OgrenciNumara='"+this.no+"'", sct);

            
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(scd);
            da.Fill(dt);
            Console.WriteLine(no);

            textBox1.Text = dt.Rows[0]["OgrenciNumara"].ToString();
            textBox2.Text = dt.Rows[0]["Ad_Soyad"].ToString();
            textBox3.Text = dt.Rows[0]["Tel"].ToString();
            sct.Close();




        }


        private void gunaComboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            sct = new SqlConnection(@"Data Source=WIN-HS80J72Q22T\MYSQLSERVER1;Initial Catalog=yemekhaneRandevuSistemi;Integrated Security=True");
            sct.Open();
            scd = new SqlCommand("select*from Gunler g JOIN Yemek y on g.GunlerID=y.GunlerID where g.GunlerID=@gId ", sct);
            scd.Parameters.AddWithValue("@gId", Convert.ToInt32(gunaComboBox1.SelectedValue));
            dr = scd.ExecuteReader();

            try
            {
                while (dr.Read())
                {
                    gunaTextBox1.Text = dr["Corba"].ToString();
                    gunaTextBox2.Text = dr["Anayemek"].ToString();
                    gunaTextBox3.Text = dr["Tatli"].ToString();
                    gunaTextBox4.Text = dr["Salata"].ToString();
                }
                sct.Close();

            }
            catch
            {
                MessageBox.Show("Mokoko");
                sct.Close();
            }


        }


        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            sct = new SqlConnection(@"Data Source=WIN-HS80J72Q22T\MYSQLSERVER1;Initial Catalog=yemekhaneRandevuSistemi;Integrated Security=True");
            sct.Open();
            scd = new SqlCommand("update KullanıcıBilgi set YemekID='"+Convert.ToInt32(gunaComboBox1.SelectedValue) +"'where OgrenciNumara='" + this.no + "'", sct);

            scd.ExecuteNonQuery();

            Rezervasyon numara = new Rezervasyon();
            numara.numara = this.no;
            numara.Show();
            this.Hide();

           

            sct.Close();

        }










        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "") foreach (Control item in Controls) if (item is TextBox) item.Text = ""; foreach (Control item in Controls) if (item is ComboBox) item.Text = "";
            sct = new SqlConnection(@"Data Source=WIN-HS80J72Q22T\MYSQLSERVER1;Initial Catalog=yemekhaneRandevuSistemi;Integrated Security=True");
            sct.Open();
            scd = new SqlCommand("select * from KullanıcıBilgi where OgrenciNumara like '" + textBox1.Text + "'", sct);
            dr = scd.ExecuteReader();

            while (dr.Read())
            {
                comboBox1.Text = dr["Ad_Soyad"].ToString();
                textBox3.Text = dr["Tel"].ToString();
            }
            sct.Close();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.Close();
            frmAnaSayfa anasayfa = new frmAnaSayfa();
            anasayfa.no= this.no;   
            anasayfa.Show();
        }
    }
}
