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
    public partial class FrmMarka : Form
    {
        public FrmMarka()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=EMRELAPTOP;Initial Catalog=StokTakip;Integrated Security=True");
        bool situation;
        private void BlockBrand()
        {
            situation = true;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from MarkaBilgileri", conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                if (comboBox1.Text==read["Kategori"].ToString() && tbxMMArka.Text == read["Marka"].ToString() || tbxMMArka.Text== ""|| comboBox1.Text=="")
                {
                    situation = false;
                }
            }
            conn.Close();

        }


        private void button1_Click(object sender, EventArgs e)
        {

            BlockBrand();
            if (situation==true)
            {
                try
                {
                    if (conn.State == ConnectionState.Closed) { conn.Open(); }
                    SqlCommand cmd = new SqlCommand("Insert into MarkaBilgileri(Kategori,Marka) values('" + comboBox1.Text + "','" + tbxMMArka.Text + "')", conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) { conn.Close(); }                 
                    MessageBox.Show("Marka Ekleme Başarılı");
                }
               
            }
            else
            {
                MessageBox.Show("Girdiğiniz Bilgiler Zaten Var");
            }
            comboBox1.Text = " ";
            tbxMMArka.Text = " ";
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

        private void FrmMarka_Load(object sender, EventArgs e)
        {
            KategoriGetir();
        }
    }
}
