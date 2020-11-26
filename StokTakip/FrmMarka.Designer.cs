namespace StokTakip
{
    partial class FrmMarka
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
            this.lblMKat = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lblMMarka = new System.Windows.Forms.Label();
            this.tbxMMArka = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lblMKat
            // 
            this.lblMKat.AutoSize = true;
            this.lblMKat.Location = new System.Drawing.Point(31, 27);
            this.lblMKat.Name = "lblMKat";
            this.lblMKat.Size = new System.Drawing.Size(61, 17);
            this.lblMKat.TabIndex = 0;
            this.lblMKat.Text = "Kategori";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblMMarka
            // 
            this.lblMMarka.AutoSize = true;
            this.lblMMarka.Location = new System.Drawing.Point(31, 70);
            this.lblMMarka.Name = "lblMMarka";
            this.lblMMarka.Size = new System.Drawing.Size(47, 17);
            this.lblMMarka.TabIndex = 3;
            this.lblMMarka.Text = "Marka";
            // 
            // tbxMMArka
            // 
            this.tbxMMArka.Location = new System.Drawing.Point(122, 67);
            this.tbxMMArka.Name = "tbxMMArka";
            this.tbxMMArka.Size = new System.Drawing.Size(156, 22);
            this.tbxMMArka.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(122, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 24);
            this.comboBox1.TabIndex = 5;
            // 
            // FrmMarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(324, 212);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.tbxMMArka);
            this.Controls.Add(this.lblMMarka);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblMKat);
            this.Name = "FrmMarka";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Marka";
            this.Load += new System.EventHandler(this.FrmMarka_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMKat;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblMMarka;
        private System.Windows.Forms.TextBox tbxMMArka;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}