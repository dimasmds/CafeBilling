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
using System.Configuration;
using Microsoft.VisualBasic;

namespace CafeBilling
{
    public partial class frmLogin : Form
    {

        SqlConnection connection;
        string connectionString;

        string _username;
        string _password;
        string _superuser;

        public string Superuser
        {
            get
            {
                return _superuser;
            }

            set
            {
                _superuser = value;
            }
        }

        public frmLogin()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CafeBilling.Properties.Settings.cafeConnectionString"].ConnectionString;
        }

        private void doLogin()
        {
            connection = new SqlConnection(connectionString);
            SqlCommand myCmd = new SqlCommand("SELECT * FROM user_data where username=@Username and password=@Password", connection);

            myCmd.Parameters.AddWithValue("Username", textBoxUsername.Text);
            myCmd.Parameters.AddWithValue("Password", textBoxPassword.Text);

            SqlDataReader Reader = null;

            connection.Open();
            Reader = myCmd.ExecuteReader();

            while (Reader.Read())
            {
                _username = Reader["username"].ToString();
                _password = Reader["password"].ToString();
                Superuser = Reader["superuser"].ToString();
            }

            if(_username == textBoxUsername.Text && _password == textBoxPassword.Text)
            {
                s myMainForm = new s();
                myMainForm.LabelTextUser = _username;
                myMainForm.lastTrans = Interaction.InputBox("Masukan No Transaksi Terakhir", "Input Transaksi", "1").ToString();
                myMainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Gagal !");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            doLogin();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
        }
    }
}
