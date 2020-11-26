namespace StokTakip
{
    partial class FrmMusListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.tbxMail2 = new System.Windows.Forms.TextBox();
            this.tbxAdress2 = new System.Windows.Forms.TextBox();
            this.tbxPhone2 = new System.Windows.Forms.TextBox();
            this.tbxNeym = new System.Windows.Forms.TextBox();
            this.tbxTcNum = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblTC2 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txbTcAra = new System.Windows.Forms.TextBox();
            this.lblArama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(290, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(736, 358);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.BackColor = System.Drawing.Color.LightGreen;
            this.btnGuncelle.Location = new System.Drawing.Point(23, 322);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(117, 37);
            this.btnGuncelle.TabIndex = 21;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = false;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // tbxMail2
            // 
            this.tbxMail2.Location = new System.Drawing.Point(161, 264);
            this.tbxMail2.Name = "tbxMail2";
            this.tbxMail2.Size = new System.Drawing.Size(100, 22);
            this.tbxMail2.TabIndex = 20;
            // 
            // tbxAdress2
            // 
            this.tbxAdress2.Location = new System.Drawing.Point(161, 225);
            this.tbxAdress2.Name = "tbxAdress2";
            this.tbxAdress2.Size = new System.Drawing.Size(100, 22);
            this.tbxAdress2.TabIndex = 19;
            // 
            // tbxPhone2
            // 
            this.tbxPhone2.Location = new System.Drawing.Point(161, 180);
            this.tbxPhone2.Name = "tbxPhone2";
            this.tbxPhone2.Size = new System.Drawing.Size(100, 22);
            this.tbxPhone2.TabIndex = 18;
            // 
            // tbxNeym
            // 
            this.tbxNeym.Location = new System.Drawing.Point(161, 131);
            this.tbxNeym.Name = "tbxNeym";
            this.tbxNeym.Size = new System.Drawing.Size(100, 22);
            this.tbxNeym.TabIndex = 17;
            // 
            // tbxTcNum
            // 
            this.tbxTcNum.Location = new System.Drawing.Point(161, 88);
            this.tbxTcNum.Name = "tbxTcNum";
            this.tbxTcNum.Size = new System.Drawing.Size(100, 22);
            this.tbxTcNum.TabIndex = 16;
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(36, 267);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(47, 17);
            this.lblMail.TabIndex = 15;
            this.lblMail.Text = "E-Mail";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(36, 225);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(45, 17);
            this.lblAdress.TabIndex = 14;
            this.lblAdress.Text = "Adres";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(36, 183);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(56, 17);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "Telefon";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(36, 134);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(69, 17);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "Ad Soyad";
            // 
            // lblTC2
            // 
            this.lblTC2.AutoSize = true;
            this.lblTC2.Location = new System.Drawing.Point(36, 88);
            this.lblTC2.Name = "lblTC2";
            this.lblTC2.Size = new System.Drawing.Size(26, 17);
            this.lblTC2.TabIndex = 11;
            this.lblTC2.Text = "TC";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.OrangeRed;
            this.btnDelete.Location = new System.Drawing.Point(23, 385);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 37);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txbTcAra
            // 
            this.txbTcAra.Location = new System.Drawing.Point(553, 41);
            this.txbTcAra.Name = "txbTcAra";
            this.txbTcAra.Size = new System.Drawing.Size(218, 22);
            this.txbTcAra.TabIndex = 23;
            this.txbTcAra.TextChanged += new System.EventHandler(this.txbTcAra_TextChanged);
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Location = new System.Drawing.Point(475, 44);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(52, 17);
            this.lblArama.TabIndex = 24;
            this.lblArama.Text = "TC Ara";
            // 
            // FrmMusListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1033, 450);
            this.Controls.Add(this.lblArama);
            this.Controls.Add(this.txbTcAra);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.tbxMail2);
            this.Controls.Add(this.tbxAdress2);
            this.Controls.Add(this.tbxPhone2);
            this.Controls.Add(this.tbxNeym);
            this.Controls.Add(this.tbxTcNum);
            this.Controls.Add(this.lblMail);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTC2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmMusListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listeleme Sayfası";
            this.Load += new System.EventHandler(this.FrmMusListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox tbxMail2;
        private System.Windows.Forms.TextBox tbxAdress2;
        private System.Windows.Forms.TextBox tbxPhone2;
        private System.Windows.Forms.TextBox tbxNeym;
        private System.Windows.Forms.TextBox tbxTcNum;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblTC2;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txbTcAra;
        private System.Windows.Forms.Label lblArama;
    }
}