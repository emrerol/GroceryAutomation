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
    public partial class FrmSatisListeleme : Form
    {
        public FrmSatisListeleme()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=EMRELAPTOP;Initial Catalog=StokTakip;Integrated Security=True");
        DataSet ds = new DataSet();


        private void SatışListele()
        {
            conn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Satış", conn);
            adapter.Fill(ds, "Satış");
            dataGridView1.DataSource = ds.Tables["Satış"];    
            conn.Close();
        }

        private void FrmSatisListeleme_Load(object sender, EventArgs e)
        {
            SatışListele();
        }
    }
}
