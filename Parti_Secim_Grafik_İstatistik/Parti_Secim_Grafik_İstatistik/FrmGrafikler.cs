using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Parti_Secim_Grafik_İstatistik
{
    public partial class FrmGrafikler : Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }
		SqlConnection baglanti = new SqlConnection(@"Data Source = SERKANINBILGISA\SQLEXPRESS; Initial Catalog = DBSECIMPROJE; Integrated Security = True");
		private void FrmGrafikler_Load(object sender, EventArgs e)
		{
            //ilçe adllarını comboboxa Çekme

            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select ILCEAD from TBLILCE", baglanti);
            SqlDataReader dr = komut.ExecuteReader();//komuttan gelen değeri ilişkilendiriyorum 
            while(dr.Read())//dr komutu okuma işlemini yaptığı müddetçe şunları yapsın;
            {
                comboBoxİlceSecim.Items.Add(dr[0]);//dr`den gelen 0. indexi yani ilk sütünu getir yani oku diyorum peki bu ilk sütün nedir desek ilceadı, dır derim.
            }
            baglanti.Close();

            //Grafiğe toplam sonuçları getirme
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select SUM(APARTI),SUM(BPARTİ),SUM(CPARTİ),SUM(DPARTİ),SUM(EPARTİ) from TBLILCE",baglanti);//PARTİLERİN KAÇ OY ALDIĞINI TOPLAMAK İÇİN YAZILAN KOD

            SqlDataReader dr2=komut2.ExecuteReader();
            while(dr2.Read())
            {
                chart1.Series["Partiler"].Points.AddXY("A PARTİ", dr2[0]);
                chart1.Series["Partiler"].Points.AddXY("B PARTİ", dr2[1]);
                chart1.Series["Partiler"].Points.AddXY("C PARTİ", dr2[2]);
                chart1.Series["Partiler"].Points.AddXY("D PARTİ", dr2[3]);
                chart1.Series["Partiler"].Points.AddXY("E PARTİ", dr2[4]);
            }
            baglanti.Close();
		}

		private void comboBoxİlceSecim_SelectedIndexChanged(object sender, EventArgs e)
		{
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLILCE where ILCEAD=@P1", baglanti);
            komut.Parameters.AddWithValue("@P1", comboBoxİlceSecim.Text);
            SqlDataReader dr=komut.ExecuteReader();
            while(dr.Read())
            {
                progressBar1.Value = int.Parse(dr[2].ToString());
                progressBar2.Value = int.Parse(dr[3].ToString());
                progressBar3.Value = int.Parse(dr[4].ToString());
                progressBar4.Value = int.Parse(dr[5].ToString());
                progressBar5.Value = int.Parse(dr[6].ToString());

                labelA.Text = dr[2].ToString();
                labelB.Text = dr[3].ToString();
                labelC.Text = dr[4].ToString();
                labelD.Text = dr[5].ToString();
                labelE.Text = dr[6].ToString();
            }
            baglanti.Close();
		}
	}
}
