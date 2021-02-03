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
    public partial class frmKitapBul : Form
    {
        SqlConnection con = null;
        public frmKitapBul()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            using (con=new SqlConnection(ConfigurationManager.ConnectionStrings["kdb"].ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("Select KitapAd,YazarAd,Yayınevi from tblKitaplar where KitapAd=@KitapAd", con))
                {
                    SqlParameter[] parameters = { new SqlParameter("@KitapAd", txtKt.Text.ToLower()) };
                    command.Parameters.AddRange(parameters);
                    OpenConnection();
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        Form1 main = (Form1)Application.OpenForms["Form1"];
                        main.txtKad.Text = reader["KitapAd"].ToString();
                        main.txtYad.Text = reader["YazarAd"].ToString();
                        main.txtYayın.Text = reader["Yayınevi"].ToString();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Bu isimde kitap yok");
                    }
                    reader.Close();
                }
            }
        }
        void OpenConnection()
        {
            if (con != null && con.State != ConnectionState.Open)
            {
                con.Open();
            }
        }
    }
}
