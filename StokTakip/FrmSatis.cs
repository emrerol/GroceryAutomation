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
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=EMRELAPTOP;Initial Catalog=StokTakip;Integrated Security=True");
        DataSet ds = new DataSet();
        private void SepetListele()
        {
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Sepet", conn);
            adapter.Fill(ds, "Sepet");
            dataGridView.DataSource = ds.Tables["Sepet"];
            dataGridView.Columns[0].Visible = false;
            dataGridView.Columns[1].Visible = false;
            dataGridView.Columns[2].Visible = false;
            conn.Close();
        }
        
            
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(tbxTC.Text=="")
            {
                tbxAdSoy.Clear();
                tbxTelefon.Clear();
            }

            try
            {
                if(conn.State==ConnectionState.Closed) { conn.Open(); }
                SqlCommand cmd = new SqlCommand("Select * from Musteri Where TC like '" + tbxTC.Text + "'",conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    tbxAdSoy.Text = reader["AdSoyad"].ToString();
                    tbxTelefon.Text = reader["Telefon"].ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if(conn.State==ConnectionState.Open) { conn.Close(); }
            }


        }




        private void btnMusEkle_Click(object sender, EventArgs e)
        {
            FrmMustEkle ekle = new FrmMustEkle();
            ekle.ShowDialog();
        }

        private void btnMusList_Click(object sender, EventArgs e)
        {
            FrmMusListele list = new FrmMusListele();
            list.ShowDialog();
        }

        private void btnUrunEkle_Click(object sender, EventArgs e)
        {
            FrmUrunEkle ekle = new FrmUrunEkle();
            ekle.ShowDialog();
        }

        private void btnMarka_Click(object sender, EventArgs e)
        {
            FrmMarka marka = new FrmMarka();
            marka.ShowDialog();
        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            FrmKategori kategori = new FrmKategori();
            kategori.ShowDialog();
        }

        private void btnUrunList_Click(object sender, EventArgs e)
        {
            FrmUrunListele listele = new FrmUrunListele();
            listele.ShowDialog();
        }

        private void Calculate()
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Select sum(ToplamFiyati) from Sepet",conn);
                lblGenTop.Text = cmd.ExecuteScalar() + "TL";
                conn.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            SepetListele();
        }

        private void tbxBarNo_TextChanged(object sender, EventArgs e)
        {
            Temizle();

            try
            {
                if (conn.State == ConnectionState.Closed) { conn.Open(); }
                SqlCommand cmd = new SqlCommand("Select * from Urun Where BarkodNo like '" + tbxBarNo.Text + "'", conn);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    tbxUrunAd.Text = reader["ÜrünAdı"].ToString();
                    tbxSatFi.Text = reader["SatisFiyati"].ToString();

                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) { conn.Close(); }
            }
        }

        private void Temizle()
        {
            if (tbxBarNo.Text == "")
            {
                foreach (Control item in groupBox2.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != tbxMiktar)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
        }

        bool situation;
        
        private void BarcodeControl()
        {
            situation = true;
            conn.Open();
            SqlCommand cmd = new SqlCommand(" Select * from Sepet",conn);
            SqlDataReader read = cmd.ExecuteReader();
            while (read.Read())
            {
                if (tbxBarNo.Text == read["BarkodNo"].ToString())
                {
                    situation = false;

                }
            }
            conn.Close();

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            BarcodeControl();
            if (situation==true)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into Sepet(TC,AdSoyad,Telefon,ÜrünAdı,BarkodNo,Miktari,SatisFiyati,ToplamFiyati,Tarih) values(@TC,@AdSoyad,@Telefon,@ÜrünAdı,@BarkodNo,@Miktari,@SatisFiyati,@ToplamFiyati,@Tarih) ", conn);
                cmd.Parameters.AddWithValue("@TC", tbxTC.Text);
                cmd.Parameters.AddWithValue("@AdSoyad", tbxAdSoy.Text);
                cmd.Parameters.AddWithValue("@Telefon", tbxTelefon.Text);
                cmd.Parameters.AddWithValue("@ÜrünAdı", tbxUrunAd.Text);
                cmd.Parameters.AddWithValue("@BarkodNo", tbxBarNo.Text);
                cmd.Parameters.AddWithValue("@Miktari", int.Parse(tbxMiktar.Text));
                cmd.Parameters.AddWithValue("@SatisFiyati", decimal.Parse(tbxSatFi.Text));
                cmd.Parameters.AddWithValue("@ToplamFiyati", decimal.Parse(tbxTopFiy.Text));
                cmd.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            else
            {
                conn.Open();  
                SqlCommand cmd2 = new SqlCommand(" Update Sepet set Miktari=Miktari+'"+int.Parse(tbxMiktar.Text)+ "' Where BarkodNo='" + tbxBarNo.Text + "'" , conn);
                cmd2.ExecuteNonQuery();
                SqlCommand cmd3 = new SqlCommand(" Update Sepet set ToplamFiyati=Miktari*SatisFiyati Where BarkodNo='"+tbxBarNo.Text+"'", conn);
                cmd3.ExecuteNonQuery();



                conn.Close();
            }
            
            
            ds.Tables["Sepet"].Clear();
            tbxMiktar.Text = "1";            
            SepetListele();
            Calculate();
        }

        private void tbxMiktar_TextChanged(object sender, EventArgs e)
        {
           
            try
            {
                tbxTopFiy.Text = (decimal.Parse(tbxMiktar.Text) * decimal.Parse(tbxSatFi.Text)).ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tbxSatFi_TextChanged(object sender, EventArgs e)
        {
            try
            {
                tbxTopFiy.Text = (decimal.Parse(tbxMiktar.Text) * decimal.Parse(tbxSatFi.Text)).ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from Sepet Where BarkodNo='" + dataGridView.CurrentRow.Cells["BarkodNo"].Value.ToString() + "'", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            
            MessageBox.Show("Ürün Sepetten Çıkarıldı");
            ds.Tables["Sepet"].Clear();
            SepetListele();
            Calculate();
        }

        private void btnSatİp_Click(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("Delete from Sepet ", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            
            MessageBox.Show("Ürün Sepetten Çıkarıldı");
            ds.Tables["Sepet"].Clear();
            SepetListele();
            Calculate();
        }

        private void btnSatList_Click(object sender, EventArgs e)
        {
            FrmSatisListeleme satisListeleme = new FrmSatisListeleme();
            satisListeleme.ShowDialog();
        }

        private void btnSatYap_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < dataGridView.Rows.Count-1; i++)
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into Sepet(TC,AdSoyad,Telefon,ÜrünAdı,BarkodNo,Miktari,SatisFiyati,ToplamFiyati,Tarih) values(@TC,@AdSoyad,@Telefon,@ÜrünAdı,@BarkodNo,@Miktari,@SatisFiyati,@ToplamFiyati,@Tarih) ", conn);
                cmd.Parameters.AddWithValue("@TC", tbxTC.Text);
                cmd.Parameters.AddWithValue("@AdSoyad", tbxAdSoy.Text);
                cmd.Parameters.AddWithValue("@Telefon", tbxTelefon.Text);
                cmd.Parameters.AddWithValue("@ÜrünAdı", dataGridView.Rows[i].Cells["ÜrünAdı"].Value.ToString());
                cmd.Parameters.AddWithValue("@BarkodNo", dataGridView.Rows[i].Cells["BarkodNo"].Value.ToString());
                cmd.Parameters.AddWithValue("@Miktari", int.Parse(dataGridView.Rows[i].Cells["Miktari"].Value.ToString()));
                cmd.Parameters.AddWithValue("@SatisFiyati", decimal.Parse(dataGridView.Rows[i].Cells["SatisFiyati"].Value.ToString()));
                cmd.Parameters.AddWithValue("@ToplamFiyati", decimal.Parse(dataGridView.Rows[i].Cells["ToplamFiyati"].Value.ToString()));
                cmd.Parameters.AddWithValue("@Tarih", DateTime.Now.ToString());
                cmd.ExecuteNonQuery();
                conn.Close();
                conn.Open();
                SqlCommand cmd2 = new SqlCommand("Update Urun set Miktarı=Miktarı-'" + int.Parse(dataGridView.Rows[i].Cells["Miktari"].Value.ToString()) + "' where BarkodNo='" + dataGridView.Rows[i].Cells["BarkodNo"].Value.ToString() + "'", conn);
                cmd2.ExecuteNonQuery();
                conn.Close();
            }

            conn.Open();
            SqlCommand cmd3 = new SqlCommand("Delete from Sepet ", conn);
            cmd3.ExecuteNonQuery();
            conn.Close();
            ds.Tables["Sepet"].Clear();         
            SepetListele();
            Calculate();
        }
    }
}
