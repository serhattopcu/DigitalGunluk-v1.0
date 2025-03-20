using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Dijital_Günlük
{
    public partial class Kayitform : Form
    {
        public Kayitform()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + "/gunlukVeritabani.mdb");

        private void button2_Click(object sender, EventArgs e)
        {
            if (baglanti.State == ConnectionState.Closed) baglanti.Open();
            OleDbCommand komut = new OleDbCommand("INSERT INTO Kullanicilar(K_adi,Sifre,Eposta) VALUES ('" + tx_kadi.Text + "','" + Convert.ToInt32(tx_s1.Text) + "','" + tx_eposta.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Eklendi!");
            grsform g = new grsform();
            g.Show();
            this.Close();
        }

    }
}
