namespace CafeBilling
{
    partial class s
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxMakanan = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxMinuman = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxKeranjangMakanan = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listBoxKeranjangHarga = new System.Windows.Forms.ListBox();
            this.labelHargaTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBoxQ = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managementUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingNamaCafeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyTransaksiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonRemove = new System.Windows.Forms.Button();
            this.labelNamaCafe = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.labelHari = new System.Windows.Forms.Label();
            this.labelTanggal = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelNoTransaksi = new System.Windows.Forms.Label();
            this.textBoxNoTransaksi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxReceipt = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(16, 124);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(251, 370);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxMakanan);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(243, 344);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Makanan";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxMakanan
            // 
            this.listBoxMakanan.FormattingEnabled = true;
            this.listBoxMakanan.Location = new System.Drawing.Point(6, 6);
            this.listBoxMakanan.Name = "listBoxMakanan";
            this.listBoxMakanan.Size = new System.Drawing.Size(231, 329);
            this.listBoxMakanan.TabIndex = 1;
            this.listBoxMakanan.DoubleClick += new System.EventHandler(this.addToKeranjangButton);
            this.listBoxMakanan.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxMakanan_KeyDown);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxMinuman);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(243, 344);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Minuman";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxMinuman
            // 
            this.listBoxMinuman.FormattingEnabled = true;
            this.listBoxMinuman.Location = new System.Drawing.Point(6, 6);
            this.listBoxMinuman.Name = "listBoxMinuman";
            this.listBoxMinuman.Size = new System.Drawing.Size(231, 329);
            this.listBoxMinuman.TabIndex = 1;
            this.listBoxMinuman.DoubleClick += new System.EventHandler(this.addToKeranjangButton);
            this.listBoxMinuman.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBoxMinuman_KeyDown);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(243, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "&Masukan Ke Keranjang";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.addToKeranjangButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Keranjang";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(539, 496);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(75, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clea&r";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(377, 497);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "&Save";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(458, 497);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 6;
            this.button4.Text = "&Print";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.95238F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.listBoxKeranjangMakanan, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxKeranjangHarga, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelHargaTotal, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxQ, 1, 1);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(296, 146);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.413992F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.58601F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(318, 344);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 322);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total";
            // 
            // listBoxKeranjangMakanan
            // 
            this.listBoxKeranjangMakanan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxKeranjangMakanan.FormattingEnabled = true;
            this.listBoxKeranjangMakanan.Location = new System.Drawing.Point(4, 25);
            this.listBoxKeranjangMakanan.Name = "listBoxKeranjangMakanan";
            this.listBoxKeranjangMakanan.Size = new System.Drawing.Size(95, 286);
            this.listBoxKeranjangMakanan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Items";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Harga";
            // 
            // listBoxKeranjangHarga
            // 
            this.listBoxKeranjangHarga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxKeranjangHarga.FormattingEnabled = true;
            this.listBoxKeranjangHarga.Location = new System.Drawing.Point(130, 25);
            this.listBoxKeranjangHarga.Name = "listBoxKeranjangHarga";
            this.listBoxKeranjangHarga.Size = new System.Drawing.Size(140, 286);
            this.listBoxKeranjangHarga.TabIndex = 2;
            this.listBoxKeranjangHarga.SelectedIndexChanged += new System.EventHandler(this.listBoxKeranjangHarga_SelectedIndexChanged);
            // 
            // labelHargaTotal
            // 
            this.labelHargaTotal.AutoSize = true;
            this.labelHargaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHargaTotal.Location = new System.Drawing.Point(130, 322);
            this.labelHargaTotal.Name = "labelHargaTotal";
            this.labelHargaTotal.Size = new System.Drawing.Size(18, 20);
            this.labelHargaTotal.TabIndex = 5;
            this.labelHargaTotal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Q";
            // 
            // listBoxQ
            // 
            this.listBoxQ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxQ.FormattingEnabled = true;
            this.listBoxQ.Location = new System.Drawing.Point(106, 25);
            this.listBoxQ.Name = "listBoxQ";
            this.listBoxQ.Size = new System.Drawing.Size(17, 286);
            this.listBoxQ.TabIndex = 7;
            this.listBoxQ.SelectedIndexChanged += new System.EventHandler(this.listBoxQ_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.configurationToolStripMenuItem,
            this.historyToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1002, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitToolStripMenuItem.Text = "Refresh Menu";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.RefeshMenu);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // configurationToolStripMenuItem
            // 
            this.configurationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.managementMenuToolStripMenuItem,
            this.managementUserToolStripMenuItem,
            this.settingNamaCafeToolStripMenuItem});
            this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
            this.configurationToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.configurationToolStripMenuItem.Text = "&Configuration";
            // 
            // managementMenuToolStripMenuItem
            // 
            this.managementMenuToolStripMenuItem.Name = "managementMenuToolStripMenuItem";
            this.managementMenuToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.managementMenuToolStripMenuItem.Text = "Management Menu";
            this.managementMenuToolStripMenuItem.Click += new System.EventHandler(this.mgntMenu);
            // 
            // managementUserToolStripMenuItem
            // 
            this.managementUserToolStripMenuItem.Name = "managementUserToolStripMenuItem";
            this.managementUserToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.managementUserToolStripMenuItem.Text = "Management User";
            this.managementUserToolStripMenuItem.Click += new System.EventHandler(this.managementUserToolStripMenuItem_Click);
            // 
            // settingNamaCafeToolStripMenuItem
            // 
            this.settingNamaCafeToolStripMenuItem.Name = "settingNamaCafeToolStripMenuItem";
            this.settingNamaCafeToolStripMenuItem.Size = new System.Drawing.Size(179, 22);
            this.settingNamaCafeToolStripMenuItem.Text = "Setting Nama Cafe";
            this.settingNamaCafeToolStripMenuItem.Click += new System.EventHandler(this.settingNamaCafeToolStripMenuItem_Click);
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historyTransaksiToolStripMenuItem});
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // historyTransaksiToolStripMenuItem
            // 
            this.historyTransaksiToolStripMenuItem.Name = "historyTransaksiToolStripMenuItem";
            this.historyTransaksiToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.historyTransaksiToolStripMenuItem.Text = "History Transaksi";
            this.historyTransaksiToolStripMenuItem.Click += new System.EventHandler(this.historyTransaksiToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // buttonRemove
            // 
            this.buttonRemove.Location = new System.Drawing.Point(296, 497);
            this.buttonRemove.Name = "buttonRemove";
            this.buttonRemove.Size = new System.Drawing.Size(75, 23);
            this.buttonRemove.TabIndex = 9;
            this.buttonRemove.Text = "Remo&ve";
            this.buttonRemove.UseVisualStyleBackColor = true;
            this.buttonRemove.Click += new System.EventHandler(this.buttonRemove_Click);
            // 
            // labelNamaCafe
            // 
            this.labelNamaCafe.AutoSize = true;
            this.labelNamaCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNamaCafe.Location = new System.Drawing.Point(106, 37);
            this.labelNamaCafe.Name = "labelNamaCafe";
            this.labelNamaCafe.Size = new System.Drawing.Size(238, 39);
            this.labelNamaCafe.TabIndex = 10;
            this.labelNamaCafe.Text = "Cafe Yo Dawg";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(12, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 74);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Location = new System.Drawing.Point(112, 77);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(216, 13);
            this.labelAlamat.TabIndex = 12;
            this.labelAlamat.Text = "Jln. Pembangunan, Culster Sudimara Bintaro\r\n";
            this.labelAlamat.Click += new System.EventHandler(this.label7_Click);
            // 
            // labelHari
            // 
            this.labelHari.AutoSize = true;
            this.labelHari.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHari.Location = new System.Drawing.Point(828, 51);
            this.labelHari.Name = "labelHari";
            this.labelHari.Size = new System.Drawing.Size(70, 25);
            this.labelHari.TabIndex = 13;
            this.labelHari.Text = "label8";
            this.labelHari.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTanggal
            // 
            this.labelTanggal.AutoSize = true;
            this.labelTanggal.Location = new System.Drawing.Point(833, 79);
            this.labelTanggal.Name = "labelTanggal";
            this.labelTanggal.Size = new System.Drawing.Size(35, 13);
            this.labelTanggal.TabIndex = 14;
            this.labelTanggal.Text = "label8";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.Location = new System.Drawing.Point(700, 67);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(57, 25);
            this.labelUser.TabIndex = 15;
            this.labelUser.Text = "User";
            this.labelUser.Click += new System.EventHandler(this.labelUser_Click);
            // 
            // labelNoTransaksi
            // 
            this.labelNoTransaksi.AutoSize = true;
            this.labelNoTransaksi.Location = new System.Drawing.Point(479, 127);
            this.labelNoTransaksi.Name = "labelNoTransaksi";
            this.labelNoTransaksi.Size = new System.Drawing.Size(87, 13);
            this.labelNoTransaksi.TabIndex = 17;
            this.labelNoTransaksi.Text = "Nomor Transaksi";
            // 
            // textBoxNoTransaksi
            // 
            this.textBoxNoTransaksi.Location = new System.Drawing.Point(572, 124);
            this.textBoxNoTransaksi.Name = "textBoxNoTransaksi";
            this.textBoxNoTransaksi.ReadOnly = true;
            this.textBoxNoTransaksi.Size = new System.Drawing.Size(42, 20);
            this.textBoxNoTransaksi.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(702, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Welcome";
            // 
            // textBoxReceipt
            // 
            this.textBoxReceipt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxReceipt.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReceipt.Location = new System.Drawing.Point(663, 146);
            this.textBoxReceipt.Multiline = true;
            this.textBoxReceipt.Name = "textBoxReceipt";
            this.textBoxReceipt.ReadOnly = true;
            this.textBoxReceipt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceipt.Size = new System.Drawing.Size(303, 344);
            this.textBoxReceipt.TabIndex = 20;
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 536);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxReceipt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxNoTransaksi);
            this.Controls.Add(this.labelNoTransaksi);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelTanggal);
            this.Controls.Add(this.labelHari);
            this.Controls.Add(this.labelAlamat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelNamaCafe);
            this.Controls.Add(this.buttonRemove);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "s";
            this.Text = "Cafe Billing";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listBoxMakanan;
        private System.Windows.Forms.ListBox listBoxMinuman;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listBoxKeranjangMakanan;
        private System.Windows.Forms.ListBox listBoxKeranjangHarga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelHargaTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBoxQ;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managementMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button buttonRemove;
        private System.Windows.Forms.ToolStripMenuItem managementUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Label labelNamaCafe;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.Label labelHari;
        private System.Windows.Forms.Label labelTanggal;
        private System.Windows.Forms.ToolStripMenuItem settingNamaCafeToolStripMenuItem;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelNoTransaksi;
        private System.Windows.Forms.TextBox textBoxNoTransaksi;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyTransaksiToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxReceipt;
    }
}

