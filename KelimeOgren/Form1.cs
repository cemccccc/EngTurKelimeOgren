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

namespace KelimeOgren
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		SqlConnection baglanti = new SqlConnection(@"Data Source=CEMC\SQLEXPRESS01;Initial Catalog=DbSozluk;Integrated Security=True");
		int sure = 90;
		int deger = 0;
		public void KelimeSorgusu()
		{
			baglanti.Open();
			SqlCommand komut = new SqlCommand("select count(id) from TblSozluk", baglanti);
			int count = Convert.ToInt32(komut.ExecuteScalar());

			Random rnd = new Random();
			int randomSayi = rnd.Next(1, count);
			LblKelime.Text = randomSayi.ToString();

			SqlCommand komut2 = new SqlCommand("select * from TblSozluk where id=@p1", baglanti);
			komut2.Parameters.AddWithValue("@p1", randomSayi);
			SqlDataReader dr = komut2.ExecuteReader();
			while (dr.Read())
			{
				TxtEnglish.Text = dr[1].ToString();
				TxtEnglish.Enabled = false;
				LblKelime.Text = dr[2].ToString();
				LblKelime.Text = LblKelime.Text.ToLower();
			}
			baglanti.Close();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			KelimeSorgusu();
			timer1.Start();
		}

		private void TxtTurkish_TextChanged(object sender, EventArgs e)
		{


			if (TxtTurkish.Text == LblKelime.Text)
			{
				deger++;
				LblCounter.Text = deger.ToString();
				TxtTurkish.Clear();
				KelimeSorgusu();
				LblKelime.Visible= false;
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			LblKelime.Visible = true;
		}

		private void BtnPas_Click(object sender, EventArgs e)
		{
			KelimeSorgusu();
			LblKelime.Visible = false;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			sure--;
			LblTimer.Text= sure.ToString();
			if (sure==0)
			{
				timer1.Stop();
				TxtEnglish.Enabled = false;
				TxtTurkish.Enabled = false;
				BtnGoster.Enabled = false;
				BtnPas.Enabled = false;
				if (deger==0)
				{
					MessageBox.Show("Süre doldu. Üzgünüm. Doğrunuz bulunmuyor!", ":(", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				else
				{
					MessageBox.Show("Süre dolmuştur. Toplam doğru sayınız: " + LblCounter.Text, "Tebrikler", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
		}
	}
}
