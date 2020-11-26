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

namespace StokTakip
{
    public partial class FrmUrunListele : Form
    {
        public FrmUrunListele()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=EMRELAPTOP;Initial Catalog=StokTakip;Integrated Security=True");
        DataSet ds = new DataSet();

        private void FrmUrunListele_Load(object sender, EventArgs e)
        {
            BringProducts();
            KategoriGetir();
        }

        private void KategoriGetir()
        {

            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from KategoriBilgileri", conn);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                comboBox1.Items.Add(read["Kategori"].ToString());
            }
            conn.Close();
        }

        private void BringProducts()
        {
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("select * from Urun", conn);
            adapter.Fill(ds, "Urun");
            dataGridView1.DataSource = ds.Tables["Urun"];
            conn.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tbxBarNumber.Text = dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString();
            tbxCategoryy.Text = dataGridView1.CurrentRow.Cells["Kategori"].Value.ToString();
            tbxBrandd.Text = dataGridView1.CurrentRow.Cells["Marka"].Value.ToString();
            tbxProductName.Text = dataGridView1.CurrentRow.Cells["ÜrünAdı"].Value.ToString();
            tbxCustom.Text = dataGridView1.CurrentRow.Cells["Miktarı"].Value.ToString();
            tbxBuyPri.Text= dataGridView1.CurrentRow.Cells["AlışFiyati"].Value.ToString();
            tbxSellPri.Text= dataGridView1.CurrentRow.Cells["SatisFiyati"].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tbxBarNumber.Text!="")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update Urun set Kategori=@Kategori,Marka=@Marka where BarkodNo=@BarkodNo ", conn);
                cmd.Parameters.AddWithValue("@BarkodNo", tbxBarNumber.Text);
                cmd.Parameters.AddWithValue("@Kategori", comboBox1.Text);
                cmd.Parameters.AddWithValue("@Marka", comboBox2.Text);
            
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Güncelleme Başarılı");
                ds.Tables["Urun"].Clear();
                BringProducts();
            }
            else
            {
                MessageBox.Show("Barkod No Boş Olamaz");
            }
            

            foreach (Control item in this.Controls)
            {
                if (item is ComboBox)
                {
                    item.Text ="";
                }
            }
        }

        private void btnUpdating_Click(object sender, EventArgs e)
        {
            if (tbxBarNumber.Text!="")
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update Urun set ÜrünAdı=@ÜrünAdı,Miktarı=@Miktarı,AlışFiyati=@AlışFiyati,SatisFiyati=@SatisFiyati where BarkodNo=@BarkodNo ", conn);
                cmd.Parameters.AddWithValue("@BarkodNo", tbxBarNumber.Text);
                cmd.Parameters.AddWithValue("@ÜrünAdı", tbxProductName.Text);
                cmd.Parameters.AddWithValue("@Miktarı", int.Parse(tbxCustom.Text));
                cmd.Parameters.AddWithValue("@AlışFiyati", decimal.Parse(tbxBuyPri.Text));
                cmd.Parameters.AddWithValue("@SatisFiyati", decimal.Parse(tbxSellPri.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                ds.Tables["Urun"].Clear();
                BringProducts();
                MessageBox.Show("Güncelleme Başarılı");

            
            }
            else
            {
                MessageBox.Show("Barkod No Boş Bırakılamaz");
            }

            foreach (Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    item.Text ="";
                }
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = " ";
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from MarkaBilgileri where Kategori='" + comboBox1.SelectedItem + "'", conn);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
               comboBox2.Items.Add(read["Marka"].ToString());
            }
            conn.Close();
        }

        private void btnDeleting_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn.State == ConnectionState.Closed) { conn.Open(); }
                SqlCommand cmd = new SqlCommand("Delete from Urun Where BarkodNo ='" + dataGridView1.CurrentRow.Cells["BarkodNo"].Value.ToString() + "'", conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) { conn.Close(); }
                ds.Tables["Urun"].Clear();
                BringProducts();
                MessageBox.Show("Silme İşlemi Başarılı..");

            }
        }

        private void tbxSearching_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Urun where BarkodNo like '%" + tbxSearching.Text + "%'", conn);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
    }
}
