using KitapBll;
using KitapModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KitapEnvanteri
{
    public partial class Form1 : Form
    {
        KitapBL kitapbl = new KitapBL();
        SqlConnection con = null;
        public int kitapid = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                bool sonuc = kitapbl.AddBook(new Kitap(txtKad.Text, txtYad.Text, txtYayın.Text));
                MessageBox.Show(sonuc ? "Başarılı" : "Başarısız");
            }
            catch (SqlException ex)
            {
                switch (ex.Number)
                {
                    case 1225:
                        MessageBox.Show("Veritabanı hatası !!");
                        break;
                    default:
                        break;
                }
            }

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            frmKitapBul kitapBul = new frmKitapBul();
            kitapBul.ShowDialog();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (kitapid == 0)
            {
                MessageBox.Show("önce kitap seçin");
            }
            else
            {
                using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["kdb"].ConnectionString))
                {
                    using (SqlCommand command = new SqlCommand("Delete from tblKitaplar where KitapId=@KitapId", con))
                    {
                        SqlParameter[] p = { new SqlParameter("@KitapId", kitapid) };
                        command.Parameters.AddRange(p);
                        ConnectionOpen();
                        int sonuc = command.ExecuteNonQuery();
                        MessageBox.Show(sonuc > 0 ? "Başarılı" : "Başarısız");
                    }
                }
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (con = new SqlConnection(ConfigurationManager.ConnectionStrings["kdb"].ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("Update tblKitaplar set  KitapAd=@KitapAd,YazarAd=@YazarAd,Yayınevi=@Yayınevi where KitapId=@KitapId", con))
                {
                    SqlParameter[] p = { new SqlParameter("@KitapAd", txtKad.Text),
                    new SqlParameter("@YazarAd",txtYad.Text),
                    new SqlParameter("@Yayınevi",txtYayın.Text),
                    new SqlParameter("KitapId",kitapid)
                    };
                    command.Parameters.AddRange(p);
                    ConnectionOpen();
                    int sonuc = command.ExecuteNonQuery();
                    if (sonuc > 0)
                    {
                        MessageBox.Show("Başarılı");
                        Temizle();
                    }
                    else
                    {
                        MessageBox.Show("Başarısız");
                    }
                }
            }
        }

        void Temizle()
        {
            txtKad.Text = string.Empty;
            txtYad.Text = string.Empty;
            txtYayın.Text = string.Empty;
            kitapid = 0;
        }

        void ConnectionOpen()
        {
            if (con!=null && con.State!=ConnectionState.Open)
            {
                con.Open();
            }
        }
    }
}
