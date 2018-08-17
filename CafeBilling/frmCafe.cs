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
    public partial class frmCafe : Form
    {
        SqlConnection connection;
        string connectionString;

        public frmCafe()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CafeBilling.Properties.Settings.cafeConnectionString"].ConnectionString;
        }

        private void populateCafe()
        {
            connection = new SqlConnection(connectionString);
            SqlCommand myCmd = new SqlCommand("SELECT * FROM identitas_cafe", connection);
            SqlDataReader Reader = null;

            connection.Open();

            Reader = myCmd.ExecuteReader();

            while (Reader.Read())
            {
                textBoxNama.Text = Reader["nama"].ToString();
                textBoxAlamat.Text = Reader["alamat"].ToString();
                textBoxNo_Telp.Text = Reader["no_telp"].ToString();
                textBoxEmail.Text = Reader["email"].ToString();
                textBoxWebsite.Text = Reader["website"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmCafe_Load(object sender, EventArgs e)
        {
            populateCafe();


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            SqlCommand myCmd = new SqlCommand("UPDATE identitas_cafe SET nama=@Nama, alamat=@Alamat, no_telp=@NomorTelp, email=@Email, website=@Website", connection);

            myCmd.Parameters.AddWithValue("Nama", textBoxNama.Text);
            myCmd.Parameters.AddWithValue("Alamat", textBoxAlamat.Text);
            myCmd.Parameters.AddWithValue("NomorTelp", textBoxNo_Telp.Text);
            myCmd.Parameters.AddWithValue("Email", textBoxEmail.Text);
            myCmd.Parameters.AddWithValue("Website", textBoxWebsite.Text);

            connection.Open();

            myCmd.ExecuteNonQuery();

            MessageBox.Show("Data berhasil di update");
            populateCafe();
            this.Close();
        }
    }
}
