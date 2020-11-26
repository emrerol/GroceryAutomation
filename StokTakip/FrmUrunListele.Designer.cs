namespace StokTakip
{
    partial class FrmUrunListele
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
            this.btnUpdating = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxSellPri = new System.Windows.Forms.TextBox();
            this.tbxBarNumber = new System.Windows.Forms.TextBox();
            this.tbxBuyPri = new System.Windows.Forms.TextBox();
            this.tbxCategoryy = new System.Windows.Forms.TextBox();
            this.tbxCustom = new System.Windows.Forms.TextBox();
            this.tbxBrandd = new System.Windows.Forms.TextBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.btnDeleting = new System.Windows.Forms.Button();
            this.tbxSearching = new System.Windows.Forms.TextBox();
            this.lblBarkodNumarasi = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(292, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(584, 372);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnUpdating
            // 
            this.btnUpdating.Location = new System.Drawing.Point(45, 359);
            this.btnUpdating.Name = "btnUpdating";
            this.btnUpdating.Size = new System.Drawing.Size(225, 50);
            this.btnUpdating.TabIndex = 21;
            this.btnUpdating.Text = "Güncelle";
            this.btnUpdating.UseVisualStyleBackColor = true;
            this.btnUpdating.Click += new System.EventHandler(this.btnUpdating_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Satış Fiyatı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Alış Fiyatı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Miktar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Ürün Adı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 17);
            this.label5.TabIndex = 31;
            this.label5.Text = "Marka";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Kategori";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(42, 53);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 29;
            this.label7.Text = "Barkod No";
            // 
            // tbxSellPri
            // 
            this.tbxSellPri.Location = new System.Drawing.Point(149, 312);
            this.tbxSellPri.Name = "tbxSellPri";
            this.tbxSellPri.Size = new System.Drawing.Size(100, 22);
            this.tbxSellPri.TabIndex = 28;
            // 
            // tbxBarNumber
            // 
            this.tbxBarNumber.Location = new System.Drawing.Point(149, 48);
            this.tbxBarNumber.Name = "tbxBarNumber";
            this.tbxBarNumber.Size = new System.Drawing.Size(100, 22);
            this.tbxBarNumber.TabIndex = 22;
            // 
            // tbxBuyPri
            // 
            this.tbxBuyPri.Location = new System.Drawing.Point(149, 268);
            this.tbxBuyPri.Name = "tbxBuyPri";
            this.tbxBuyPri.Size = new System.Drawing.Size(100, 22);
            this.tbxBuyPri.TabIndex = 27;
            // 
            // tbxCategoryy
            // 
            this.tbxCategoryy.Location = new System.Drawing.Point(149, 92);
            this.tbxCategoryy.Name = "tbxCategoryy";
            this.tbxCategoryy.ReadOnly = true;
            this.tbxCategoryy.Size = new System.Drawing.Size(100, 22);
            this.tbxCategoryy.TabIndex = 23;
            // 
            // tbxCustom
            // 
            this.tbxCustom.Location = new System.Drawing.Point(149, 224);
            this.tbxCustom.Name = "tbxCustom";
            this.tbxCustom.Size = new System.Drawing.Size(100, 22);
            this.tbxCustom.TabIndex = 26;
            // 
            // tbxBrandd
            // 
            this.tbxBrandd.Location = new System.Drawing.Point(149, 136);
            this.tbxBrandd.Name = "tbxBrandd";
            this.tbxBrandd.ReadOnly = true;
            this.tbxBrandd.Size = new System.Drawing.Size(100, 22);
            this.tbxBrandd.TabIndex = 24;
            // 
            // tbxProductName
            // 
            this.tbxProductName.Location = new System.Drawing.Point(149, 180);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(100, 22);
            this.tbxProductName.TabIndex = 25;
            // 
            // btnDeleting
            // 
            this.btnDeleting.Location = new System.Drawing.Point(45, 415);
            this.btnDeleting.Name = "btnDeleting";
            this.btnDeleting.Size = new System.Drawing.Size(225, 48);
            this.btnDeleting.TabIndex = 36;
            this.btnDeleting.Text = "Sil";
            this.btnDeleting.UseVisualStyleBackColor = true;
            this.btnDeleting.Click += new System.EventHandler(this.btnDeleting_Click);
            // 
            // tbxSearching
            // 
            this.tbxSearching.Location = new System.Drawing.Point(387, 8);
            this.tbxSearching.Name = "tbxSearching";
            this.tbxSearching.Size = new System.Drawing.Size(205, 22);
            this.tbxSearching.TabIndex = 37;
            this.tbxSearching.TextChanged += new System.EventHandler(this.tbxSearching_TextChanged);
            // 
            // lblBarkodNumarasi
            // 
            this.lblBarkodNumarasi.AutoSize = true;
            this.lblBarkodNumarasi.Location = new System.Drawing.Point(292, 13);
            this.lblBarkodNumarasi.Name = "lblBarkodNumarasi";
            this.lblBarkodNumarasi.Size = new System.Drawing.Size(78, 17);
            this.lblBarkodNumarasi.TabIndex = 38;
            this.lblBarkodNumarasi.Text = "Barkod NO";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(513, 466);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 24);
            this.comboBox1.TabIndex = 39;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(513, 511);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(177, 24);
            this.comboBox2.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(423, 517);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "Marka";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(423, 473);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 17);
            this.label9.TabIndex = 41;
            this.label9.Text = "Kategori";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(717, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 34);
            this.button1.TabIndex = 43;
            this.button1.Text = "Güncelle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmUrunListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(905, 609);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblBarkodNumarasi);
            this.Controls.Add(this.tbxSearching);
            this.Controls.Add(this.btnDeleting);
            this.Controls.Add(this.btnUpdating);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbxSellPri);
            this.Controls.Add(this.tbxBarNumber);
            this.Controls.Add(this.tbxBuyPri);
            this.Controls.Add(this.tbxCategoryy);
            this.Controls.Add(this.tbxCustom);
            this.Controls.Add(this.tbxBrandd);
            this.Controls.Add(this.tbxProductName);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmUrunListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listeleme Sayfası";
            this.Load += new System.EventHandler(this.FrmUrunListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnUpdating;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxSellPri;
        private System.Windows.Forms.TextBox tbxBarNumber;
        private System.Windows.Forms.TextBox tbxBuyPri;
        private System.Windows.Forms.TextBox tbxCategoryy;
        private System.Windows.Forms.TextBox tbxCustom;
        private System.Windows.Forms.TextBox tbxBrandd;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.Button btnDeleting;
        private System.Windows.Forms.TextBox tbxSearching;
        private System.Windows.Forms.Label lblBarkodNumarasi;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
    }
}