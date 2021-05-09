namespace Stok
{
    partial class frmMüşteriListele
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
            this.dgmüşteriListele = new System.Windows.Forms.DataGridView();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSil = new System.Windows.Forms.Button();
            this.txtTcAra = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgmüşteriListele)).BeginInit();
            this.SuspendLayout();
            // 
            // dgmüşteriListele
            // 
            this.dgmüşteriListele.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgmüşteriListele.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgmüşteriListele.Location = new System.Drawing.Point(267, 86);
            this.dgmüşteriListele.Name = "dgmüşteriListele";
            this.dgmüşteriListele.RowTemplate.Height = 24;
            this.dgmüşteriListele.Size = new System.Drawing.Size(679, 309);
            this.dgmüşteriListele.TabIndex = 0;
            this.dgmüşteriListele.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgmüşteriListele_CellDoubleClick);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(161, 338);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(85, 36);
            this.btnGüncelle.TabIndex = 21;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(118, 295);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(128, 22);
            this.txtEmail.TabIndex = 20;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(118, 244);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(128, 22);
            this.txtAdres.TabIndex = 19;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(118, 193);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(128, 22);
            this.txtTelefon.TabIndex = 18;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(118, 142);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(128, 22);
            this.txtAdSoyad.TabIndex = 17;
            // 
            // txtTc
            // 
            this.txtTc.Location = new System.Drawing.Point(118, 91);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(128, 22);
            this.txtTc.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Adres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Telefon";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "TC";
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(961, 96);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(85, 30);
            this.btnSil.TabIndex = 22;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // txtTcAra
            // 
            this.txtTcAra.Location = new System.Drawing.Point(705, 39);
            this.txtTcAra.Name = "txtTcAra";
            this.txtTcAra.Size = new System.Drawing.Size(128, 22);
            this.txtTcAra.TabIndex = 23;
            this.txtTcAra.TextChanged += new System.EventHandler(this.txtTcAra_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(634, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tc Ara";
            // 
            // frmMüşteriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1058, 464);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTcAra);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.txtTc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgmüşteriListele);
            this.Name = "frmMüşteriListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmMüşteriListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgmüşteriListele)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgmüşteriListele;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.TextBox txtTcAra;
        private System.Windows.Forms.Label label6;
    }
}