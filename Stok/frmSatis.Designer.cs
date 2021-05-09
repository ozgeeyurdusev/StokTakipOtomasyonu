namespace Stok
{
    partial class frmSatis
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMiktarı = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtToplamFiyat = new System.Windows.Forms.TextBox();
            this.txtSatışFiyatı = new System.Windows.Forms.TextBox();
            this.txtUrunAdı = new System.Windows.Forms.TextBox();
            this.txtBarkodNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSatışYap = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.lblGenelToplam = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnSatışİptal = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMarka = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnSatışlarıListeleme = new System.Windows.Forms.Button();
            this.btnÜrünListeleme = new System.Windows.Forms.Button();
            this.btnÜrünEkleme = new System.Windows.Forms.Button();
            this.btnMüşteriListeleme = new System.Windows.Forms.Button();
            this.btnMüşteriEkleme = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(458, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(666, 398);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(59, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 154);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri İşlemleri";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(134, 116);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(117, 22);
            this.txtTelefon.TabIndex = 5;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(134, 71);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(117, 22);
            this.txtAdSoyad.TabIndex = 4;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(134, 28);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(117, 22);
            this.txtTc.TabIndex = 3;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tc:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMiktarı);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtToplamFiyat);
            this.groupBox2.Controls.Add(this.txtSatışFiyatı);
            this.groupBox2.Controls.Add(this.txtUrunAdı);
            this.groupBox2.Controls.Add(this.txtBarkodNo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(59, 310);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 236);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ürün İşlemleri";
            // 
            // txtMiktarı
            // 
            this.txtMiktarı.Location = new System.Drawing.Point(134, 110);
            this.txtMiktarı.Name = "txtMiktarı";
            this.txtMiktarı.Size = new System.Drawing.Size(117, 22);
            this.txtMiktarı.TabIndex = 11;
            this.txtMiktarı.Text = "1";
            this.txtMiktarı.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMiktarı.TextChanged += new System.EventHandler(this.txtMiktarı_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "Toplam Fiyat:";
            // 
            // txtToplamFiyat
            // 
            this.txtToplamFiyat.Location = new System.Drawing.Point(134, 181);
            this.txtToplamFiyat.Name = "txtToplamFiyat";
            this.txtToplamFiyat.Size = new System.Drawing.Size(117, 22);
            this.txtToplamFiyat.TabIndex = 9;
            // 
            // txtSatışFiyatı
            // 
            this.txtSatışFiyatı.Location = new System.Drawing.Point(134, 146);
            this.txtSatışFiyatı.Name = "txtSatışFiyatı";
            this.txtSatışFiyatı.Size = new System.Drawing.Size(117, 22);
            this.txtSatışFiyatı.TabIndex = 7;
            this.txtSatışFiyatı.TextChanged += new System.EventHandler(this.txtSatışFiyatı_TextChanged);
            // 
            // txtUrunAdı
            // 
            this.txtUrunAdı.Location = new System.Drawing.Point(134, 72);
            this.txtUrunAdı.Name = "txtUrunAdı";
            this.txtUrunAdı.Size = new System.Drawing.Size(117, 22);
            this.txtUrunAdı.TabIndex = 6;
            // 
            // txtBarkodNo
            // 
            this.txtBarkodNo.Location = new System.Drawing.Point(134, 27);
            this.txtBarkodNo.Name = "txtBarkodNo";
            this.txtBarkodNo.Size = new System.Drawing.Size(117, 22);
            this.txtBarkodNo.TabIndex = 5;
            this.txtBarkodNo.TextChanged += new System.EventHandler(this.txtBarkodNo_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Toplam Fiyat:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Satış Fiyatı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Miktarı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Ürün Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Barkod No:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(458, 521);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(99, 25);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSatışYap
            // 
            this.btnSatışYap.Location = new System.Drawing.Point(1026, 521);
            this.btnSatışYap.Name = "btnSatışYap";
            this.btnSatışYap.Size = new System.Drawing.Size(99, 25);
            this.btnSatışYap.TabIndex = 4;
            this.btnSatışYap.Text = "Satış Yap";
            this.btnSatışYap.UseVisualStyleBackColor = true;
            this.btnSatışYap.Click += new System.EventHandler(this.btnSatışYap_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(757, 529);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(101, 17);
            this.label10.TabIndex = 5;
            this.label10.Text = "Genel Toplam:";
            // 
            // lblGenelToplam
            // 
            this.lblGenelToplam.AutoSize = true;
            this.lblGenelToplam.Location = new System.Drawing.Point(882, 529);
            this.lblGenelToplam.Name = "lblGenelToplam";
            this.lblGenelToplam.Size = new System.Drawing.Size(0, 17);
            this.lblGenelToplam.TabIndex = 6;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(1146, 102);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(99, 25);
            this.btnSil.TabIndex = 7;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSatışİptal
            // 
            this.btnSatışİptal.Location = new System.Drawing.Point(1149, 154);
            this.btnSatışİptal.Name = "btnSatışİptal";
            this.btnSatışİptal.Size = new System.Drawing.Size(99, 25);
            this.btnSatışİptal.TabIndex = 8;
            this.btnSatışİptal.Text = "Satış İptal";
            this.btnSatışİptal.UseVisualStyleBackColor = true;
            this.btnSatışİptal.Click += new System.EventHandler(this.btnSatışİptal_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnMarka);
            this.panel1.Controls.Add(this.btnKategori);
            this.panel1.Controls.Add(this.btnSatışlarıListeleme);
            this.panel1.Controls.Add(this.btnÜrünListeleme);
            this.panel1.Controls.Add(this.btnÜrünEkleme);
            this.panel1.Controls.Add(this.btnMüşteriListeleme);
            this.panel1.Controls.Add(this.btnMüşteriEkleme);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1308, 84);
            this.panel1.TabIndex = 9;
            // 
            // btnMarka
            // 
            this.btnMarka.Location = new System.Drawing.Point(1094, 12);
            this.btnMarka.Name = "btnMarka";
            this.btnMarka.Size = new System.Drawing.Size(132, 51);
            this.btnMarka.TabIndex = 17;
            this.btnMarka.Text = "Marka";
            this.btnMarka.UseVisualStyleBackColor = true;
            this.btnMarka.Click += new System.EventHandler(this.btnMarka_Click);
            // 
            // btnKategori
            // 
            this.btnKategori.Location = new System.Drawing.Point(956, 12);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(132, 51);
            this.btnKategori.TabIndex = 16;
            this.btnKategori.Text = "Kategori";
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnSatışlarıListeleme
            // 
            this.btnSatışlarıListeleme.Location = new System.Drawing.Point(751, 12);
            this.btnSatışlarıListeleme.Name = "btnSatışlarıListeleme";
            this.btnSatışlarıListeleme.Size = new System.Drawing.Size(132, 51);
            this.btnSatışlarıListeleme.TabIndex = 15;
            this.btnSatışlarıListeleme.Text = "Satışları Listeleme";
            this.btnSatışlarıListeleme.UseVisualStyleBackColor = true;
            this.btnSatışlarıListeleme.Click += new System.EventHandler(this.btnSatışlarıListeleme_Click);
            // 
            // btnÜrünListeleme
            // 
            this.btnÜrünListeleme.Location = new System.Drawing.Point(613, 12);
            this.btnÜrünListeleme.Name = "btnÜrünListeleme";
            this.btnÜrünListeleme.Size = new System.Drawing.Size(132, 51);
            this.btnÜrünListeleme.TabIndex = 14;
            this.btnÜrünListeleme.Text = "Ürün Listeleme";
            this.btnÜrünListeleme.UseVisualStyleBackColor = true;
            this.btnÜrünListeleme.Click += new System.EventHandler(this.btnÜrünListeleme_Click);
            // 
            // btnÜrünEkleme
            // 
            this.btnÜrünEkleme.Location = new System.Drawing.Point(475, 12);
            this.btnÜrünEkleme.Name = "btnÜrünEkleme";
            this.btnÜrünEkleme.Size = new System.Drawing.Size(132, 51);
            this.btnÜrünEkleme.TabIndex = 13;
            this.btnÜrünEkleme.Text = "Ürün Ekleme";
            this.btnÜrünEkleme.UseVisualStyleBackColor = true;
            this.btnÜrünEkleme.Click += new System.EventHandler(this.btnÜrünEkleme_Click);
            // 
            // btnMüşteriListeleme
            // 
            this.btnMüşteriListeleme.Location = new System.Drawing.Point(264, 12);
            this.btnMüşteriListeleme.Name = "btnMüşteriListeleme";
            this.btnMüşteriListeleme.Size = new System.Drawing.Size(132, 51);
            this.btnMüşteriListeleme.TabIndex = 12;
            this.btnMüşteriListeleme.Text = "Müşteri Listeleme";
            this.btnMüşteriListeleme.UseVisualStyleBackColor = true;
            this.btnMüşteriListeleme.Click += new System.EventHandler(this.btnMüşteriListeleme_Click);
            // 
            // btnMüşteriEkleme
            // 
            this.btnMüşteriEkleme.Location = new System.Drawing.Point(116, 12);
            this.btnMüşteriEkleme.Name = "btnMüşteriEkleme";
            this.btnMüşteriEkleme.Size = new System.Drawing.Size(132, 51);
            this.btnMüşteriEkleme.TabIndex = 10;
            this.btnMüşteriEkleme.Text = "Müşteri Ekleme";
            this.btnMüşteriEkleme.UseVisualStyleBackColor = true;
            this.btnMüşteriEkleme.Click += new System.EventHandler(this.btnMüşteriEkleme_Click);
            // 
            // frmSatis
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1308, 608);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSatışİptal);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.lblGenelToplam);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSatışYap);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satış Sayfası";
            this.Load += new System.EventHandler(this.frmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMiktarı;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtToplamFiyat;
        private System.Windows.Forms.TextBox txtSatışFiyatı;
        private System.Windows.Forms.TextBox txtUrunAdı;
        private System.Windows.Forms.TextBox txtBarkodNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSatışYap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblGenelToplam;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnSatışİptal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSatışlarıListeleme;
        private System.Windows.Forms.Button btnÜrünListeleme;
        private System.Windows.Forms.Button btnÜrünEkleme;
        private System.Windows.Forms.Button btnMüşteriListeleme;
        private System.Windows.Forms.Button btnMüşteriEkleme;
        private System.Windows.Forms.Button btnMarka;
        private System.Windows.Forms.Button btnKategori;
    }
}

