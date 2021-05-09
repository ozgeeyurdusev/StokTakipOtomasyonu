using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok
{
    public partial class frmMüşteriListele : Form
    {
        public frmMüşteriListele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=OZZ;Initial Catalog=Stok_Takip;Integrated Security=True");
        DataSet daset = new DataSet();
        private void frmMüşteriListele_Load(object sender, EventArgs e)
        {
            Kayıt_Göster();
        }

        private void Kayıt_Göster()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from müşteri", baglanti);
            adtr.Fill(daset, "müşteri");
            dgmüşteriListele.DataSource = daset.Tables["müşteri"];
            baglanti.Close();
        }

        private void dgmüşteriListele_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTc.Text = dgmüşteriListele.CurrentRow.Cells["tc"].Value.ToString();
            txtAdSoyad.Text = dgmüşteriListele.CurrentRow.Cells["adsoyad"].Value.ToString();
            txtTelefon.Text = dgmüşteriListele.CurrentRow.Cells["telefon"].Value.ToString();
            txtAdres.Text = dgmüşteriListele.CurrentRow.Cells["adres"].Value.ToString();
            txtEmail.Text = dgmüşteriListele.CurrentRow.Cells["email"].Value.ToString();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("update müşteri set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email where tc=@tc",baglanti);

            komut.Parameters.AddWithValue("@tc", txtTc.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["müşteri"].Clear();
            Kayıt_Göster();
            MessageBox.Show("Müşteri kaydı güncellendi.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from müşteri where tc='"+dgmüşteriListele.CurrentRow.Cells["tc"].Value.ToString()+"'",baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            daset.Tables["müşteri"].Clear();
            Kayıt_Göster();
            MessageBox.Show("Kayıt silindi");
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            DataTable tablo = new DataTable();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from müşteri where tc like '%"+txtTcAra.Text+"%'",baglanti);
            adtr.Fill(tablo);
            dgmüşteriListele.DataSource = tablo;
            baglanti.Close();
        }
    }
}
