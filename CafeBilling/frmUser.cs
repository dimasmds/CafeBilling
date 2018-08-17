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

namespace CafeBilling
{
    public partial class frmUser : Form
    {

        SqlConnection connection;
        string connectionString;


        public frmUser()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["CafeBilling.Properties.Settings.cafeConnectionString"].ConnectionString;
        }

        private void populateId()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * From user_data ORDER BY id", connection))
            {
                DataTable tableMenuId = new DataTable();
                adapter.Fill(tableMenuId);
                listBoxId.DisplayMember = "Id";
                listBoxId.ValueMember = "Id";
                listBoxId.DataSource = tableMenuId;
            }

        }

        private void populateUsername()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * From user_data ORDER BY id", connection))
            {
                DataTable tableMenuUsername = new DataTable();
                adapter.Fill(tableMenuUsername);
                listBoxUsername.DisplayMember = "username";
                listBoxUsername.ValueMember = "Id";
                listBoxUsername.DataSource = tableMenuUsername;
            }

        }

        private void populatePassword()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * From user_data ORDER BY id", connection))
            {
                DataTable tableMenuPassword = new DataTable();
                adapter.Fill(tableMenuPassword);
                listBoxPassword.DisplayMember = "password";
                listBoxPassword.ValueMember = "Id";
                listBoxPassword.DataSource = tableMenuPassword;
            }

        }

        private void populateNamaLengkap()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * From user_data ORDER BY id", connection))
            {
                DataTable tableMenuNamaLengkap = new DataTable();
                adapter.Fill(tableMenuNamaLengkap);
                listBoxNamaLengkap.DisplayMember = "nama_lengkap";
                listBoxNamaLengkap.ValueMember = "Id";
                listBoxNamaLengkap.DataSource = tableMenuNamaLengkap;
            }

        }

        private void populateSuperuser()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * From user_data ORDER BY id", connection))
            {
                DataTable tableMenuSuperuser = new DataTable();
                adapter.Fill(tableMenuSuperuser);
                listBoxSuperuser.DisplayMember = "superuser";
                listBoxSuperuser.ValueMember = "Id";
                listBoxSuperuser.DataSource = tableMenuSuperuser;
            }

        }

        private void populateAll()
        {
            populateId();
            populateUsername();
            populatePassword();
            populateNamaLengkap();
            populateSuperuser();
        }

        private void frmUser_Load(object sender, EventArgs e)
        {
            populateAll();

            listBoxId.SelectedItem = null;
            listBoxUsername.SelectedItem = null;
            listBoxPassword.SelectedItem = null;
            listBoxNamaLengkap.SelectedItem = null;
            listBoxSuperuser.SelectedItem = null;

        }

        private void tambahUser()
        {
            string SU;

            if(radioButtonManager.Checked == true)
            {
                SU = "1";
            }
            else
            {
                SU = "0";
            }


            connection = new SqlConnection(connectionString);
            SqlCommand myCmd = new SqlCommand("INSERT INTO user_data VALUES(@Username, @Password, @NamaLengkap, @Superuser)", connection);

            myCmd.Parameters.AddWithValue("Username", textBoxUsername.Text);
            myCmd.Parameters.AddWithValue("Password", textBoxPassword.Text);
            myCmd.Parameters.AddWithValue("NamaLengkap", textBoxNamaLengkap.Text);
            myCmd.Parameters.AddWithValue("Superuser", SU);


            connection.Open();

            myCmd.ExecuteNonQuery();

            populateAll();
        }

        /*---------------------MISC----------------------
        --------------------AVOID SELECTED---------------*/

        private void listBoxUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxUsername.SelectedItem = null;
        }

        private void listBoxPassword_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxPassword.SelectedItem = null;
        }

        private void listBoxNamaLengkap_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxNamaLengkap.SelectedItem = null;
        }

        private void listBoxSuperuser_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxSuperuser.SelectedItem = null;
        }

        private void tambahClick(object sender, EventArgs e)
        {
            if (textBoxUsername.Text != "" && textBoxPassword.Text != "" && textBoxNamaLengkap.Text != "")
                tambahUser();
            else
                MessageBox.Show("Harap isi dengan lengkap");
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            hapusUser();
        }

        private void hapusUser()
        {
            connection = new SqlConnection(connectionString);
            SqlCommand myCmd = new SqlCommand("DELETE FROM user_data WHERE Id=@id", connection);

            myCmd.Parameters.AddWithValue("@id", listBoxId.Text);
            connection.Open();
            myCmd.ExecuteNonQuery();

            populateAll();
        }
    }
}
