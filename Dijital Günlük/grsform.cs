using System;
using System.Data.OleDb;
using System.Windows.Forms;
namespace Dijital_Günlük
{
    public partial class grsform : Form
    {
        public grsform()
        {
            InitializeComponent();
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "/gunlukVeritabani.mdb");
        public static string kullaniciAdi = "";
        public static int sifre, id = 0;
        //-------------------------------------------------------------------------------------------------------------------------------------------------
        private void btn_giris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("SELECT K_ID,K_adi,Sifre FROM Kullanicilar WHERE K_adi='" + tx_kullanici.Text + "' and Sifre=" + Convert.ToInt32(tx_parola.Text) + " ", baglanti);
            OleDbDataReader dr = komut.ExecuteReader();
            if (dr.HasRows == true)
            {
                while (dr.Read())
                {
                    id = dr.GetInt32(0);
                    kullaniciAdi = dr.GetString(1);
                    sifre = dr.GetInt32(2);
                }
            }
            if (kullaniciAdi == tx_kullanici.Text && sifre == Convert.ToInt32(tx_parola.Text))
            {
                baglanti.Close();
                anaEkran anaekran1 = new anaEkran();
                this.Hide();
                anaekran1.Show();
            }
            else
            {
                MessageBox.Show("Bilgiler Hatalıdır!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                baglanti.Close();
            }
        }
        private void lbl_kayit_Click(object sender, EventArgs e)
        {
            Kayitform k = new Kayitform();
            k.Show();
        }
        private void lbl_prl_Click(object sender, EventArgs e)
        {
            sifirlaform sf = new sifirlaform();
            sf.Show();
        }
    }
}
