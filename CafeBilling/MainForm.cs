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
using System.Drawing.Printing;

namespace CafeBilling
{
    public partial class s : Form
    {
        SqlConnection connection;
        string connectionString;
        private decimal _nhargaTotal = 0;

        DateTime myDateTime = DateTime.Now;

        public s()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CafeBilling.Properties.Settings.cafeConnectionString"].ConnectionString;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            checkSuperuser();
            labelHari.Text = myDateTime.DayOfWeek.ToString();
            labelTanggal.Text = myDateTime.Date.ToLongDateString();
            enableButtonKeranjang(false);

            RefreshAll();
        }

        private void populateMakanan()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * From master_menu where kategori='Makanan' ORDER BY nama", connection))
            {
                DataTable tableMenuMakanan = new DataTable();
                adapter.Fill(tableMenuMakanan);
                listBoxMakanan.DisplayMember = "Nama";
                listBoxMakanan.ValueMember = "Id";
                listBoxMakanan.DataSource = tableMenuMakanan;
            }
        }

        private void populateMinuman()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("SELECT * From master_menu where kategori='Minuman' ORDER BY nama", connection))
            {
                DataTable tableMenuMakanan = new DataTable();
                adapter.Fill(tableMenuMakanan);
                listBoxMinuman.DisplayMember = "Nama";
                listBoxMinuman.ValueMember = "Id";
                listBoxMinuman.DataSource = tableMenuMakanan;
            }
        }

        private void addToKeranjang()
        {
            enableButtonKeranjang(true);

            string Harga = "";
            string Makanan = "";
            string Q = "";

            connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand myCmd;

            if (tabControl1.SelectedTab == tabControl1.TabPages["Tabpage1"])
            {
                listBoxMinuman.SelectedItem = null;
                myCmd = new SqlCommand(String.Format("SELECT harga, nama FROM master_menu where id={0}", listBoxMakanan.SelectedValue), connection);
            }
            else
            {
                listBoxMakanan.SelectedItem = null;
                myCmd = new SqlCommand(String.Format("SELECT harga, nama FROM master_menu where id={0}", listBoxMinuman.SelectedValue), connection);
            }
        

            SqlDataReader myReader = null;
            myReader = myCmd.ExecuteReader();
            while (myReader.Read())
            {
                Harga = myReader["harga"].ToString();
                Makanan = myReader["nama"].ToString();
            }

            
            Q = Interaction.InputBox("Banyak Item", "Input Quantity", "1").ToString();
            listBoxQ.Items.Add(Q);
            listBoxKeranjangMakanan.Items.Add(Makanan);
            try {
                listBoxKeranjangHarga.Items.Add((Double.Parse(Harga) * Double.Parse(Q)).ToString());
            }
            catch
            {
                int i = listBoxKeranjangMakanan.Items.Count - 1;
                listBoxKeranjangMakanan.Items.RemoveAt(i);
                listBoxQ.Items.RemoveAt(i);
            }

            hitungTotal();

            try {
                saveToDB(textBoxNoTransaksi.Text, listBoxMakanan.SelectedValue.ToString(), Q, Harga);
            }
            catch
            {
                saveToDB(textBoxNoTransaksi.Text, listBoxMinuman.SelectedValue.ToString(), Q, Harga);
            }

        }

        private void addToKeranjangButton(object sender, EventArgs e)
        {
            addToKeranjang();
        }

       

        private void hitungTotal()
        {
            _nhargaTotal = 0;
            for (int i = 0; i < listBoxKeranjangHarga.Items.Count; i++)
            {
                _nhargaTotal += Decimal.Parse(listBoxKeranjangHarga.Items[i].ToString());
            }

            labelHargaTotal.Text = _nhargaTotal.ToString("C");

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxKeranjangHarga.Items.Clear();
            listBoxKeranjangMakanan.Items.Clear();
            listBoxQ.Items.Clear();
            _nhargaTotal = 0;
            labelHargaTotal.Text = "0";
            enableButtonKeranjang(false);
            clearAllTrans();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            int i = listBoxKeranjangMakanan.SelectedIndex;
            removeFromDB(textBoxNoTransaksi.Text, listBoxKeranjangMakanan.Text);

            try {
                listBoxKeranjangMakanan.Items.RemoveAt(i);
                listBoxQ.Items.RemoveAt(i);
                listBoxKeranjangHarga.Items.RemoveAt(i);
            }
            catch
            {
                MessageBox.Show("Pilih Item untuk di Hapus !");
            }
            

            if (listBoxKeranjangMakanan.Items.Count == 0)
            {
                enableButtonKeranjang(false);
            }

            hitungTotal();


        }

        private void listBoxMakanan_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                addToKeranjang();
            }
        }

        private void listBoxMinuman_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                addToKeranjang();
            }
        }


        /* --------------------------------------MISC -------------------------------------
        ____________________________________________________________________________________
        --------------------------Agar Textbox tidak dapat di pilih------------------------*/


        private void listBoxKeranjangHarga_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxKeranjangHarga.SelectedItem = null;
        }

        private void listBoxQ_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxQ.SelectedItem = null;
        }

        private void enableButtonKeranjang(bool e)
        {
            buttonClear.Enabled = e;
            button3.Enabled = e;
            button4.Enabled = e;
            buttonRemove.Enabled = e;
        }

        private void mgntMenu(object sender, EventArgs e)
        {
            frmMenu FromMenu = new frmMenu();
            FromMenu.Show();
        }

        private void RefeshMenu(object sender, EventArgs e)
        {
            RefreshAll();
        }

        private void settingNamaCafeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCafe FromCafe = new frmCafe();
            FromCafe.Show();
        }

        private void RefreshAll()
        {
            populateMakanan();
            populateMinuman();
            refreshCafe();
        }

        private void refreshCafe()
        {
            connection = new SqlConnection(connectionString);
            SqlCommand myCmd = new SqlCommand("SELECT nama, alamat, no_telp FROM identitas_cafe", connection);
            SqlDataReader Reader = null;

            connection.Open();

            Reader = myCmd.ExecuteReader();

            while (Reader.Read())
            {
                labelNamaCafe.Text = Reader["nama"].ToString();
                labelAlamat.Text = Reader["alamat"].ToString();
            }
        }

        private void managementUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser FromUser = new frmUser();

            FromUser.Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        public string LabelTextUser
        {
            get
            {
                return this.labelUser.Text;
            }
            set
            {
                this.labelUser.Text = value;
            }
        }

        private void checkSuperuser()
        {
            string _superuser = "";

            connection = new SqlConnection(connectionString);
            SqlCommand myCmd = new SqlCommand("SELECT superuser FROM user_data where username=@Username", connection);

            myCmd.Parameters.AddWithValue("Username", labelUser.Text);

            SqlDataReader Reader = null;

            connection.Open();

            Reader = myCmd.ExecuteReader();

            while (Reader.Read())
            {
                _superuser = Reader["superuser"].ToString();
            }

            if(_superuser[0] == '1')
            {
                configurationToolStripMenuItem.Enabled = true;
            }
            else
            {
                configurationToolStripMenuItem.Enabled = false;
            }

        }

        private void saveToDB(string Trans_detail_id, string Menu_id, string Quantity, string harga)
        {
            connection = new SqlConnection(connectionString);
            SqlCommand myCmd = new SqlCommand("INSERT INTO trans_detail VALUES(@Trans_detail_Id, @Menu_Id, @Quantity, @Harga)", connection);

            decimal nhargaTotal = 0;
            decimal nHarga = decimal.Parse(harga);
            int nQ;
            int.TryParse(Quantity, out nQ);

            nhargaTotal = nHarga * nQ;
            

            myCmd.Parameters.AddWithValue("Trans_detail_Id", Trans_detail_id);
            myCmd.Parameters.AddWithValue("Menu_id", Menu_id);
            myCmd.Parameters.AddWithValue("Quantity", Quantity);
            myCmd.Parameters.AddWithValue("Harga", nhargaTotal.ToString());

            connection.Open();

            myCmd.ExecuteNonQuery();
        }

        private void removeFromDB(string transdetail, string Nama)
        {
            string _nama = getIdFromNama(Nama);
            connection = new SqlConnection(connectionString);
            SqlCommand myCmd = new SqlCommand("DELETE FROM trans_detail WHERE trans_detail_id = @Transdetail AND menu_id = @MenuId", connection);

            myCmd.Parameters.AddWithValue("Transdetail", transdetail);
            myCmd.Parameters.AddWithValue("MenuId", _nama);

            connection.Open();
            myCmd.ExecuteNonQuery();
        }

        private string getIdFromNama(string nama)
        {
            string _nama = "";

            connection = new SqlConnection(connectionString);
            SqlCommand myCmd = new SqlCommand("SELECT Id from master_menu where nama = @Nama", connection);

            myCmd.Parameters.AddWithValue("Nama", nama);

            SqlDataReader Reader = null;

            connection.Open();
            Reader = myCmd.ExecuteReader();
            while (Reader.Read())
            {
                _nama = Reader["Id"].ToString();
            }

            return _nama;

        }

        private void clearAllTrans()
        {
            connection = new SqlConnection(connectionString);
            SqlCommand myCmd = new SqlCommand("DELETE FROM trans_detail WHERE trans_detail_id =  @TransdetailId", connection);

            myCmd.Parameters.AddWithValue("TransdetailId", textBoxNoTransaksi.Text);

            connection.Open();
            myCmd.ExecuteNonQuery();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(button3.Text == "&Save")
            {
                tabControl1.Visible = false;
                button1.Visible = false;
                button3.Text = "Baru";
                buttonClear.Enabled = false;
                buttonRemove.Enabled = false;
                saveTrans();
                PreviewReceipt();
            }
            else
            {
                int notrans = int.Parse(textBoxNoTransaksi.Text);
                notrans++;
                textBoxNoTransaksi.Text = notrans.ToString();
                button3.Enabled = true;
                tabControl1.Visible = true;
                button1.Visible = true;
                listBoxKeranjangHarga.Items.Clear();
                listBoxKeranjangMakanan.Items.Clear();
                listBoxQ.Items.Clear();
                buttonClear.Enabled = true;
                buttonRemove.Enabled = true;


                button3.Text = "&Save";
            }
           
        }


        public string lastTrans
        {
            get
            {
                return textBoxNoTransaksi.Text;
            }
            set
            {
                textBoxNoTransaksi.Text = value;
            }
        }

        private void saveTrans()
        {
            connection = new SqlConnection(connectionString);
            SqlCommand myCmd = new SqlCommand("INSERT INTO transaksi_master VALUES(@TransDetailId, @Tanggal, @Jam, @TotalHarga)", connection);

            string Date = DateTime.Now.ToShortDateString();
            string jam = "";

            if(DateTime.Now.Hour < 10)
            {
                jam += "0" + DateTime.Now.Hour.ToString();
            }
            else
            {
                jam += DateTime.Now.Hour.ToString();
            }
            jam += ":";

            if (DateTime.Now.Minute < 10)
            {
                jam += "0" + DateTime.Now.Minute.ToString();
            }
            else
            {
                jam += DateTime.Now.Minute.ToString();
            }
            jam += ":";

            if (DateTime.Now.Second < 10)
            {
                jam += "0" + DateTime.Now.Second.ToString();
            }
            else
            {
                jam += DateTime.Now.Second.ToString();
            }

            myCmd.Parameters.AddWithValue("TransDetailId", textBoxNoTransaksi.Text);
            myCmd.Parameters.AddWithValue("Tanggal", Date);
            myCmd.Parameters.AddWithValue("Jam", jam);
            myCmd.Parameters.AddWithValue("TotalHarga", _nhargaTotal.ToString());

            connection.Open();

            myCmd.ExecuteNonQuery();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocumentOnPrintPage;
            printDocument.Print();
        }

        private void PreviewReceipt()
        {
            textBoxReceipt.Text = "";
            string namaCafe = "";
            string alamatCafe = "";
            string telpCafe = "";
            string emailCafe = "";
            string websiteCafe = "";
            string jam = "";

            if (DateTime.Now.Hour < 10)
            {
                jam += "0" + DateTime.Now.Hour.ToString();
            }
            else
            {
                jam += DateTime.Now.Hour.ToString();
            }
            jam += ":";

            if (DateTime.Now.Minute < 10)
            {
                jam += "0" + DateTime.Now.Minute.ToString();
            }
            else
            {
                jam += DateTime.Now.Minute.ToString();
            }
            jam += ":";

            if (DateTime.Now.Second < 10)
            {
                jam += "0" + DateTime.Now.Second.ToString();
            }
            else
            {
                jam += DateTime.Now.Second.ToString();
            }

            connection = new SqlConnection(connectionString);
            SqlCommand myCmd = new SqlCommand("SELECT * FROM identitas_cafe", connection);
            SqlDataReader Reader = null;

            connection.Open();

            Reader = myCmd.ExecuteReader();

            while (Reader.Read())
            {
                namaCafe = Reader["nama"].ToString();
                alamatCafe = Reader["alamat"].ToString();
                telpCafe = Reader["no_telp"].ToString();
                emailCafe = Reader["email"].ToString();
                websiteCafe = Reader["website"].ToString();
            }

            textBoxReceipt.AppendText("\t\t" + namaCafe + Environment.NewLine + Environment.NewLine);
            textBoxReceipt.AppendText("\t" + alamatCafe + Environment.NewLine);
            textBoxReceipt.AppendText("--------------------------------------------" + Environment.NewLine);
            textBoxReceipt.AppendText("Transaksi: " + textBoxNoTransaksi.Text + "\t\t" + DateTime.Now.ToShortDateString() + " " + jam + Environment.NewLine + Environment.NewLine);
            textBoxReceipt.AppendText("Nama Item\tQ\tHarga" + Environment.NewLine + Environment.NewLine);

            for (int i = 0; i < listBoxKeranjangMakanan.Items.Count; i++)
            {
                textBoxReceipt.AppendText(listBoxKeranjangMakanan.Items[i].ToString() + "\t" + listBoxQ.Items[i].ToString() + "\t"
                    + listBoxKeranjangHarga.Items[i].ToString());
                textBoxReceipt.AppendText(Environment.NewLine); 
            }
            textBoxReceipt.AppendText("--------------------------------------------" + Environment.NewLine);
            textBoxReceipt.AppendText("Total Harga:\t\t" + labelHargaTotal.Text + Environment.NewLine);
            textBoxReceipt.AppendText("--------------------------------------------" + Environment.NewLine);
            textBoxReceipt.AppendText("========== K o n t a k   K a m i ==========" + Environment.NewLine + Environment.NewLine);
            textBoxReceipt.AppendText("Telp: " + telpCafe + Environment.NewLine);
            textBoxReceipt.AppendText("Email: " + emailCafe + Environment.NewLine);
            textBoxReceipt.AppendText("Website: " + websiteCafe + Environment.NewLine);
            textBoxReceipt.AppendText(Environment.NewLine);
            textBoxReceipt.AppendText("========== T e r i m a k a s i h ==========" + Environment.NewLine);


        }

        private void PrintDocumentOnPrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(this.textBoxReceipt.Text, this.textBoxReceipt.Font, Brushes.Black, 10, 25);
        }

        private void historyTransaksiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrans FromTrans = new frmTrans();
            FromTrans.Show();
        }

        private void labelUser_Click(object sender, EventArgs e)
        {

        }
    }
}
