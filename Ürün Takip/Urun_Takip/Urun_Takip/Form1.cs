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
using System.Data.Sql;

namespace Urun_Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        //Data Source=DESKTOP-QE6JDF1\SQLEXPRESS01;Initial Catalog=DbUrun;Integrated Security=True
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-QE6JDF1\SQLEXPRESS01;Initial Catalog=DbUrun;Integrated Security=True");


        private void Btn7_Click(object sender, EventArgs e)
        {

        }
        private void Btn_Listele_Click(object sender, EventArgs e)
        {
           
            SqlCommand cmd = new SqlCommand("Select * from TblKategori", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource=dt;
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd2 = new SqlCommand("Insert into TblKategori(Ad) Values (@p1)", conn);
            cmd2.Parameters.AddWithValue("@p1", TxtKategoriAd.Text);
            cmd2.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kategoriniz başarılı bir şekilde eklendi.");
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd3 = new SqlCommand("Delete from TblKategori where ID=@p1", conn);
            cmd3.Parameters.AddWithValue("@p1", textID.Text);
            cmd3.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kategori silme işlemi başarılı bir şekilde gerçekleşti");
        }

        private void Btn_Güncelle_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd4 = new SqlCommand("Update TblKategori set Ad=@p1 where ID=@p2", conn);
            cmd4.Parameters.AddWithValue("@p1", TxtKategoriAd.Text);
            cmd4.Parameters.AddWithValue("@p2", textID.Text);
            cmd4.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Kategori güncelleme işlemi başarılı bir şekilde gerçekleşti");
        }

        private void Btn_Ara_Click(object sender, EventArgs e)
        {
            SqlCommand cmd5 = new SqlCommand("Select * from TblKategori where Ad=@p1", conn);
            cmd5.Parameters.AddWithValue("@p1", TxtKategoriAd.Text);
            SqlDataAdapter da = new SqlDataAdapter(cmd5);
            DataTable dt = new DataTable();

            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
    }
    
}
