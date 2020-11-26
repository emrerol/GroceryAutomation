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
    public partial class FrmUrunEkle : Form
    {
        public FrmUrunEkle()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=EMRELAPTOP;Initial Catalog=StokTakip;Integrated Security=True");
        bool situation;
        private void BarcodControl()
        {
            situation = true;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Urun", conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                if (tbxBarNo.Text==read["BarkodNo"].ToString() || tbxBarNo.Text=="")
                {
                    situation = false;
                }
            }
            conn.Close();

        }



        private void gbxVarUrun_Enter(object sender, EventArgs e)
        {

        }

        private void BringCategori()
        {
            
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from KategoriBilgileri", conn);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                cbxCate.Items.Add(read["Kategori"].ToString());
            }
            conn.Close();
        }

        private void FrmUrunEkle_Load(object sender, EventArgs e)
        {
            BringCategori();
        }

        private void cbxCate_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxMarka.Items.Clear();
            cbxMarka.Text = " ";
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from MarkaBilgileri where Kategori='"+cbxCate.SelectedItem+"'", conn);
            SqlDataReader read = cmd.ExecuteReader();

            while (read.Read())
            {
                cbxMarka.Items.Add(read["Marka"].ToString());
            }
            conn.Close();
        }

        private void btnYEkle_Click(object sender, EventArgs e)
        {
            BarcodControl();

            if (situation == true)
            {
                try
                {
                    if (conn.State == ConnectionState.Closed) { conn.Open(); }
                    SqlCommand cmd = new SqlCommand("Insert into Urun(BarkodNo,Kategori,Marka,ÜrünAdı,Miktarı,AlışFiyati,SatisFiyati,Tarih) values(@BarkodNo,@Kategori,@Marka,@ÜrünAdı,@Miktarı,@AlışFiyati,@SatisFiyati,@Tarih)", conn);
                    cmd.Parameters.AddWithValue("@BarkodNo", tbxBarNo.Text);
                    cmd.Parameters.AddWithValue("@Kategori", cbxCate.Text);
                    cmd.Parameters.AddWithValue("@Marka", cbxMarka.Text);
                    cmd.Parameters.AddWithValue("@ÜrünAdı", tbxUrunAdı.Text);
                    cmd.Parameters.AddWithValue("@Miktarı", int.Parse(tbxMiktar.Text));
                    cmd.Parameters.AddWithValue("@AlışFiyati", decimal.Parse(tbxAlFiy.Text));
                    cmd.Parameters.AddWithValue("@SatisFiyati", decimal.Parse(tbxSatFiy.Text));
                    cmd.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    throw;
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) { conn.Close(); }
                    MessageBox.Show("İşlem Başarılı..");
                    cbxMarka.Items.Clear();
                }

            }
            else
            {
                MessageBox.Show("Böyle Bir Barkod Zaten Var...");
            }
            foreach (Control item in gbxYeniUrun.Controls)
            {
                if (item is TextBox || item is ComboBox)
                {
                     item.Text = " ";
                }
            }
            


        }

        private void tbxVBarNo_TextChanged(object sender, EventArgs e)
        {
            if(tbxVBarNo.Text=="")
            {
                label8.Text = "";
                foreach (Control item in gbxVarUrun.Controls)
                {
                    if (item is TextBox)
                    {
                        item.Text ="";
                    }
                }

            }
            if (tbxVBarNo.Text !="") { label8.Text = tbxVMiktar.Text; }



            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Urun where BarkodNo like '" + tbxVBarNo.Text + "'", conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tbxVKat.Text = reader["Kategori"].ToString();
                tbxVMark.Text = reader["Marka"].ToString();
                tbxVUrunAd.Text = reader["ÜrünAdı"].ToString();
                tbxVMiktar.Text = reader["Miktarı"].ToString();
                tbxVAlFİ.Text = reader["AlışFiyati"].ToString();
                tbxVSatFi.Text = reader["SatisFiyati"].ToString();
            }
            conn.Close();
        }

        private void btnVEkle_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Update Urun set Miktarı=Miktarı+'"+int.Parse(tbxVMiktar.Text)+"' where BarkodNo='"+tbxBarNo.Text+"'",conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            foreach (Control item in gbxVarUrun.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
            MessageBox.Show("İşlem Başarılı..");
        }
    }
}
