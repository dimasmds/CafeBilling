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
using System.Drawing.Printing;

namespace CafeBilling
{
    public partial class frmPreviewTrans : Form
    {
        List<string> ListmenuId = new List<string>();
        List<string> namaItem = new List<string>();
        List<string> quantity = new List<string>();
        List<string> harga = new List<string>();

        string tanggal;
        string jam;
        string total;
        public string transId { get; set; }

        string nama;
        string alamat;
        string no_tlp;
        string email;
        string website;

        string connectionString;
        SqlConnection connection;

        public frmPreviewTrans()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["CafeBilling.Properties.Settings.cafeConnectionString"].ToString();
        }

        private void frmPreviewTrans_Load(object sender, EventArgs e)
        {
            populateKerjangan();
            getDateTime();
            getNamaCafe();
            PreviewReceipt();
        }

        private void getNamaCafe()
        {
            connection = new SqlConnection(connectionString);
            SqlCommand myCmd = new SqlCommand("SELECT * FROM identitas_cafe", connection);
            SqlDataReader Reader = null;
            connection.Open();
            Reader = myCmd.ExecuteReader();

            while (Reader.Read())
            {
                nama = Reader["nama"].ToString();
                alamat = Reader["alamat"].ToString();
                no_tlp = Reader["no_telp"].ToString();
                email = Reader["email"].ToString();
                website = Reader["website"].ToString();
            }
        }

        private void populateKerjangan()
        {
            connection = new SqlConnection(connectionString);
            SqlCommand myCmd = new SqlCommand("SELECT menu_id, quantity, harga FROM trans_detail where trans_detail_id = @TransDetailId", connection);
            myCmd.Parameters.AddWithValue("TransDetailId", transId);
            SqlDataReader Reader = null;

            connection.Open();

            Reader = myCmd.ExecuteReader();

            while (Reader.Read())
            {
                ListmenuId.Add(Reader["menu_id"].ToString());
                quantity.Add(Reader["quantity"].ToString());
                harga.Add(Reader["harga"].ToString());
            }

            for(int i = 0; i < ListmenuId.Count(); i++)
            {
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand myCmd1 = new SqlCommand("SELECT nama FROM master_menu WHERE Id = @menuId", con);
                myCmd1.Parameters.AddWithValue("menuId", ListmenuId[i]);
                SqlDataReader Reader1 = null;
                con.Open();
                Reader1 = myCmd1.ExecuteReader();

                while (Reader1.Read())
                {
                    namaItem.Add(Reader1["nama"].ToString());
                }
            }
        }

        private void getDateTime()
        {
            connection = new SqlConnection(connectionString);
            SqlCommand myCmd = new SqlCommand("SELECT tanggal, jam, total FROM transaksi_master WHERE transdetail_id = @TransId", connection);
            myCmd.Parameters.AddWithValue("TransId", transId);
            SqlDataReader Reader = null;

            connection.Open();

            Reader = myCmd.ExecuteReader();

            while (Reader.Read())
            {
                tanggal = Reader["tanggal"].ToString();
                jam = Reader["jam"].ToString();
                total = Reader["total"].ToString();
            }

        }
        private void PreviewReceipt()
        {
            

            textBoxReceipt.AppendText("\t\t" + nama + Environment.NewLine + Environment.NewLine);
            textBoxReceipt.AppendText("\t" + alamat + Environment.NewLine);
            textBoxReceipt.AppendText("--------------------------------------------" + Environment.NewLine);
            textBoxReceipt.AppendText("Transaksi: " + transId + "\t\t" + tanggal + " " + jam + Environment.NewLine + Environment.NewLine);
            textBoxReceipt.AppendText("Nama Item\tQ\tHarga" + Environment.NewLine + Environment.NewLine);

            for (int i = 0; i < namaItem.Count; i++)
            {
                textBoxReceipt.AppendText(namaItem[i] + "\t" + quantity[i] + "\t"
                    + harga[i]);
                textBoxReceipt.AppendText(Environment.NewLine);
            }
            textBoxReceipt.AppendText("--------------------------------------------" + Environment.NewLine);
            textBoxReceipt.AppendText("Total Harga:\t\t" + total + Environment.NewLine);
            textBoxReceipt.AppendText("--------------------------------------------" + Environment.NewLine);
            textBoxReceipt.AppendText("========== K o n t a k   K a m i ==========" + Environment.NewLine + Environment.NewLine);
            textBoxReceipt.AppendText("Telp: " + no_tlp + Environment.NewLine);
            textBoxReceipt.AppendText("Email: " + email + Environment.NewLine);
            textBoxReceipt.AppendText("Website: " + website + Environment.NewLine);
            textBoxReceipt.AppendText(Environment.NewLine);
            textBoxReceipt.AppendText("========== T e r i m a k a s i h ==========" + Environment.NewLine);


        }

        private void PrintDocumentOnPrintPage(object sender, PrintPageEventArgs e)
        {
            e.Graphics.DrawString(this.textBoxReceipt.Text, this.textBoxReceipt.Font, Brushes.Black, 10, 25);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintDocumentOnPrintPage;
            printDocument.Print();
        }
    }
    
}
