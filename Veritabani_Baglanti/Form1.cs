using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Veritabani_Baglanti
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otomasyonDataSet.kullanicilar' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.kullanicilarTableAdapter.Fill(this.otomasyonDataSet.kullanicilar);

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-D95N68Q\\SQLEXPRESS;Initial Catalog=otomasyon;Integrated Security=True");
            if (conn.State == ConnectionState.Closed)
                conn.Open();
            string sorgu = "select * from kullanicilar";
            SqlDataAdapter adp = new SqlDataAdapter(sorgu, conn);
            DataSet ds = new DataSet();
            adp.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
