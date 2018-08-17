using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace CafeBilling
{
    public partial class frmTrans : Form
    {
        SqlConnection connection;
        string connectionString;

        public frmTrans()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CafeBilling.Properties.Settings.cafeConnectionString"].ConnectionString;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter("SELECT transdetail_id, tanggal, jam, total FROM transaksi_master where tanggal = @Tanggal", connection);
            sda.SelectCommand.Parameters.AddWithValue("Tanggal", dateTimePicker1.Value.ToShortDateString());

            DataTable dt = new DataTable();
            connection.Open();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string transid = dataGridView1.SelectedCells[0].Value.ToString();

            frmPreviewTrans FromPrev = new frmPreviewTrans();
            FromPrev.transId = transid;
            FromPrev.Show();
        }
    }
}
