namespace CafeBilling
{
    partial class frmMenu
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxId = new System.Windows.Forms.ListBox();
            this.listBoxNama = new System.Windows.Forms.ListBox();
            this.listBoxHarga = new System.Windows.Forms.ListBox();
            this.listBoxKategori = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxKategori = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.16854F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.26966F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.listBoxId, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxNama, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxHarga, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxKategori, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(216, 13);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.825243F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94.17476F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(357, 310);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listBoxId
            // 
            this.listBoxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxId.FormattingEnabled = true;
            this.listBoxId.Location = new System.Drawing.Point(4, 22);
            this.listBoxId.Name = "listBoxId";
            this.listBoxId.Size = new System.Drawing.Size(47, 273);
            this.listBoxId.TabIndex = 0;
            this.listBoxId.DoubleClick += new System.EventHandler(this.listBoxId_DoubleClick);
            // 
            // listBoxNama
            // 
            this.listBoxNama.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxNama.FormattingEnabled = true;
            this.listBoxNama.Location = new System.Drawing.Point(58, 22);
            this.listBoxNama.Name = "listBoxNama";
            this.listBoxNama.Size = new System.Drawing.Size(83, 273);
            this.listBoxNama.TabIndex = 1;
            this.listBoxNama.SelectedIndexChanged += new System.EventHandler(this.listBoxNama_SelectedIndexChanged);
            // 
            // listBoxHarga
            // 
            this.listBoxHarga.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxHarga.FormattingEnabled = true;
            this.listBoxHarga.Location = new System.Drawing.Point(180, 22);
            this.listBoxHarga.Name = "listBoxHarga";
            this.listBoxHarga.Size = new System.Drawing.Size(82, 273);
            this.listBoxHarga.TabIndex = 2;
            this.listBoxHarga.SelectedIndexChanged += new System.EventHandler(this.listBoxHarga_SelectedIndexChanged);
            // 
            // listBoxKategori
            // 
            this.listBoxKategori.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxKategori.FormattingEnabled = true;
            this.listBoxKategori.Location = new System.Drawing.Point(269, 22);
            this.listBoxKategori.Name = "listBoxKategori";
            this.listBoxKategori.Size = new System.Drawing.Size(83, 273);
            this.listBoxKategori.TabIndex = 3;
            this.listBoxKategori.SelectedIndexChanged += new System.EventHandler(this.listBoxKategori_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Harga";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kategori";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBoxKategori);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxHarga);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBoxNama);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 115);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input/Update Menu";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Kategori";
            // 
            // textBoxKategori
            // 
            this.textBoxKategori.Location = new System.Drawing.Point(61, 71);
            this.textBoxKategori.Name = "textBoxKategori";
            this.textBoxKategori.Size = new System.Drawing.Size(110, 20);
            this.textBoxKategori.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Harga";
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(61, 45);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(110, 20);
            this.textBoxHarga.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nama";
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(61, 19);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(110, 20);
            this.textBoxNama.TabIndex = 0;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(79, 134);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(54, 23);
            this.buttonAdd.TabIndex = 2;
            this.buttonAdd.Text = "Tambah";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(139, 134);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(59, 23);
            this.buttonEdit.TabIndex = 3;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(12, 134);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(61, 23);
            this.buttonHapus.TabIndex = 4;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 334);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.Text = "Management Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBoxId;
        private System.Windows.Forms.ListBox listBoxNama;
        private System.Windows.Forms.ListBox listBoxHarga;
        private System.Windows.Forms.ListBox listBoxKategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxKategori;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonHapus;
    }
}