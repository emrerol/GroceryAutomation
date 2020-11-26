namespace StokTakip
{
    partial class FrmUrunEkle
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
            this.gbxYeniUrun = new System.Windows.Forms.GroupBox();
            this.gbxVarUrun = new System.Windows.Forms.GroupBox();
            this.tbxBarNo = new System.Windows.Forms.TextBox();
            this.tbxUrunAdı = new System.Windows.Forms.TextBox();
            this.tbxMiktar = new System.Windows.Forms.TextBox();
            this.tbxAlFiy = new System.Windows.Forms.TextBox();
            this.tbxVBarNo = new System.Windows.Forms.TextBox();
            this.tbxVKat = new System.Windows.Forms.TextBox();
            this.tbxVMark = new System.Windows.Forms.TextBox();
            this.tbxVUrunAd = new System.Windows.Forms.TextBox();
            this.tbxVMiktar = new System.Windows.Forms.TextBox();
            this.tbxVAlFİ = new System.Windows.Forms.TextBox();
            this.tbxVSatFi = new System.Windows.Forms.TextBox();
            this.cbxCate = new System.Windows.Forms.ComboBox();
            this.tbxSatFiy = new System.Windows.Forms.TextBox();
            this.cbxMarka = new System.Windows.Forms.ComboBox();
            this.lblBarkNo = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblMarka = new System.Windows.Forms.Label();
            this.lblUrunAdi = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblAlisFiyat = new System.Windows.Forms.Label();
            this.lblSatisFiyat = new System.Windows.Forms.Label();
            this.btnYEkle = new System.Windows.Forms.Button();
            this.btnVEkle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gbxYeniUrun.SuspendLayout();
            this.gbxVarUrun.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxYeniUrun
            // 
            this.gbxYeniUrun.Controls.Add(this.lblSatisFiyat);
            this.gbxYeniUrun.Controls.Add(this.lblAlisFiyat);
            this.gbxYeniUrun.Controls.Add(this.lblMiktar);
            this.gbxYeniUrun.Controls.Add(this.lblUrunAdi);
            this.gbxYeniUrun.Controls.Add(this.tbxUrunAdı);
            this.gbxYeniUrun.Controls.Add(this.lblMarka);
            this.gbxYeniUrun.Controls.Add(this.lblCategory);
            this.gbxYeniUrun.Controls.Add(this.lblBarkNo);
            this.gbxYeniUrun.Controls.Add(this.cbxMarka);
            this.gbxYeniUrun.Controls.Add(this.cbxCate);
            this.gbxYeniUrun.Controls.Add(this.tbxSatFiy);
            this.gbxYeniUrun.Controls.Add(this.tbxAlFiy);
            this.gbxYeniUrun.Controls.Add(this.tbxMiktar);
            this.gbxYeniUrun.Controls.Add(this.tbxBarNo);
            this.gbxYeniUrun.Location = new System.Drawing.Point(12, 68);
            this.gbxYeniUrun.Name = "gbxYeniUrun";
            this.gbxYeniUrun.Size = new System.Drawing.Size(277, 464);
            this.gbxYeniUrun.TabIndex = 0;
            this.gbxYeniUrun.TabStop = false;
            this.gbxYeniUrun.Text = "Yeni Ürün";
            // 
            // gbxVarUrun
            // 
            this.gbxVarUrun.Controls.Add(this.btnVEkle);
            this.gbxVarUrun.Controls.Add(this.label8);
            this.gbxVarUrun.Controls.Add(this.label1);
            this.gbxVarUrun.Controls.Add(this.label2);
            this.gbxVarUrun.Controls.Add(this.label3);
            this.gbxVarUrun.Controls.Add(this.label4);
            this.gbxVarUrun.Controls.Add(this.label5);
            this.gbxVarUrun.Controls.Add(this.label6);
            this.gbxVarUrun.Controls.Add(this.label7);
            this.gbxVarUrun.Controls.Add(this.tbxVSatFi);
            this.gbxVarUrun.Controls.Add(this.tbxVBarNo);
            this.gbxVarUrun.Controls.Add(this.tbxVAlFİ);
            this.gbxVarUrun.Controls.Add(this.tbxVKat);
            this.gbxVarUrun.Controls.Add(this.tbxVMiktar);
            this.gbxVarUrun.Controls.Add(this.tbxVMark);
            this.gbxVarUrun.Controls.Add(this.tbxVUrunAd);
            this.gbxVarUrun.Location = new System.Drawing.Point(363, 68);
            this.gbxVarUrun.Name = "gbxVarUrun";
            this.gbxVarUrun.Size = new System.Drawing.Size(303, 464);
            this.gbxVarUrun.TabIndex = 1;
            this.gbxVarUrun.TabStop = false;
            this.gbxVarUrun.Text = "Var Olan Ürün";
            this.gbxVarUrun.Enter += new System.EventHandler(this.gbxVarUrun_Enter);
            // 
            // tbxBarNo
            // 
            this.tbxBarNo.Location = new System.Drawing.Point(129, 45);
            this.tbxBarNo.Name = "tbxBarNo";
            this.tbxBarNo.Size = new System.Drawing.Size(121, 22);
            this.tbxBarNo.TabIndex = 0;
            // 
            // tbxUrunAdı
            // 
            this.tbxUrunAdı.Location = new System.Drawing.Point(129, 181);
            this.tbxUrunAdı.Name = "tbxUrunAdı";
            this.tbxUrunAdı.Size = new System.Drawing.Size(121, 22);
            this.tbxUrunAdı.TabIndex = 1;
            // 
            // tbxMiktar
            // 
            this.tbxMiktar.Location = new System.Drawing.Point(129, 225);
            this.tbxMiktar.Name = "tbxMiktar";
            this.tbxMiktar.Size = new System.Drawing.Size(121, 22);
            this.tbxMiktar.TabIndex = 2;
            // 
            // tbxAlFiy
            // 
            this.tbxAlFiy.Location = new System.Drawing.Point(129, 269);
            this.tbxAlFiy.Name = "tbxAlFiy";
            this.tbxAlFiy.Size = new System.Drawing.Size(121, 22);
            this.tbxAlFiy.TabIndex = 3;
            // 
            // tbxVBarNo
            // 
            this.tbxVBarNo.Location = new System.Drawing.Point(158, 21);
            this.tbxVBarNo.Name = "tbxVBarNo";
            this.tbxVBarNo.Size = new System.Drawing.Size(100, 22);
            this.tbxVBarNo.TabIndex = 3;
            this.tbxVBarNo.TextChanged += new System.EventHandler(this.tbxVBarNo_TextChanged);
            // 
            // tbxVKat
            // 
            this.tbxVKat.Location = new System.Drawing.Point(158, 65);
            this.tbxVKat.Name = "tbxVKat";
            this.tbxVKat.Size = new System.Drawing.Size(100, 22);
            this.tbxVKat.TabIndex = 4;
            // 
            // tbxVMark
            // 
            this.tbxVMark.Location = new System.Drawing.Point(158, 109);
            this.tbxVMark.Name = "tbxVMark";
            this.tbxVMark.Size = new System.Drawing.Size(100, 22);
            this.tbxVMark.TabIndex = 5;
            // 
            // tbxVUrunAd
            // 
            this.tbxVUrunAd.Location = new System.Drawing.Point(158, 153);
            this.tbxVUrunAd.Name = "tbxVUrunAd";
            this.tbxVUrunAd.Size = new System.Drawing.Size(100, 22);
            this.tbxVUrunAd.TabIndex = 6;
            // 
            // tbxVMiktar
            // 
            this.tbxVMiktar.Location = new System.Drawing.Point(158, 197);
            this.tbxVMiktar.Name = "tbxVMiktar";
            this.tbxVMiktar.Size = new System.Drawing.Size(100, 22);
            this.tbxVMiktar.TabIndex = 7;
            // 
            // tbxVAlFİ
            // 
            this.tbxVAlFİ.Location = new System.Drawing.Point(158, 241);
            this.tbxVAlFİ.Name = "tbxVAlFİ";
            this.tbxVAlFİ.Size = new System.Drawing.Size(100, 22);
            this.tbxVAlFİ.TabIndex = 8;
            // 
            // tbxVSatFi
            // 
            this.tbxVSatFi.Location = new System.Drawing.Point(158, 285);
            this.tbxVSatFi.Name = "tbxVSatFi";
            this.tbxVSatFi.Size = new System.Drawing.Size(100, 22);
            this.tbxVSatFi.TabIndex = 9;
            // 
            // cbxCate
            // 
            this.cbxCate.FormattingEnabled = true;
            this.cbxCate.Location = new System.Drawing.Point(129, 89);
            this.cbxCate.Name = "cbxCate";
            this.cbxCate.Size = new System.Drawing.Size(121, 24);
            this.cbxCate.TabIndex = 4;
            this.cbxCate.SelectedIndexChanged += new System.EventHandler(this.cbxCate_SelectedIndexChanged);
            // 
            // tbxSatFiy
            // 
            this.tbxSatFiy.Location = new System.Drawing.Point(129, 313);
            this.tbxSatFiy.Name = "tbxSatFiy";
            this.tbxSatFiy.Size = new System.Drawing.Size(121, 22);
            this.tbxSatFiy.TabIndex = 4;
            // 
            // cbxMarka
            // 
            this.cbxMarka.FormattingEnabled = true;
            this.cbxMarka.Location = new System.Drawing.Point(129, 135);
            this.cbxMarka.Name = "cbxMarka";
            this.cbxMarka.Size = new System.Drawing.Size(121, 24);
            this.cbxMarka.TabIndex = 5;
            // 
            // lblBarkNo
            // 
            this.lblBarkNo.AutoSize = true;
            this.lblBarkNo.Location = new System.Drawing.Point(22, 50);
            this.lblBarkNo.Name = "lblBarkNo";
            this.lblBarkNo.Size = new System.Drawing.Size(75, 17);
            this.lblBarkNo.TabIndex = 6;
            this.lblBarkNo.Text = "Barkod No";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(22, 94);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(61, 17);
            this.lblCategory.TabIndex = 7;
            this.lblCategory.Text = "Kategori";
            // 
            // lblMarka
            // 
            this.lblMarka.AutoSize = true;
            this.lblMarka.Location = new System.Drawing.Point(22, 138);
            this.lblMarka.Name = "lblMarka";
            this.lblMarka.Size = new System.Drawing.Size(47, 17);
            this.lblMarka.TabIndex = 8;
            this.lblMarka.Text = "Marka";
            // 
            // lblUrunAdi
            // 
            this.lblUrunAdi.AutoSize = true;
            this.lblUrunAdi.Location = new System.Drawing.Point(22, 182);
            this.lblUrunAdi.Name = "lblUrunAdi";
            this.lblUrunAdi.Size = new System.Drawing.Size(63, 17);
            this.lblUrunAdi.TabIndex = 9;
            this.lblUrunAdi.Text = "Ürün Adı";
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(22, 226);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(46, 17);
            this.lblMiktar.TabIndex = 10;
            this.lblMiktar.Text = "Miktar";
            // 
            // lblAlisFiyat
            // 
            this.lblAlisFiyat.AutoSize = true;
            this.lblAlisFiyat.Location = new System.Drawing.Point(22, 270);
            this.lblAlisFiyat.Name = "lblAlisFiyat";
            this.lblAlisFiyat.Size = new System.Drawing.Size(67, 17);
            this.lblAlisFiyat.TabIndex = 11;
            this.lblAlisFiyat.Text = "Alış Fiyatı";
            // 
            // lblSatisFiyat
            // 
            this.lblSatisFiyat.AutoSize = true;
            this.lblSatisFiyat.Location = new System.Drawing.Point(22, 314);
            this.lblSatisFiyat.Name = "lblSatisFiyat";
            this.lblSatisFiyat.Size = new System.Drawing.Size(76, 17);
            this.lblSatisFiyat.TabIndex = 12;
            this.lblSatisFiyat.Text = "Satış Fiyatı";
            // 
            // btnYEkle
            // 
            this.btnYEkle.Location = new System.Drawing.Point(37, 455);
            this.btnYEkle.Name = "btnYEkle";
            this.btnYEkle.Size = new System.Drawing.Size(225, 50);
            this.btnYEkle.TabIndex = 2;
            this.btnYEkle.Text = "Ekle";
            this.btnYEkle.UseVisualStyleBackColor = true;
            this.btnYEkle.Click += new System.EventHandler(this.btnYEkle_Click);
            // 
            // btnVEkle
            // 
            this.btnVEkle.Location = new System.Drawing.Point(54, 387);
            this.btnVEkle.Name = "btnVEkle";
            this.btnVEkle.Size = new System.Drawing.Size(225, 50);
            this.btnVEkle.TabIndex = 3;
            this.btnVEkle.Text = "Ekle";
            this.btnVEkle.UseVisualStyleBackColor = true;
            this.btnVEkle.Click += new System.EventHandler(this.btnVEkle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Satış Fiyatı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Alış Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Miktar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ürün Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Marka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(51, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Kategori";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(51, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Barkod No";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 336);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 17);
            this.label8.TabIndex = 20;
            this.label8.Text = "......";
            // 
            // FrmUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(745, 567);
            this.Controls.Add(this.btnYEkle);
            this.Controls.Add(this.gbxVarUrun);
            this.Controls.Add(this.gbxYeniUrun);
            this.Name = "FrmUrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Ekleme Sayfası";
            this.Load += new System.EventHandler(this.FrmUrunEkle_Load);
            this.gbxYeniUrun.ResumeLayout(false);
            this.gbxYeniUrun.PerformLayout();
            this.gbxVarUrun.ResumeLayout(false);
            this.gbxVarUrun.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxYeniUrun;
        private System.Windows.Forms.Label lblSatisFiyat;
        private System.Windows.Forms.Label lblAlisFiyat;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblUrunAdi;
        private System.Windows.Forms.TextBox tbxUrunAdı;
        private System.Windows.Forms.Label lblMarka;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblBarkNo;
        private System.Windows.Forms.ComboBox cbxMarka;
        private System.Windows.Forms.ComboBox cbxCate;
        private System.Windows.Forms.TextBox tbxSatFiy;
        private System.Windows.Forms.TextBox tbxAlFiy;
        private System.Windows.Forms.TextBox tbxMiktar;
        private System.Windows.Forms.TextBox tbxBarNo;
        private System.Windows.Forms.GroupBox gbxVarUrun;
        private System.Windows.Forms.TextBox tbxVSatFi;
        private System.Windows.Forms.TextBox tbxVBarNo;
        private System.Windows.Forms.TextBox tbxVAlFİ;
        private System.Windows.Forms.TextBox tbxVKat;
        private System.Windows.Forms.TextBox tbxVMiktar;
        private System.Windows.Forms.TextBox tbxVMark;
        private System.Windows.Forms.TextBox tbxVUrunAd;
        private System.Windows.Forms.Button btnYEkle;
        private System.Windows.Forms.Button btnVEkle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}