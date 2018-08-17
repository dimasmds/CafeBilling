namespace CafeBilling
{
    partial class frmPreviewTrans
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
            this.textBoxReceipt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxReceipt
            // 
            this.textBoxReceipt.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBoxReceipt.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxReceipt.Location = new System.Drawing.Point(2, 1);
            this.textBoxReceipt.Multiline = true;
            this.textBoxReceipt.Name = "textBoxReceipt";
            this.textBoxReceipt.ReadOnly = true;
            this.textBoxReceipt.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReceipt.Size = new System.Drawing.Size(303, 344);
            this.textBoxReceipt.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(221, 358);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Print";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPreviewTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 393);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxReceipt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmPreviewTrans";
            this.Text = "frmPreviewTrans";
            this.Load += new System.EventHandler(this.frmPreviewTrans_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxReceipt;
        private System.Windows.Forms.Button button1;
    }
}