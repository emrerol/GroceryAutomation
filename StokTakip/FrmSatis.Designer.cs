namespace StokTakip
{
    partial class FrmSatis
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblTc = new System.Windows.Forms.Label();
            this.tbxTelefon = new System.Windows.Forms.TextBox();
            this.tbxAdSoy = new System.Windows.Forms.TextBox();
            this.tbxTC = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTopFiy = new System.Windows.Forms.Label();
            this.lblSatFiy = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblUrAd = new System.Windows.Forms.Label();
            this.lblBarNo = new System.Windows.Forms.Label();
            this.tbxTopFiy = new System.Windows.Forms.TextBox();
            this.tbxSatFi = new System.Windows.Forms.TextBox();
            this.tbxMiktar = new System.Windows.Forms.TextBox();
            this.tbxUrunAd = new System.Windows.Forms.TextBox();
            this.tbxBarNo = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSatİp = new System.Windows.Forms.Button();
            this.btnSatYap = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGenTop = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnMarka = new System.Windows.Forms.Button();
            this.btnSatList = new System.Windows.Forms.Button();
            this.btnUrunList = new System.Windows.Forms.Button();
            this.btnUrunEkle = new System.Windows.Forms.Button();
            this.btnMusList = new System.Windows.Forms.Button();
            this.btnMusEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(242, 203);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(574, 214);
            this.dataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTelefon);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Controls.Add(this.lblTc);
            this.groupBox1.Controls.Add(this.tbxTelefon);
            this.groupBox1.Controls.Add(this.tbxAdSoy);
            this.groupBox1.Controls.Add(this.tbxTC);
            this.groupBox1.Location = new System.Drawing.Point(15, 203);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 174);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(6, 100);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(56, 17);
            this.lblTelefon.TabIndex = 5;
            this.lblTelefon.Text = "Telefon";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(6, 75);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(69, 17);
            this.lblAd.TabIndex = 4;
            this.lblAd.Text = "Ad Soyad";
            // 
            // lblTc
            // 
            this.lblTc.AutoSize = true;
            this.lblTc.Location = new System.Drawing.Point(6, 44);
            this.lblTc.Name = "lblTc";
            this.lblTc.Size = new System.Drawing.Size(26, 17);
            this.lblTc.TabIndex = 3;
            this.lblTc.Text = "TC";
            // 
            // tbxTelefon
            // 
            this.tbxTelefon.Location = new System.Drawing.Point(94, 97);
            this.tbxTelefon.Name = "tbxTelefon";
            this.tbxTelefon.Size = new System.Drawing.Size(100, 22);
            this.tbxTelefon.TabIndex = 2;
            // 
            // tbxAdSoy
            // 
            this.tbxAdSoy.Location = new System.Drawing.Point(94, 69);
            this.tbxAdSoy.Name = "tbxAdSoy";
            this.tbxAdSoy.Size = new System.Drawing.Size(100, 22);
            this.tbxAdSoy.TabIndex = 1;
            // 
            // tbxTC
            // 
            this.tbxTC.Location = new System.Drawing.Point(94, 41);
            this.tbxTC.Name = "tbxTC";
            this.tbxTC.Size = new System.Drawing.Size(100, 22);
            this.tbxTC.TabIndex = 0;
            this.tbxTC.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblTopFiy);
            this.groupBox2.Controls.Add(this.lblSatFiy);
            this.groupBox2.Controls.Add(this.lblMiktar);
            this.groupBox2.Controls.Add(this.lblUrAd);
            this.groupBox2.Controls.Add(this.lblBarNo);
            this.groupBox2.Controls.Add(this.tbxTopFiy);
            this.groupBox2.Controls.Add(this.tbxSatFi);
            this.groupBox2.Controls.Add(this.tbxMiktar);
            this.groupBox2.Controls.Add(this.tbxUrunAd);
            this.groupBox2.Controls.Add(this.tbxBarNo);
            this.groupBox2.Location = new System.Drawing.Point(12, 403);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 184);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // lblTopFiy
            // 
            this.lblTopFiy.AutoSize = true;
            this.lblTopFiy.Location = new System.Drawing.Point(9, 158);
            this.lblTopFiy.Name = "lblTopFiy";
            this.lblTopFiy.Size = new System.Drawing.Size(89, 17);
            this.lblTopFiy.TabIndex = 10;
            this.lblTopFiy.Text = "Toplam Fiyat";
            // 
            // lblSatFiy
            // 
            this.lblSatFiy.AutoSize = true;
            this.lblSatFiy.Location = new System.Drawing.Point(9, 132);
            this.lblSatFiy.Name = "lblSatFiy";
            this.lblSatFiy.Size = new System.Drawing.Size(76, 17);
            this.lblSatFiy.TabIndex = 9;
            this.lblSatFiy.Text = "Satış Fiyatı";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(9, 100);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(49, 17);
            this.lblMiktar.TabIndex = 8;
            this.lblMiktar.Text = "Miktarı";
            // 
            // lblUrAd
            // 
            this.lblUrAd.AutoSize = true;
            this.lblUrAd.Location = new System.Drawing.Point(9, 72);
            this.lblUrAd.Name = "lblUrAd";
            this.lblUrAd.Size = new System.Drawing.Size(63, 17);
            this.lblUrAd.TabIndex = 7;
            this.lblUrAd.Text = "Ürün Adı";
            // 
            // lblBarNo
            // 
            this.lblBarNo.AutoSize = true;
            this.lblBarNo.Location = new System.Drawing.Point(9, 44);
            this.lblBarNo.Name = "lblBarNo";
            this.lblBarNo.Size = new System.Drawing.Size(75, 17);
            this.lblBarNo.TabIndex = 6;
            this.lblBarNo.Text = "Barkod No";
            // 
            // tbxTopFiy
            // 
            this.tbxTopFiy.Location = new System.Drawing.Point(109, 155);
            this.tbxTopFiy.Name = "tbxTopFiy";
            this.tbxTopFiy.Size = new System.Drawing.Size(100, 22);
            this.tbxTopFiy.TabIndex = 5;
            // 
            // tbxSatFi
            // 
            this.tbxSatFi.Location = new System.Drawing.Point(109, 127);
            this.tbxSatFi.Name = "tbxSatFi";
            this.tbxSatFi.Size = new System.Drawing.Size(100, 22);
            this.tbxSatFi.TabIndex = 4;
            this.tbxSatFi.TextChanged += new System.EventHandler(this.tbxSatFi_TextChanged);
            // 
            // tbxMiktar
            // 
            this.tbxMiktar.Location = new System.Drawing.Point(109, 95);
            this.tbxMiktar.Name = "tbxMiktar";
            this.tbxMiktar.Size = new System.Drawing.Size(100, 22);
            this.tbxMiktar.TabIndex = 3;
            this.tbxMiktar.Text = "1";
            this.tbxMiktar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbxMiktar.TextChanged += new System.EventHandler(this.tbxMiktar_TextChanged);
            // 
            // tbxUrunAd
            // 
            this.tbxUrunAd.Location = new System.Drawing.Point(109, 67);
            this.tbxUrunAd.Name = "tbxUrunAd";
            this.tbxUrunAd.Size = new System.Drawing.Size(100, 22);
            this.tbxUrunAd.TabIndex = 2;
            // 
            // tbxBarNo
            // 
            this.tbxBarNo.Location = new System.Drawing.Point(109, 39);
            this.tbxBarNo.Name = "tbxBarNo";
            this.tbxBarNo.Size = new System.Drawing.Size(100, 22);
            this.tbxBarNo.TabIndex = 1;
            this.tbxBarNo.TextChanged += new System.EventHandler(this.tbxBarNo_TextChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(261, 447);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(84, 45);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(822, 203);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(96, 38);
            this.btnSil.TabIndex = 4;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSatİp
            // 
            this.btnSatİp.Location = new System.Drawing.Point(822, 258);
            this.btnSatİp.Name = "btnSatİp";
            this.btnSatİp.Size = new System.Drawing.Size(96, 37);
            this.btnSatİp.TabIndex = 5;
            this.btnSatİp.Text = "Satış İptal";
            this.btnSatİp.UseVisualStyleBackColor = true;
            this.btnSatİp.Click += new System.EventHandler(this.btnSatİp_Click);
            // 
            // btnSatYap
            // 
            this.btnSatYap.Location = new System.Drawing.Point(672, 448);
            this.btnSatYap.Name = "btnSatYap";
            this.btnSatYap.Size = new System.Drawing.Size(84, 45);
            this.btnSatYap.TabIndex = 6;
            this.btnSatYap.Text = "Satış Yap";
            this.btnSatYap.UseVisualStyleBackColor = true;
            this.btnSatYap.Click += new System.EventHandler(this.btnSatYap_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(443, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Genel Toplam";
            // 
            // lblGenTop
            // 
            this.lblGenTop.AutoSize = true;
            this.lblGenTop.Location = new System.Drawing.Point(585, 473);
            this.lblGenTop.Name = "lblGenTop";
            this.lblGenTop.Size = new System.Drawing.Size(24, 17);
            this.lblGenTop.TabIndex = 8;
            this.lblGenTop.Text = "....";
            // 
            // panel
            // 
            this.panel.Controls.Add(this.btnKategori);
            this.panel.Controls.Add(this.btnMarka);
            this.panel.Controls.Add(this.btnSatList);
            this.panel.Controls.Add(this.btnUrunList);
            this.panel.Controls.Add(this.btnUrunEkle);
            this.panel.Controls.Add(this.btnMusList);
            this.panel.Controls.Add(this.btnMusEkle);
            this.panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(930, 121);
            this.panel.TabIndex = 9;
            // 
            // btnKategori
            // 
            this.btnKategori.Location = new System.Drawing.Point(789, 24);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(96, 62);
            this.btnKategori.TabIndex = 6;
            this.btnKategori.Text = "Kategori";
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnMarka
            // 
            this.btnMarka.Location = new System.Drawing.Point(660, 24);
            this.btnMarka.Name = "btnMarka";
            this.btnMarka.Size = new System.Drawing.Size(96, 62);
            this.btnMarka.TabIndex = 5;
            this.btnMarka.Text = "Marka";
            this.btnMarka.UseVisualStyleBackColor = true;
            this.btnMarka.Click += new System.EventHandler(this.btnMarka_Click);
            // 
            // btnSatList
            // 
            this.btnSatList.Location = new System.Drawing.Point(531, 24);
            this.btnSatList.Name = "btnSatList";
            this.btnSatList.Size = new System.Drawing.Size(96, 62);
            this.btnSatList.TabIndex = 4;
            this.btnSatList.Text = "Satış Listeleme";
            this.btnSatList.UseVisualStyleBackColor = true;
            this.btnSatList.Click += new System.EventHandler(this.btnSatList_Click);
            // 
            // btnUrunList
            // 
            this.btnUrunList.Location = new System.Drawing.Point(401, 24);
            this.btnUrunList.Name = "btnUrunList";
            this.btnUrunList.Size = new System.Drawing.Size(96, 62);
            this.btnUrunList.TabIndex = 3;
            this.btnUrunList.Text = "Ürün Listele";
            this.btnUrunList.UseVisualStyleBackColor = true;
            this.btnUrunList.Click += new System.EventHandler(this.btnUrunList_Click);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Location = new System.Drawing.Point(273, 24);
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.Size = new System.Drawing.Size(96, 62);
            this.btnUrunEkle.TabIndex = 2;
            this.btnUrunEkle.Text = "Ürün Ekle";
            this.btnUrunEkle.UseVisualStyleBackColor = true;
            this.btnUrunEkle.Click += new System.EventHandler(this.btnUrunEkle_Click);
            // 
            // btnMusList
            // 
            this.btnMusList.Location = new System.Drawing.Point(144, 24);
            this.btnMusList.Name = "btnMusList";
            this.btnMusList.Size = new System.Drawing.Size(96, 62);
            this.btnMusList.TabIndex = 1;
            this.btnMusList.Text = "Müşteri Listeleme";
            this.btnMusList.UseVisualStyleBackColor = true;
            this.btnMusList.Click += new System.EventHandler(this.btnMusList_Click);
            // 
            // btnMusEkle
            // 
            this.btnMusEkle.Location = new System.Drawing.Point(15, 24);
            this.btnMusEkle.Name = "btnMusEkle";
            this.btnMusEkle.Size = new System.Drawing.Size(96, 62);
            this.btnMusEkle.TabIndex = 0;
            this.btnMusEkle.Text = "Müşteri Ekle";
            this.btnMusEkle.UseVisualStyleBackColor = true;
            this.btnMusEkle.Click += new System.EventHandler(this.btnMusEkle_Click);
            // 
            // FrmSatis
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(930, 704);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lblGenTop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSatYap);
            this.Controls.Add(this.btnSatİp);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView);
            this.Name = "FrmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Sayfası";
            this.Load += new System.EventHandler(this.FrmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbxTC;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblTc;
        private System.Windows.Forms.TextBox tbxTelefon;
        private System.Windows.Forms.TextBox tbxAdSoy;
        private System.Windows.Forms.Label lblTopFiy;
        private System.Windows.Forms.Label lblSatFiy;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblUrAd;
        private System.Windows.Forms.Label lblBarNo;
        private System.Windows.Forms.TextBox tbxTopFiy;
        private System.Windows.Forms.TextBox tbxSatFi;
        private System.Windows.Forms.TextBox tbxMiktar;
        private System.Windows.Forms.TextBox tbxUrunAd;
        private System.Windows.Forms.TextBox tbxBarNo;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSatİp;
        private System.Windows.Forms.Button btnSatYap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGenTop;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.Button btnSatList;
        private System.Windows.Forms.Button btnUrunList;
        private System.Windows.Forms.Button btnUrunEkle;
        private System.Windows.Forms.Button btnMusList;
        private System.Windows.Forms.Button btnMusEkle;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnMarka;
    }
}

