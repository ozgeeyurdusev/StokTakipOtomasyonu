namespace Stok
{
    partial class frmÜrünListele
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
            this.Markatxt = new System.Windows.Forms.TextBox();
            this.Kategoritxt = new System.Windows.Forms.TextBox();
            this.lblMiktarı = new System.Windows.Forms.Label();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.SatışFiyatıtxt = new System.Windows.Forms.TextBox();
            this.AlışFiyatıtxt = new System.Windows.Forms.TextBox();
            this.Miktarıtxt = new System.Windows.Forms.TextBox();
            this.ÜrünAdıtxt = new System.Windows.Forms.TextBox();
            this.BarkodNotxt = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtBarkodNoAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboMarka = new System.Windows.Forms.ComboBox();
            this.comboKategori = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnMarkaGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(253, 75);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(678, 343);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // Markatxt
            // 
            this.Markatxt.Location = new System.Drawing.Point(113, 162);
            this.Markatxt.Name = "Markatxt";
            this.Markatxt.ReadOnly = true;
            this.Markatxt.Size = new System.Drawing.Size(121, 22);
            this.Markatxt.TabIndex = 42;
            // 
            // Kategoritxt
            // 
            this.Kategoritxt.Location = new System.Drawing.Point(113, 120);
            this.Kategoritxt.Name = "Kategoritxt";
            this.Kategoritxt.ReadOnly = true;
            this.Kategoritxt.Size = new System.Drawing.Size(121, 22);
            this.Kategoritxt.TabIndex = 41;
            // 
            // lblMiktarı
            // 
            this.lblMiktarı.AutoSize = true;
            this.lblMiktarı.Location = new System.Drawing.Point(14, 392);
            this.lblMiktarı.Name = "lblMiktarı";
            this.lblMiktarı.Size = new System.Drawing.Size(0, 17);
            this.lblMiktarı.TabIndex = 40;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(129, 375);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(105, 43);
            this.btnGüncelle.TabIndex = 27;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Barkod No";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "Satış Fiyatı";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "Alış Fiyatı";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 17);
            this.label11.TabIndex = 36;
            this.label11.Text = "Miktarı";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(36, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 17);
            this.label12.TabIndex = 35;
            this.label12.Text = "Ürün Adı";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(47, 17);
            this.label13.TabIndex = 34;
            this.label13.Text = "Marka";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(36, 120);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(61, 17);
            this.label14.TabIndex = 33;
            this.label14.Text = "Kategori";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(97, 149);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(0, 17);
            this.label16.TabIndex = 32;
            // 
            // SatışFiyatıtxt
            // 
            this.SatışFiyatıtxt.Location = new System.Drawing.Point(113, 335);
            this.SatışFiyatıtxt.Name = "SatışFiyatıtxt";
            this.SatışFiyatıtxt.Size = new System.Drawing.Size(121, 22);
            this.SatışFiyatıtxt.TabIndex = 31;
            // 
            // AlışFiyatıtxt
            // 
            this.AlışFiyatıtxt.Location = new System.Drawing.Point(113, 292);
            this.AlışFiyatıtxt.Name = "AlışFiyatıtxt";
            this.AlışFiyatıtxt.Size = new System.Drawing.Size(121, 22);
            this.AlışFiyatıtxt.TabIndex = 30;
            // 
            // Miktarıtxt
            // 
            this.Miktarıtxt.Location = new System.Drawing.Point(113, 249);
            this.Miktarıtxt.Name = "Miktarıtxt";
            this.Miktarıtxt.Size = new System.Drawing.Size(121, 22);
            this.Miktarıtxt.TabIndex = 29;
            // 
            // ÜrünAdıtxt
            // 
            this.ÜrünAdıtxt.Location = new System.Drawing.Point(113, 206);
            this.ÜrünAdıtxt.Name = "ÜrünAdıtxt";
            this.ÜrünAdıtxt.Size = new System.Drawing.Size(121, 22);
            this.ÜrünAdıtxt.TabIndex = 28;
            // 
            // BarkodNotxt
            // 
            this.BarkodNotxt.Location = new System.Drawing.Point(113, 75);
            this.BarkodNotxt.Name = "BarkodNotxt";
            this.BarkodNotxt.Size = new System.Drawing.Size(121, 22);
            this.BarkodNotxt.TabIndex = 26;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(950, 75);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(94, 32);
            this.btnSil.TabIndex = 43;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtBarkodNoAra
            // 
            this.txtBarkodNoAra.Location = new System.Drawing.Point(649, 26);
            this.txtBarkodNoAra.Name = "txtBarkodNoAra";
            this.txtBarkodNoAra.Size = new System.Drawing.Size(121, 22);
            this.txtBarkodNoAra.TabIndex = 44;
            this.txtBarkodNoAra.TextChanged += new System.EventHandler(this.txtBarkodNoAra_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(495, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 45;
            this.label1.Text = "BarkodNo ya göre ara";
            // 
            // comboMarka
            // 
            this.comboMarka.FormattingEnabled = true;
            this.comboMarka.Location = new System.Drawing.Point(468, 490);
            this.comboMarka.Name = "comboMarka";
            this.comboMarka.Size = new System.Drawing.Size(121, 24);
            this.comboMarka.TabIndex = 46;
            // 
            // comboKategori
            // 
            this.comboKategori.FormattingEnabled = true;
            this.comboKategori.Location = new System.Drawing.Point(468, 446);
            this.comboKategori.Name = "comboKategori";
            this.comboKategori.Size = new System.Drawing.Size(121, 24);
            this.comboKategori.TabIndex = 47;
            this.comboKategori.SelectedIndexChanged += new System.EventHandler(this.comboKategori_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(405, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Marka";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 449);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 49;
            this.label3.Text = "Kategori";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 478);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 48;
            // 
            // btnMarkaGuncelle
            // 
            this.btnMarkaGuncelle.Location = new System.Drawing.Point(606, 460);
            this.btnMarkaGuncelle.Name = "btnMarkaGuncelle";
            this.btnMarkaGuncelle.Size = new System.Drawing.Size(105, 43);
            this.btnMarkaGuncelle.TabIndex = 51;
            this.btnMarkaGuncelle.Text = "Marka Güncelle";
            this.btnMarkaGuncelle.UseVisualStyleBackColor = true;
            this.btnMarkaGuncelle.Click += new System.EventHandler(this.btnMarkaGuncelle_Click);
            // 
            // frmÜrünListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1113, 604);
            this.Controls.Add(this.btnMarkaGuncelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboKategori);
            this.Controls.Add(this.comboMarka);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBarkodNoAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.Markatxt);
            this.Controls.Add(this.Kategoritxt);
            this.Controls.Add(this.lblMiktarı);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.SatışFiyatıtxt);
            this.Controls.Add(this.AlışFiyatıtxt);
            this.Controls.Add(this.Miktarıtxt);
            this.Controls.Add(this.ÜrünAdıtxt);
            this.Controls.Add(this.BarkodNotxt);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmÜrünListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmÜrünListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Markatxt;
        private System.Windows.Forms.TextBox Kategoritxt;
        private System.Windows.Forms.Label lblMiktarı;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox SatışFiyatıtxt;
        private System.Windows.Forms.TextBox AlışFiyatıtxt;
        private System.Windows.Forms.TextBox Miktarıtxt;
        private System.Windows.Forms.TextBox ÜrünAdıtxt;
        private System.Windows.Forms.TextBox BarkodNotxt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtBarkodNoAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboMarka;
        private System.Windows.Forms.ComboBox comboKategori;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMarkaGuncelle;
    }
}