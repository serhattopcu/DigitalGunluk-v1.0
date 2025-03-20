using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Dijital_Günlük
{
    public partial class anaEkran : Form
    {
        //------------------------------------------------------tanımlanan değişkenler-------------------------------------------------------------------------      
        string sifreliMetin = "", ametin = "", sifrelenentext = "", karakter = "", icerik = "", sifre = "", tarihimetin = "";
        public static int id1 = 0;
        int sayac2 = 1, baglantisayaci = 0, sayac = 0, sayacCoz = 1;
        string[] sifreDizi = new string[4];
        Random rastgele = new Random();
        public static string metin = "";
        OleDbConnection baglanti = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source= " + Application.StartupPath + "/gunlukVeritabani.mdb");
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
        public anaEkran()
        {
            InitializeComponent();
        }
        private void c3_yil_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public string sifrele()
        {
            baglanti.Open();
            while (sayac < tx_metin.TextLength)
            {
                OleDbCommand komut = new OleDbCommand("SELECT SIFRE_METNI FROM sifrelemeTablosu WHERE ASCI = " + Convert.ToInt32(Convert.ToChar(tx_metin.Text.Substring(sayac, 1))), baglanti);
                OleDbDataReader dr = komut.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                        sifreliMetin = dr.GetString(0);
                }
                for (int i = 0; i < 4; i++)
                {
                    sifreDizi[i] = sifreliMetin.Substring(sayac2, 4);
                    sayac2 = sayac2 + 6;
                }
                sayac2 = 1;
                sifrelenentext += Convert.ToChar(rastgele.Next(33, 127)) + sifreDizi[rastgele.Next(4)] + Convert.ToChar(rastgele.Next(33, 127));
                if (baglantisayaci > 500) dr.Close();
                baglantisayaci++;
                sayac++;
            }
            baglanti.Close();
            return sifrelenentext;
        }
        public string sifrecozz(string icerk)
        {
            baglanti.Open();
            icerik = icerk;
            for (int i = 1; i < 87; i++)
            {
                OleDbCommand komut = new OleDbCommand("SELECT SIFRE_METNI FROM sifrelemeTablosu WHERE Id = " + i + "", baglanti);
                OleDbCommand komut2 = new OleDbCommand("SELECT karakterler FROM isaretciler WHERE Kimlik = " + i + "", baglanti);
                OleDbDataReader dr = komut.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                        sifreliMetin = dr.GetString(0);
                }
                dr = komut2.ExecuteReader();
                if (dr.HasRows)
                {          
                    while (dr.Read())                    
                        karakter = dr.GetString(0);
                }   
                if (i == 86)
                    dr.Close();
                for (int j = 0; j < 4; j++)
                {
                    sifre = sifreliMetin.Substring(sayacCoz, 4);
                    sayacCoz = sayacCoz + 6;
                    icerik = icerik.Replace(sifre, karakter);
                }
                sayacCoz = 1;
            }
            int deger = 1;
            while (deger < icerik.Length)
            {
                ametin += icerik.Substring(deger, 1);
                deger = deger + 3;
            }
            tx_cozulenmetin.Text = ametin;
            ametin = "";
            baglanti.Close();
            return ametin;
        }
        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand eklemekomut = new OleDbCommand("insert into Gunlukler (K_ID,gun,ay,yil,Metin) values (@kid,@gun,@ay,@yil,@metin)", baglanti);
            eklemekomut.Parameters.AddWithValue("@kid", id1);
            eklemekomut.Parameters.AddWithValue("@gun", DateTime.Now.ToString("dd"));
            eklemekomut.Parameters.AddWithValue("@ay", DateTime.Now.ToString("MMMM"));
            eklemekomut.Parameters.AddWithValue("@yil", DateTime.Now.ToString("yyyy"));
            eklemekomut.Parameters.AddWithValue("@metin", sifrelenentext);
            eklemekomut.ExecuteNonQuery();
            MessageBox.Show("Bilgiler kayıt edildi!", "Bilgilendime", MessageBoxButtons.OK, MessageBoxIcon.Information);
            baglanti.Close();
        }
        private void btn_temizle_Click(object sender, EventArgs e)
        {
            tx_metin.Text = "";
            tx_sifreprev.Text = "";
            tx_cozulenmetin.Text = "";
            tarihimetin = "";
            ametin = "";
            sifrelenentext = "";
        }
        private void anaEkran_Load(object sender, EventArgs e)
        {
            id1 = grsform.id;
            label3.Text = grsform.kullaniciAdi;
            lbl_tarih.Text = DateTime.Now.ToLongDateString();
            baglanti.Close();
        }
        private void tx_sifreprev_TextChanged(object sender, EventArgs e)
        {
            tx_sifreprev.SelectionStart = tx_sifreprev.Text.Length;
            tx_sifreprev.ScrollToCaret();
        }
        private void tx_metin_TextChanged(object sender, EventArgs e)
        {
            tx_sifreprev.Text = sifrele();
        }
        private void btn_coz_Click(object sender, EventArgs e)
        {
            sifrecozz(sorgula(id1));
        }
        public string sorgula(int uid)
        {
            baglanti.Open();
            OleDbCommand kmtsorgu = new OleDbCommand("Select * From Gunlukler Where K_ID=" + id1 + " AND  gun='" + c1_gun.SelectedItem.ToString() + "'AND ay='" + c2_ay.SelectedItem.ToString() + "'AND yil='" + c3_yil.SelectedItem.ToString() + "'", baglanti);
            OleDbDataReader dar = kmtsorgu.ExecuteReader();
            if (dar.HasRows)
                while (dar.Read())
                {
                    lbl_gun.Text = Convert.ToString(dar["gun"]);
                    lbl_ay.Text = Convert.ToString(dar["ay"]);
                    lbl_yil.Text = Convert.ToString(dar["yil"]);
                    tarihimetin = Convert.ToString(dar["Metin"]);
                }
            baglanti.Close();
            return tarihimetin;
        }
    }
}
