using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace rentacar
{
    public partial class Vitrin : Form
    {
        // --- 1. GLOBAL DEĞİŞKENLER ---
        SqlBaglantisi bgl = new SqlBaglantisi();
        int secilenAracId = 0;
        decimal gunlukUcret = 0;
        public string gelenTC;
        public string gelenPaket;
        public string gelenTelefon;
        public string gelenAdSoyad;
        public Vitrin()
        {
            InitializeComponent();
        }

        // --- 2. FORM YÜKLENİRKEN ---
        private void Vitrin_Load(object sender, EventArgs e)
        {
            TumAraclariListele();
            // --- GÖRÜNÜM AYARLARI ---
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.RowHeadersVisible = false; 

            // İstenmeyen sütunları gizle (Hata almamak için kontrol ederek)
            if (dataGridView1.Columns.Contains("AracID")) dataGridView1.Columns["AracID"].Visible = false;
            if (dataGridView1.Columns.Contains("ResimYolu")) dataGridView1.Columns["ResimYolu"].Visible = false;
            if (dataGridView1.Columns.Contains("Plaka")) dataGridView1.Columns["Plaka"].Visible = false;     // Plakayı gizle
            if (dataGridView1.Columns.Contains("Kilometre")) dataGridView1.Columns["Kilometre"].Visible = false; // KM'yi gizle

            // Renk ve Font Ayarları (Siyah Tema)
            dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(30, 30, 30); 
            dataGridView1.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(45, 45, 48); 
            dataGridView1.DefaultCellStyle.ForeColor = System.Drawing.Color.White;     
            dataGridView1.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Firebrick; 
            dataGridView1.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;

            // Başlık (Header) Ayarları
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Black;
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            groupBox1.ForeColor = Color.White;

            // Kutunun içindeki her şeyi tek tek bulup tipine göre boyayalım
            foreach (Control item in groupBox1.Controls)
            {
                if (item is TextBox) // Eğer bu bir yazı kutusuysa
                {
                    item.BackColor = Color.FromArgb(50, 50, 50);
                    item.ForeColor = Color.White;

                }
            }
        }

        void TumAraclariListele()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Araclar WHERE Durum='Musait'", bgl.Baglanti());
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                // Görünüm ayarları
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                if (dataGridView1.Columns.Contains("ResimYolu")) dataGridView1.Columns["ResimYolu"].Visible = false;
                if (dataGridView1.Columns.Contains("AracID")) dataGridView1.Columns["AracID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        // --- 3. TABLOYA TIKLAYINCA (Fiyat Alma Kısmı) ---
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            try
            {
                // ID ve Fiyatı hafızaya alıyoruz
                secilenAracId = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["AracID"].Value);

              
                gunlukUcret = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["GunlukUcret"].Value);

                // Resmi Göster
                string resimAdi = dataGridView1.Rows[e.RowIndex].Cells["ResimYolu"].Value.ToString();
                string tamYol = Application.StartupPath + "\\Resimler\\" + resimAdi;

                if (System.IO.File.Exists(tamYol)) pctAracResim.ImageLocation = tamYol;
                else pctAracResim.Image = null;

                // Seçim değişince ekrandaki tutarı da güncelle
                ToplamTutarHesapla();
            }
            catch { }
        }

        // --- 4. HESAPLAMA METODU (Ekranı Güncelleyen Yardımcı) ---
        void ToplamTutarHesapla()
        {
            try
            {
                // --- 1. GÜN SAYISINI AL ---
                int gun = 0;

                // Eğer kutu boşsa veya sayı değilse, otomatik 1 gün kabul et
                if (!int.TryParse(txtGun.Text, out gun))
                {
                    gun = 1;
                }

                // --- 2. PAKET ÜCRETİNİ SEÇ ---
                decimal paket = 0;
                if (rbMini.Checked) paket = 450;
                else if (rbOrta.Checked) paket = 750;
                else if (rbFull.Checked) paket = 1000;

                // --- 3. HESAPLA ---
                decimal toplam = (gunlukUcret + paket) * gun;

                // --- 4. YAZDIR ---
                lblFiyat.Text = toplam.ToString("C2");
            }
            catch
            {
              
            }
        }

        // --- 5. KİRALA BUTONU (Ödeme Sayfasına Gönder) ---
        private void btnKirala_Click(object sender, EventArgs e)
        {
            if (txtAdSoyad.Text == "" || txtTC.Text == "" || txtTel.Text == "")
            {
                MessageBox.Show("Lütfen müşteri bilgilerini giriniz.");
                return;
            }
            if (secilenAracId == 0)
            {
                MessageBox.Show("Lütfen bir araç seçiniz.");
                return;
            }

            try
            {
                int gunSayisi = int.Parse(txtGun.Text);
                decimal paketUcreti = 0;
                if (rbMini.Checked) paketUcreti = 450;
                else if (rbOrta.Checked) paketUcreti = 750;
                else if (rbFull.Checked) paketUcreti = 1000;

                
                decimal toplamTutar = (gunlukUcret + paketUcreti) * gunSayisi;

                FrmOdeme fr = new FrmOdeme();
                fr.gelenAracId = secilenAracId.ToString();
                fr.gelenUcret = toplamTutar.ToString() + " TL";

                // Müşteri bilgileri
                fr.gelenAdSoyad = txtAdSoyad.Text;
                fr.gelenTC = txtTC.Text;
                fr.gelenTelefon = txtTel.Text;
                fr.gelenGun = txtGun.Text;
                
                if (rbMini.Checked)
                    fr.gelenPaket = "Mini Paket";
                else if (rbOrta.Checked)
                    fr.gelenPaket = "Orta Paket";
                else if (rbFull.Checked)
                    fr.gelenPaket = "Full Paket";
                else
                    fr.gelenPaket = "Paket Seçilmedi";
                fr.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata Var: " + ex.Message);
            }
        }

       

        
        private void txtGun_TextChanged(object sender, EventArgs e)
        {
            ToplamTutarHesapla();
        }

        // Radyo butonlar değişince fiyatı güncelle
        private void rbMini_CheckedChanged(object sender, EventArgs e) { ToplamTutarHesapla(); }
        private void rbOrta_CheckedChanged(object sender, EventArgs e) { ToplamTutarHesapla(); }
        private void rbFull_CheckedChanged(object sender, EventArgs e) { ToplamTutarHesapla(); }
        private void rbYok_CheckedChanged(object sender, EventArgs e) { ToplamTutarHesapla(); }

        // Sadece Harf Girilsin (Ad Soyad için)
        private void txtAdSoyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        // Sadece Sayı Girilsin (TC, Telefon, Gün için)
        private void SadeceSayi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        // 1. Gün Kutusuna Sadece Sayı Girilsin
        private void txtGun_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Daha önce yazdığımız sayı engelleme kodunu çağırıyoruz
            SadeceSayi_KeyPress(sender, e);
        }

        // 2. TC Kutusuna Sadece Sayı Girilsin
        private void txtTC_KeyPress(object sender, KeyPressEventArgs e)
        {
            SadeceSayi_KeyPress(sender, e);
        }

        // 3. Telefon Kutusuna Sadece Sayı Girilsin
        
        private void txtTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            SadeceSayi_KeyPress(sender, e);
        }

       
        // (Yanlışlıkla resme tıkladığında program çökmesin diye boş metod)
        private void pctAracResim_Click(object sender, EventArgs e)
        {
        }
    }
}