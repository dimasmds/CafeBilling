namespace CafeBilling
{
    partial class frmUser
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
            this.listBoxSuperuser = new System.Windows.Forms.ListBox();
            this.listBoxNamaLengkap = new System.Windows.Forms.ListBox();
            this.listBoxPassword = new System.Windows.Forms.ListBox();
            this.listBoxUsername = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listBoxId = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.radioButtonManager = new System.Windows.Forms.RadioButton();
            this.radioButtonKasir = new System.Windows.Forms.RadioButton();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxNamaLengkap = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonHapus = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.372093F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.93023F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.91473F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.8217F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.31008F));
            this.tableLayoutPanel1.Controls.Add(this.listBoxSuperuser, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxNamaLengkap, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxPassword, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxUsername, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.listBoxId, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.68132F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 81.31868F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(517, 91);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listBoxSuperuser
            // 
            this.listBoxSuperuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxSuperuser.FormattingEnabled = true;
            this.listBoxSuperuser.Location = new System.Drawing.Point(439, 21);
            this.listBoxSuperuser.Name = "listBoxSuperuser";
            this.listBoxSuperuser.Size = new System.Drawing.Size(74, 65);
            this.listBoxSuperuser.TabIndex = 10;
            this.listBoxSuperuser.SelectedIndexChanged += new System.EventHandler(this.listBoxSuperuser_SelectedIndexChanged);
            // 
            // listBoxNamaLengkap
            // 
            this.listBoxNamaLengkap.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxNamaLengkap.FormattingEnabled = true;
            this.listBoxNamaLengkap.Location = new System.Drawing.Point(251, 21);
            this.listBoxNamaLengkap.Name = "listBoxNamaLengkap";
            this.listBoxNamaLengkap.Size = new System.Drawing.Size(181, 65);
            this.listBoxNamaLengkap.TabIndex = 9;
            this.listBoxNamaLengkap.SelectedIndexChanged += new System.EventHandler(this.listBoxNamaLengkap_SelectedIndexChanged);
            // 
            // listBoxPassword
            // 
            this.listBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxPassword.FormattingEnabled = true;
            this.listBoxPassword.Location = new System.Drawing.Point(154, 21);
            this.listBoxPassword.Name = "listBoxPassword";
            this.listBoxPassword.Size = new System.Drawing.Size(90, 65);
            this.listBoxPassword.TabIndex = 8;
            this.listBoxPassword.SelectedIndexChanged += new System.EventHandler(this.listBoxPassword_SelectedIndexChanged);
            // 
            // listBoxUsername
            // 
            this.listBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxUsername.FormattingEnabled = true;
            this.listBoxUsername.Location = new System.Drawing.Point(47, 21);
            this.listBoxUsername.Name = "listBoxUsername";
            this.listBoxUsername.Size = new System.Drawing.Size(100, 65);
            this.listBoxUsername.TabIndex = 7;
            this.listBoxUsername.SelectedIndexChanged += new System.EventHandler(this.listBoxUsername_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(439, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Superuser";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(251, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nama Lengkap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(154, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID";
            // 
            // listBoxId
            // 
            this.listBoxId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBoxId.FormattingEnabled = true;
            this.listBoxId.Location = new System.Drawing.Point(4, 21);
            this.listBoxId.Name = "listBoxId";
            this.listBoxId.Size = new System.Drawing.Size(36, 65);
            this.listBoxId.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Username";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 163);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Nama Lengkap";
            // 
            // radioButtonManager
            // 
            this.radioButtonManager.AutoSize = true;
            this.radioButtonManager.Location = new System.Drawing.Point(97, 217);
            this.radioButtonManager.Name = "radioButtonManager";
            this.radioButtonManager.Size = new System.Drawing.Size(67, 17);
            this.radioButtonManager.TabIndex = 4;
            this.radioButtonManager.TabStop = true;
            this.radioButtonManager.Text = "Manager";
            this.radioButtonManager.UseVisualStyleBackColor = true;
            // 
            // radioButtonKasir
            // 
            this.radioButtonKasir.AutoSize = true;
            this.radioButtonKasir.Location = new System.Drawing.Point(97, 240);
            this.radioButtonKasir.Name = "radioButtonKasir";
            this.radioButtonKasir.Size = new System.Drawing.Size(48, 17);
            this.radioButtonKasir.TabIndex = 5;
            this.radioButtonKasir.TabStop = true;
            this.radioButtonKasir.Text = "Kasir";
            this.radioButtonKasir.UseVisualStyleBackColor = true;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(98, 130);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(100, 20);
            this.textBoxUsername.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(97, 160);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(100, 20);
            this.textBoxPassword.TabIndex = 7;
            // 
            // textBoxNamaLengkap
            // 
            this.textBoxNamaLengkap.Location = new System.Drawing.Point(97, 191);
            this.textBoxNamaLengkap.Name = "textBoxNamaLengkap";
            this.textBoxNamaLengkap.Size = new System.Drawing.Size(100, 20);
            this.textBoxNamaLengkap.TabIndex = 8;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(216, 127);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Tambah";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.tambahClick);
            // 
            // buttonHapus
            // 
            this.buttonHapus.Location = new System.Drawing.Point(216, 160);
            this.buttonHapus.Name = "buttonHapus";
            this.buttonHapus.Size = new System.Drawing.Size(75, 23);
            this.buttonHapus.TabIndex = 10;
            this.buttonHapus.Text = "Hapus";
            this.buttonHapus.UseVisualStyleBackColor = true;
            this.buttonHapus.Click += new System.EventHandler(this.buttonHapus_Click);
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 271);
            this.Controls.Add(this.buttonHapus);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxNamaLengkap);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.radioButtonKasir);
            this.Controls.Add(this.radioButtonManager);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmUser";
            this.Text = "frmUser";
            this.Load += new System.EventHandler(this.frmUser_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBoxSuperuser;
        private System.Windows.Forms.ListBox listBoxNamaLengkap;
        private System.Windows.Forms.ListBox listBoxPassword;
        private System.Windows.Forms.ListBox listBoxUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton radioButtonManager;
        private System.Windows.Forms.RadioButton radioButtonKasir;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxNamaLengkap;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonHapus;
    }
}