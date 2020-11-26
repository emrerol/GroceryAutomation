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
    
    public partial class FrmKategori : Form 
    {
        public FrmKategori()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=EMRELAPTOP;Initial Catalog=StokTakip;Integrated Security=True");
        bool situation;

        private void BlockCategory()
        {
            situation = true;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from KategoriBilgileri",conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                if(textBox1.Text==read["Kategori"].ToString() || textBox1.Text=="")
                {
                    situation = false;
                }
            }
            conn.Close();

        }

        private void FrmKategori_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BlockCategory();
            if (situation==true)
            {
                try
                {
                    if(conn.State==ConnectionState.Closed) { conn.Open(); }
                    SqlCommand cmd = new SqlCommand("Insert into KategoriBİlgileri(Kategori) values('" + textBox1.Text + "')", conn);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {   
                    if(conn.State==ConnectionState.Open) { conn.Close(); }
                    
                    MessageBox.Show("Kategori Ekleme Başarılı");
                }
            }
            else
            {
                MessageBox.Show("Kategori Zaten Var");
            }
            textBox1.Text = " ";
            
        }
    }
}
