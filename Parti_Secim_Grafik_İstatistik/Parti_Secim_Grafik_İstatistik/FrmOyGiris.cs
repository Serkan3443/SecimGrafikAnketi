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
    public partial class FrmOyGiris : Form
    {
        public FrmOyGiris()
        {
            InitializeComponent();
        }
		SqlConnection baglanti = new SqlConnection(@"Data Source = SERKANINBILGISA\SQLEXPRESS; Initial Catalog = DBSECIMPROJE; Integrated Security = True");
		
		private void buttonOyGiris_Click(object sender, EventArgs e)
		{
			//sqlcommand komut vermek için kullanılır
			baglanti.Open();
			SqlCommand komut =new SqlCommand("insert into TBLILCE(ILCEAD,APARTI,BPARTİ,CPARTİ,DPARTİ,EPARTİ) values(@P1,@P2,@P3,@P4,@P5,@P6)",baglanti);
			//bunlar formarayüzünde girdiğimiz değerleri sql aktarır
			komut.Parameters.AddWithValue("@P1",textBoxİlceAd.Text);
			komut.Parameters.AddWithValue("@P2",textBoxA.Text);
			komut.Parameters.AddWithValue("@P3",textBoxB.Text);
			komut.Parameters.AddWithValue("@P4",textBoxC.Text);
			komut.Parameters.AddWithValue("@P5",textBoxD.Text);
			komut.Parameters.AddWithValue("@P6",textBoxE.Text);
			komut.ExecuteNonQuery();//sorguyu gerçekleştirir
			baglanti.Close();//sorguyu gerçekleştirdikten sonra bağlantıyı kapatır
			MessageBox.Show("Oy Girişi gerçekleşti");

		}

		private void buttonGrafik_Click(object sender, EventArgs e)
		{
			FrmGrafikler fr = new FrmGrafikler();
			fr.Show();//frmGrafikler arayüzünü göster diyorum

		}

		private void buttonCikisYap_Click(object sender, EventArgs e)
		{
			DialogResult cikis = new DialogResult();
			cikis = MessageBox.Show("Çıkış yapmak istiyor musunuz?", "ÇIKIŞ ONAYI",MessageBoxButtons.YesNo);
			if(cikis == DialogResult.Yes)
			{
				Application.Exit();
			}
		}
	}
}
