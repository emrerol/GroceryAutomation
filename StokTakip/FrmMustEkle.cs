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
    public partial class FrmMustEkle : Form
    {
        public FrmMustEkle()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=EMRELAPTOP;Initial Catalog=StokTakip;Integrated Security=True");

        private void FrmMustEkle_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(conn.State==ConnectionState.Closed)
                {
                    conn.Open();
                }
                SqlCommand cmd = new SqlCommand("Insert into Musteri(TC,AdSoyad,Telefon,Adres,Email) values(@TC,@AdSoyad,@Telefon,@Adres,@Email)", conn);
                cmd.Parameters.AddWithValue("@TC", tbxTcNo.Text);
                cmd.Parameters.AddWithValue("@AdSoyad", tbxName.Text);
                cmd.Parameters.AddWithValue("@Telefon", tbxPhone.Text);
                cmd.Parameters.AddWithValue("@Adres", tbxAdress.Text);
                cmd.Parameters.AddWithValue("@Email", tbxMail.Text);
                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if(conn.State==ConnectionState.Open)
                {
                    conn.Close();
                }
                MessageBox.Show("Müşteri Kaydı Başarıyla Eklendi..");
                foreach (Control item in this.Controls)
                {
                    if(item is TextBox)
                    {
                        item.Text = " ";
                    }
                }
            }
        }
    }
}
