using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CafeBilling
{
    public partial class frmMenu : Form
    {
        SqlConnection connection;
        string connectionString;

        public frmMenu()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CafeBilling.Properties.Settings.cafeConnectionString"].ConnectionString;
        }

        private void populateId()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * From master_menu ORDER BY id", connection))
            {
                DataTable tableMenuId = new DataTable();
                adapter.Fill(tableMenuId);
                listBoxId.DisplayMember = "Id";
                listBoxId.ValueMember = "Id";
                listBoxId.DataSource = tableMenuId;
            }
        }

        private void populateNama()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * From master_menu ORDER BY id", connection))
            {
                DataTable tableMenuNama = new DataTable();
                adapter.Fill(tableMenuNama);
                listBoxNama.DisplayMember = "Nama";
                listBoxNama.ValueMember = "Id";
                listBoxNama.DataSource = tableMenuNama;
            }
        }

        private void populateHarga()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * From master_menu ORDER BY id", connection))
            {
                DataTable tableMenuHarga = new DataTable();
                adapter.Fill(tableMenuHarga);
                listBoxHarga.DisplayMember = "harga";
                listBoxHarga.ValueMember = "Id";
                listBoxHarga.DataSource = tableMenuHarga;
            }
        }

        private void populateKategori()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * From master_menu ORDER BY id", connection))
            {
                DataTable tableMenuKategori = new DataTable();
                adapter.Fill(tableMenuKategori);
                listBoxKategori.DisplayMember = "kategori";
                listBoxKategori.ValueMember = "Id";
                listBoxKategori.DataSource = tableMenuKategori;
            }
        }



        private void frmMenu_Load(object sender, EventArgs e)
        {
            populateId();
            populateNama();
            populateHarga();
            populateKategori();

            listBoxId.SelectedItem = null;
            listBoxNama.SelectedItem = null;
            listBoxHarga.SelectedItem = null;
            listBoxKategori.SelectedItem = null;
        }

        private void tambahMenu()
        {
            string query = "INSERT INTO master_menu VALUES(@Nama, @Harga, @Kategori)";

            connection = new SqlConnection(connectionString);
            SqlCommand myCmd = new SqlCommand(query, connection);
            connection.Open();

            myCmd.Parameters.AddWithValue("@Nama", textBoxNama.Text);
            myCmd.Parameters.AddWithValue("@Harga", textBoxHarga.Text);
            myCmd.Parameters.AddWithValue("@Kategori", textBoxKategori.Text);

            myCmd.ExecuteNonQuery();
            
        }


        /* --------------------------------------MISC -------------------------------------
         ____________________________________________________________________________________
         --------------------------Agar Textbox tidak dapat di pilih------------------------*/
        private void listBoxNama_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxNama.SelectedItem = null;
        }

        private void listBoxHarga_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxHarga.SelectedItem = null;
        }

        private void listBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxKategori.SelectedItem = null;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            tambahMenu();
            PopulateAll();

            ClearField();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            string snama = "";
            string sharga = "";
            string skategori = "";

            if(buttonEdit.Text == "Edit")
            {
                string query = String.Format("SELECT nama, harga, kategori FROM master_menu WHERE Id={0}", listBoxId.SelectedValue.ToString());

                connection = new SqlConnection(connectionString);
                SqlCommand mycmd = new SqlCommand(query, connection);
                SqlDataReader reader = null;
                connection.Open();
                reader = mycmd.ExecuteReader();

                while (reader.Read())
                {
                    snama = reader["nama"].ToString();
                    sharga = reader["harga"].ToString();
                    skategori = reader["kategori"].ToString();
                }

                textBoxNama.Text = snama;
                textBoxHarga.Text = sharga;
                textBoxKategori.Text = skategori;

                buttonEdit.Text = "Simpan";
            }
            else
            {
                string query = "UPDATE master_menu set nama=@Nama, harga=@harga, kategori=@Kategori where Id=@id";

                connection = new SqlConnection(connectionString);
                SqlCommand myCmd = new SqlCommand(query, connection);

                myCmd.Parameters.AddWithValue("Nama", textBoxNama.Text);
                myCmd.Parameters.AddWithValue("Harga", textBoxHarga.Text);
                myCmd.Parameters.AddWithValue("Kategori", textBoxKategori.Text);
                myCmd.Parameters.AddWithValue("id", listBoxId.SelectedValue.ToString());

                connection.Open();

                myCmd.ExecuteNonQuery();

                PopulateAll();
                buttonEdit.Text = "Edit";
                ClearField();

            }
            

        }

        private void updateMenu()
        {
            
            string query = "UPDATE master_menu set nama=@Nama, harga=@harga, kategori=@Kategori where Id=@id";

            connection = new SqlConnection(connectionString);
            SqlCommand myCmd = new SqlCommand(query, connection);
            connection.Open();
            
        }

        private void PopulateAll()
        {
            populateId();
            populateNama();
            populateHarga();
            populateKategori();
        }

        private void ClearField()
        {
            textBoxNama.Text = "";
            textBoxHarga.Text = "";
            textBoxKategori.Text = "";
        }

        private void listBoxId_DoubleClick(object sender, EventArgs e)
        {
            string snama = "";
            string sharga = "";
            string skategori = "";

            if (buttonEdit.Text == "Edit")
            {
                string query = String.Format("SELECT nama, harga, kategori FROM master_menu WHERE Id={0}", listBoxId.SelectedValue.ToString());

                connection = new SqlConnection(connectionString);
                SqlCommand mycmd = new SqlCommand(query, connection);
                SqlDataReader reader = null;

                connection.Open();

                reader = mycmd.ExecuteReader();

                while (reader.Read())
                {
                    snama = reader["nama"].ToString();
                    sharga = reader["harga"].ToString();
                    skategori = reader["kategori"].ToString();
                } 

                textBoxNama.Text = snama;
                textBoxHarga.Text = sharga;
                textBoxKategori.Text = skategori;

                buttonEdit.Text = "&Simpan";
            }
            else
            {
                ClearField();
                buttonEdit.Text = "Edit";
            }
        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {
            connection = new SqlConnection(connectionString);
            SqlCommand myCmd = new SqlCommand("DELETE FROM master_menu WHERE Id=@id", connection);
            myCmd.Parameters.AddWithValue("@id", listBoxId.Text);

            connection.Open();
            myCmd.ExecuteNonQuery();
            PopulateAll();
        }
    }
}
