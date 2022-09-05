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

namespace Test_Petrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-K0C08G8;Initial Catalog=BenzinlikTest;Integrated Security=True");
        
        
        void listele()
        {
            // Kurşunsuz 95
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLBENZIN where PETROLTUR='Kurşunsuz95'", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblKursunsuz95.Text = dr[3].ToString();
                progressBar1.Value = int.Parse(dr[4].ToString());
                LblKursunsuz95Litre.Text = dr[4].ToString();
            }
            baglanti.Close();

            // Kurşunsuz 97
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * From TBLBENZIN where PETROLTUR='Kurşunsuz97'", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblKursunsuz97.Text = dr2[3].ToString();
                progressBar2.Value = int.Parse(dr2[4].ToString());
                LblKursunsuz97Litre.Text = dr2[4].ToString();
            }
            baglanti.Close();

            // Euro Dizel10
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select * From TBLBENZIN where PETROLTUR='Eurodizel10'", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblEuroDizel.Text = dr3[3].ToString();
                progressBar3.Value = int.Parse(dr3[4].ToString());
                LblEuroDizelLitre.Text = dr3[4].ToString();
            }
            baglanti.Close();

            // YeniProDizel
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select * From TBLBENZIN where PETROLTUR='YeniProDizel'", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblYeniProDizel.Text = dr4[3].ToString();
                progressBar4.Value = int.Parse(dr4[4].ToString());
                LblYeniProDizelLitre.Text = dr4[4].ToString();
            }
            baglanti.Close();

            // Gaz
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select * From TBLBENZIN where PETROLTUR='Gaz'", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblGaz.Text = dr5[3].ToString();
                progressBar5.Value = int.Parse(dr5[4].ToString());
                LblGazLitre.Text = dr5[4].ToString();
            }
            baglanti.Close();

            // Kasa

            baglanti.Open();
            SqlCommand komut6 = new SqlCommand("select * from TBLKASA", baglanti);
            SqlDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
               LblKasa.Text = dr6[0].ToString();
            }
            baglanti.Close();
        }

        void alisListele()
        {
            // Kurşunsuz 95
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from tblbenzın where PETROLTUR='Kurşunsuz95'",baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                LblKursunsuz95Alis.Text = dr[2].ToString();
            }
            baglanti.Close();

            // Kurşunsuz 97
            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("Select * from tblbenzın where PETROLTUR='Kurşunsuz97'", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                LblKursunsuz97Alis.Text = dr2[2].ToString();
            }
            baglanti.Close();

            // Eurodizel
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("Select * from tblbenzın where PETROLTUR='Eurodizel10'", baglanti);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                LblEuroDizelAlis.Text = dr3[2].ToString();
            }
            baglanti.Close();

            // Yenidizel
            baglanti.Open();
            SqlCommand komut4 = new SqlCommand("Select * from tblbenzın where PETROLTUR='YeniProDizel'", baglanti);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                LblYeniDizelAlis.Text = dr4[2].ToString();
            }
            baglanti.Close();

            // Gaz
            baglanti.Open();
            SqlCommand komut5 = new SqlCommand("Select * from tblbenzın where PETROLTUR='Gaz'", baglanti);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                LblGazAlis.Text = dr5[2].ToString();
            }
            baglanti.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            listele();
            alisListele();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz95, litre, tutar;
            kursunsuz95 = Convert.ToDouble(LblKursunsuz95.Text);
            litre = Convert.ToDouble(numericUpDown1.Value);
            tutar = kursunsuz95 * litre;
            txtKursunsuz95Fiyat.Text = tutar.ToString();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            double kursunsuz97,litre, tutar;    
            kursunsuz97 = Convert.ToDouble(LblKursunsuz97.Text);
            litre = Convert.ToDouble(numericUpDown2.Value);
            tutar = kursunsuz97 * litre;
            txtKursunsuz97Fiyat.Text = tutar.ToString();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            double eurodizel, litre, tutar;
            eurodizel = Convert.ToDouble(LblEuroDizel.Text);
            litre = Convert.ToDouble(numericUpDown3.Value);
            tutar = eurodizel * litre;
            TxtEuroDizelFiyat.Text = tutar.ToString();
        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {
            double prodizel, litre, tutar;
            prodizel = Convert.ToDouble(LblYeniProDizel.Text);
            litre = Convert.ToDouble(numericUpDown4.Value);
            tutar = prodizel * litre;
            TxtYeniDizelFiyat.Text = tutar.ToString();
        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {
            double gaz, litre, tutar;
            gaz = Convert.ToDouble(LblGaz.Text);
            litre = Convert.ToDouble(numericUpDown5.Value);
            tutar = gaz * litre;
            TxtGazFiyat.Text = tutar.ToString();
        }

        private void BtndepoDoldur_Click(object sender, EventArgs e)
        {
            if(numericUpDown1.Value != 0)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into tblhareket (PLAKA,benzınturu,lıtre,fıyat) values(@p1,@p2,@p3,@p4)", baglanti);
                komut.Parameters.AddWithValue("@p1",TxtPlaka.Text);
                komut.Parameters.AddWithValue("@p2","Kurşunsuz95");
                komut.Parameters.AddWithValue("@p3",numericUpDown1.Value);
                komut.Parameters.AddWithValue("@p4",decimal.Parse(txtKursunsuz95Fiyat.Text));
                komut.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBLKASA set MIKTAR=mıktar+@p1",baglanti);
                komut2.Parameters.AddWithValue("@p1",decimal.Parse(txtKursunsuz95Fiyat.Text));
                komut2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("Update TBLBENZIN set STOK=STOK-@p1 where petroltur='Kurşunsuz95'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numericUpDown1.Value);
                komut3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış Yapıldı");
                listele();
            }else if (numericUpDown2.Value != 0)
            {
                baglanti.Open();
                SqlCommand cmd = new SqlCommand("insert into tblhareket (PLAKA,BENZINTURU,LITRE,FIYAT) VALUES (@q1,@q2,@q3,@q4)", baglanti);
                cmd.Parameters.AddWithValue("@q1", TxtPlaka.Text);
                cmd.Parameters.AddWithValue("@q2", "Kurşunsuz97");
                cmd.Parameters.AddWithValue("@q3", numericUpDown2.Value);
                cmd.Parameters.AddWithValue("@q4", decimal.Parse(txtKursunsuz97Fiyat.Text));
                cmd.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand cmd2 = new SqlCommand("update TBLKASA set mıktar=mıktar+@q1",baglanti);
                cmd2.Parameters.AddWithValue("@q1",decimal.Parse(txtKursunsuz97Fiyat.Text));
                cmd2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand cmd3 = new SqlCommand("update TBLBENZIN set stok=stok-@q1 where petroltur='Kurşunsuz97'", baglanti);
                cmd3.Parameters.AddWithValue("@q1", numericUpDown2.Value);
                cmd3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış Yapıldı");
                listele();
            }else if(numericUpDown3.Value != 0)
            {
                baglanti.Open();
                SqlCommand dizel = new SqlCommand("insert into tblhareket (plaka,benzınturu,lıtre,fıyat) values (@d1,@d2,@d3,@d4)", baglanti);
                dizel.Parameters.AddWithValue("@d1",TxtPlaka.Text);
                dizel.Parameters.AddWithValue("@d2", "Eurodizel10");
                dizel.Parameters.AddWithValue("@d3",numericUpDown3.Value);
                dizel.Parameters.AddWithValue("@d4",decimal.Parse(TxtEuroDizelFiyat.Text));
                dizel.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand dizel2 = new SqlCommand("update TBLKASA set mıktar=mıktar+@d1",baglanti);
                dizel2.Parameters.AddWithValue("@d1", decimal.Parse(TxtEuroDizelFiyat.Text));
                dizel2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand dizel3 = new SqlCommand("update TBLBENZIN set stok=stok-@d1 where petroltur='Eurodizel10'", baglanti);
                dizel3.Parameters.AddWithValue("@d1", numericUpDown3.Value);
                dizel3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış Yapıldı");
                listele();
            }else if(numericUpDown4.Value != 0)
            {
                baglanti.Open();
                SqlCommand yenidizel = new SqlCommand("insert into tblhareket (plaka,benzınturu,lıtre,fıyat) values (@y1,@y2,@y3,@y4)", baglanti);
                yenidizel.Parameters.AddWithValue("@y1", TxtPlaka.Text);
                yenidizel.Parameters.AddWithValue("@y2", "YeniProDizel");
                yenidizel.Parameters.AddWithValue("@y3", numericUpDown4.Value);
                yenidizel.Parameters.AddWithValue("@y4", decimal.Parse(TxtYeniDizelFiyat.Text));
                yenidizel.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand yenidizel2 = new SqlCommand("update TBLKASA set mıktar=mıktar+@d1", baglanti);
                yenidizel2.Parameters.AddWithValue("@d1", decimal.Parse(TxtYeniDizelFiyat.Text));
                yenidizel2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand yenidizel3 = new SqlCommand("update TBLBENZIN set stok=stok-@d1 where petroltur='YeniProDizel'", baglanti);
                yenidizel3.Parameters.AddWithValue("@d1", numericUpDown4.Value);
                yenidizel3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış Yapıldı");
                listele();
            }
            else
            {
                baglanti.Open();
                SqlCommand gaz = new SqlCommand("insert into tblhareket (plaka,benzınturu,lıtre,fıyat) values (@g1,@g2,@g3,@g4)", baglanti);
                gaz.Parameters.AddWithValue("@g1", TxtPlaka.Text);
                gaz.Parameters.AddWithValue("@g2", "Gaz");
                gaz.Parameters.AddWithValue("@g3", numericUpDown5.Value);
                gaz.Parameters.AddWithValue("@g4", decimal.Parse(TxtGazFiyat.Text));
                gaz.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand gaz2 = new SqlCommand("update TBLKASA set mıktar=mıktar+@g1", baglanti);
                gaz2.Parameters.AddWithValue("@g1", decimal.Parse(TxtGazFiyat.Text));
                gaz2.ExecuteNonQuery();
                baglanti.Close();

                baglanti.Open();
                SqlCommand gaz3 = new SqlCommand("update TBLBENZIN set stok=stok-@d1 where petroltur='Gaz'", baglanti);
                gaz3.Parameters.AddWithValue("@d1", numericUpDown5.Value);
                gaz3.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Satış Yapıldı");
                listele();
            }
        }

        private void numericUpDown10_ValueChanged(object sender, EventArgs e)
        {
            double k95, litre, tutar;
            k95 = Convert.ToDouble(LblKursunsuz95Alis.Text);
            litre = Convert.ToDouble(numericUpDown10.Value);
            tutar = k95 * litre;
            textBox6.Text = tutar.ToString();
        }

        private void numericUpDown9_ValueChanged(object sender, EventArgs e)
        {
            double k97,litre, tutar;
            k97 = Convert.ToDouble(LblKursunsuz97Alis.Text);
            litre = Convert.ToDouble(numericUpDown9.Value);
            tutar = k97 * litre;
            TxtKursunsuz97Alis.Text = tutar.ToString();
        }

        private void numericUpDown8_ValueChanged(object sender, EventArgs e)
        {
            double eurod, litre, tutar;
            eurod = Convert.ToDouble(LblEuroDizelAlis.Text);
            litre = Convert.ToDouble(numericUpDown8.Value);
            tutar = eurod * litre;
            TxtEuroDizelAlis.Text = tutar.ToString();
        }

        private void numericUpDown7_ValueChanged(object sender, EventArgs e)
        {
            double yenid, litre, tutar;
            yenid = Convert.ToDouble(LblYeniDizelAlis.Text);
            litre = Convert.ToDouble(numericUpDown7.Value);
            tutar = yenid * litre;
            TxtYeniDizelAlis.Text = tutar.ToString();
        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {
            double gaz, litre, tutar;
            gaz = Convert.ToDouble(LblGazAlis.Text);
            litre = Convert.ToDouble(numericUpDown6.Value);
            tutar = gaz * litre;
            TxtGazAlis.Text = tutar.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(numericUpDown10.Value != 0)
            {
                // Kurşunsuz 95 
                baglanti.Open();
                SqlCommand komut = new SqlCommand("update TBLBENZIN set stok=stok+@p1 where petroltur='Kurşunsuz95'", baglanti);
                komut.Parameters.AddWithValue("@p1", numericUpDown10.Value);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    progressBar1.Value = int.Parse(dr[4].ToString());
                    LblKursunsuz95Litre.Text = dr[4].ToString();
                }
                baglanti.Close();

                baglanti.Open();
                SqlCommand kursunsuz95 = new SqlCommand("update TBLKASA set MIKTAR=mıktar-@a1", baglanti);
                kursunsuz95.Parameters.AddWithValue("@a1", Convert.ToDecimal(textBox6.Text));
                kursunsuz95.ExecuteNonQuery();
                baglanti.Close();

            }else if(numericUpDown9.Value != 0)
            {
                // Kurşunsuz 97
                baglanti.Open();
                SqlCommand komut2 = new SqlCommand("update TBLBENZIN set stok=stok+@b1 where petroltur='Kurşunsuz97'", baglanti);
                komut2.Parameters.AddWithValue("@b1", numericUpDown9.Value);
                SqlDataReader dr2 = komut2.ExecuteReader();
                while (dr2.Read())
                {
                    progressBar1.Value = int.Parse(dr2[4].ToString());
                    LblKursunsuz97Litre.Text = dr2[4].ToString();
                }
                baglanti.Close();

                baglanti.Open();
                SqlCommand kursunsuz97 = new SqlCommand("update TBLKASA set MIKTAR=mıktar-@d1", baglanti);
                kursunsuz97.Parameters.AddWithValue("@d1", Convert.ToDecimal(TxtKursunsuz97Alis.Text));
                kursunsuz97.ExecuteNonQuery();
                baglanti.Close();
            }else if(numericUpDown8.Value != 0)
            {
                // Eurodizel
                baglanti.Open();
                SqlCommand komut3 = new SqlCommand("update TBLBENZIN set stok=stok+@p1 where petroltur='Eurodizel10'", baglanti);
                komut3.Parameters.AddWithValue("@p1", numericUpDown8.Value);
                SqlDataReader dr3 = komut3.ExecuteReader();
                while (dr3.Read())
                {
                    progressBar1.Value = int.Parse(dr3[4].ToString());
                    LblEuroDizelLitre.Text = dr3[4].ToString();
                }
                baglanti.Close();

                baglanti.Open();
                SqlCommand eurodizel = new SqlCommand("update TBLKASA set MIKTAR=mıktar-@p1", baglanti);
                eurodizel.Parameters.AddWithValue("@p1", decimal.Parse(TxtEuroDizelAlis.Text));
                eurodizel.ExecuteNonQuery();
                baglanti.Close();
            }else if (numericUpDown7.Value != 0)
            {
                // Yenidizel
                baglanti.Open();
                SqlCommand komut4 = new SqlCommand("update TBLBENZIN set stok=stok+@p1 where petroltur='YeniProDizel'", baglanti);
                komut4.Parameters.AddWithValue("@p1", numericUpDown7.Value);
                SqlDataReader dr4 = komut4.ExecuteReader();
                while (dr4.Read())
                {
                    progressBar1.Value = int.Parse(dr4[4].ToString());
                    LblYeniProDizelLitre.Text = dr4[4].ToString();
                }
                baglanti.Close();

                baglanti.Open();
                SqlCommand yenidizel = new SqlCommand("update TBLKASA set MIKTAR=mıktar-@p1", baglanti);
                yenidizel.Parameters.AddWithValue("@p1", decimal.Parse(TxtYeniDizelAlis.Text));
                yenidizel.ExecuteNonQuery();
                baglanti.Close();
            }
            else
            {
                // Gaz
                baglanti.Open();
                SqlCommand komut5 = new SqlCommand("update TBLBENZIN set stok=stok+@p1 where petroltur='Gaz'", baglanti);
                komut5.Parameters.AddWithValue("@p1", numericUpDown6.Value);
                SqlDataReader dr5 = komut5.ExecuteReader();
                while (dr5.Read())
                {
                    progressBar1.Value = int.Parse(dr5[4].ToString());
                    LblGazLitre.Text = dr5[4].ToString();
                }
                baglanti.Close();

                baglanti.Open();
                SqlCommand gaz = new SqlCommand("update TBLKASA set MIKTAR=mıktar-@p1", baglanti);
                gaz.Parameters.AddWithValue("@p1", decimal.Parse(TxtGazAlis.Text));
                gaz.ExecuteNonQuery();
                baglanti.Close();

                
            }
            MessageBox.Show("Depoya Akaryakıt Eklendi");
            listele();
            alisListele();











        }
    }
}
