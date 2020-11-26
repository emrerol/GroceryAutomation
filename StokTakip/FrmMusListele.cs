using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class FrmMusListele : Form
    {
        public FrmMusListele()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=EMRELAPTOP;Initial Catalog=StokTakip;Integrated Security=True");
        DataSet ds = new DataSet();


        private void FrmMusListele_Load(object sender, EventArgs e)
        {
            KayitGoster();
        }

        private void KayitGoster()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlDataAdapter adpt = new SqlDataAdapter(" select* from Musteri ", conn);
                adpt.Fill(ds, "Musteri");
                dataGridView1.DataSource = ds.Tables["Musteri"];
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxTcNum.Text = dataGridView1.CurrentRow.Cells["TC"].Value.ToString();
            tbxNeym.Text = dataGridView1.CurrentRow.Cells["AdSoyad"].Value.ToString();
            tbxPhone2.Text = dataGridView1.CurrentRow.Cells["Telefon"].Value.ToString();
            tbxAdress2.Text = dataGridView1.CurrentRow.Cells["Adres"].Value.ToString();
            tbxMail2.Text = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();               
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if(conn.State==ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("Update Musteri set AdSoyad=@AdSoyad,Telefon=@Telefon,Adres=@Adres,Email=@Email where TC=@TC ",conn);
                cmd.Parameters.AddWithValue("@TC", tbxTcNum.Text);
                cmd.Parameters.AddWithValue("@AdSoyad", tbxNeym.Text);
                cmd.Parameters.AddWithValue("@Telefon", tbxPhone2.Text);
                cmd.Parameters.AddWithValue("@Adres", tbxAdress2.Text);
                cmd.Parameters.AddWithValue("@Email", tbxMail2.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if(conn.State==ConnectionState.Open) { conn.Close(); }
                ds.Tables["Musteri"].Clear();
                KayitGoster();            
                MessageBox.Show("Güncelleme Başarılı..");
                foreach (Control item in Controls)
                {
                    if(item is TextBox) { item.Text = " "; }
                }
            }

            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if(conn.State==ConnectionState.Closed) { conn.Open(); }
                SqlCommand cmd = new SqlCommand("Delete from Musteri Where TC ='"+dataGridView1.CurrentRow.Cells["TC"].Value.ToString()+"'",conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if(conn.State==ConnectionState.Open) { conn.Close(); }
                ds.Tables["Musteri"].Clear();
                KayitGoster();
                MessageBox.Show("Silme İşlemi Başarılı..");

            }
        }

        private void txbTcAra_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Musteri where TC like '%" + txbTcAra.Text + "%'", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
