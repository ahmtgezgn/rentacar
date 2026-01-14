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

namespace rentacar
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }

        // 1. Bağlantı sınıfımızı çağırıyoruz
        SqlBaglantisi bgl = new SqlBaglantisi();

        
        string resimDosyaYolu = "";

        // LİSTELEME METODU
        void Listele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Araclar", bgl.Baglanti());
            da.Fill(dt);
            dgwAraclar.DataSource = dt;
        }

        // FORM YÜKLENDİĞİNDE (Açılışta)
        private void Form1_Load(object sender, EventArgs e)
        {
            Listele();
            
            IstatistikGetir();

           
            if (cmbYakit.Items.Count == 0)
            {
                cmbYakit.Items.Add("Benzin");
                cmbYakit.Items.Add("Dizel");
                cmbYakit.Items.Add("LPG");
                cmbYakit.Items.Add("Elektrik");
            }
            if (cmbVites.Items.Count == 0)
            {
                cmbVites.Items.Add("Manuel");
                cmbVites.Items.Add("Otomatik");
            }
            // Arka Plana Yarı Saydam Siyah Panel
            Panel arkaPanel = new Panel();
            arkaPanel.Dock = DockStyle.Fill;
            arkaPanel.BackColor = Color.FromArgb(180, 0, 0, 0); 
            this.Controls.Add(arkaPanel);
            arkaPanel.BringToFront();

            // Sol Kutu (groupBox1) Ayarları
            if (groupBox1 != null)
            {
                this.Controls.Remove(groupBox1);
                arkaPanel.Controls.Add(groupBox1);
                groupBox1.BackColor = Color.Transparent;
                groupBox1.ForeColor = Color.White;
                KutuIciStil(groupBox1);
            }

           
            GroupBox sagKutu = this.Controls.Find("groupBox2", true).FirstOrDefault() as GroupBox;
            if (sagKutu != null)
            {
                this.Controls.Remove(sagKutu);
                arkaPanel.Controls.Add(sagKutu);
                sagKutu.BackColor = Color.Transparent;
                sagKutu.ForeColor = Color.White;
                KutuIciStil(sagKutu);
            }

            // Araç Sil ve Diğer Başıboş Butonları Toparla
            foreach (Control item in this.Controls.Cast<Control>().ToList())
            {
                if (item is Button)
                {
                    this.Controls.Remove(item);
                    arkaPanel.Controls.Add(item);
                    ButonStil((Button)item);
                }
            }

            // Tablo (dgwAraclar) Ayarları
            if (dgwAraclar != null)
            {
                this.Controls.Remove(dgwAraclar);
                arkaPanel.Controls.Add(dgwAraclar);

                dgwAraclar.BackgroundColor = Color.FromArgb(45, 45, 48);
                dgwAraclar.BorderStyle = BorderStyle.None;
                dgwAraclar.GridColor = Color.Gray;

                // Başlıklar
                dgwAraclar.EnableHeadersVisualStyles = false;
                dgwAraclar.ColumnHeadersDefaultCellStyle.BackColor = Color.Black;
                dgwAraclar.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                dgwAraclar.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);

                // Satırlar
                dgwAraclar.DefaultCellStyle.BackColor = Color.FromArgb(60, 60, 60);
                dgwAraclar.DefaultCellStyle.ForeColor = Color.White;
                dgwAraclar.DefaultCellStyle.SelectionBackColor = Color.DarkRed;
                dgwAraclar.DefaultCellStyle.SelectionForeColor = Color.White;
            }

            // Tüm Butonları Son Kez Boya
            TumButonlariBoyat(arkaPanel.Controls);
         
            lblToplamKazanc.Parent = arkaPanel;
            lblKiradakiArac.Parent = arkaPanel;

            lblToplamKazanc.ForeColor = Color.White; 
            lblKiradakiArac.ForeColor = Color.White;

            
            lblToplamKazanc.Location = new Point(lblToplamKazanc.Location.X, lblToplamKazanc.Location.Y);
            lblKiradakiArac.Location = new Point(lblKiradakiArac.Location.X, lblKiradakiArac.Location.Y);

            // 4. En öne getir
            lblToplamKazanc.BringToFront();
            lblKiradakiArac.BringToFront();
            lblCiroBaslik.Parent = arkaPanel;  
            lblkiradakisay.Parent = arkaPanel;  

          
            lblCiroBaslik.ForeColor = Color.LightGray;
            lblkiradakisay.ForeColor = Color.LightGray; 

            
            lblCiroBaslik.BringToFront();
            lblkiradakisay.BringToFront();
        }
        // GroupBox içindeki yazıları ve kutuları boyar
        void KutuIciStil(GroupBox gb)
        {
            foreach (object obj in gb.Controls)
            {
                Control item = obj as Control;
                if (item == null) continue;

                // --- Yazı Etiketleri (Label) ---
                if (item is Label)
                {   
                    item.BackColor = Color.Transparent; 
                    item.ForeColor = Color.White;      
                    item.Font = new Font("Segoe UI", 11, FontStyle.Bold); 
                }

                // --- Yazı Kutuları (TextBox, ComboBox vb.) ---
                if (item is TextBox || item is MaskedTextBox || item is ComboBox)
                {
                    item.BackColor = Color.FromArgb(50, 50, 50); 
                    item.ForeColor = Color.White;              
                                                              
                    if (item is TextBox) ((TextBox)item).BorderStyle = BorderStyle.FixedSingle;
                }

                // --- Resim Kutusu ---
                if (item is PictureBox)
                {
                    ((PictureBox)item).BorderStyle = BorderStyle.FixedSingle;
                    item.BackColor = Color.Transparent;
                }
            }
        }
        

        // Bir alandaki tüm butonları bulup "Hayalet Buton" yapar
        void TumButonlariBoyat(Control.ControlCollection alan)
        {
            foreach (Control item in alan)
            {
                if (item is Button) ButonStil((Button)item);
               
                if (item is GroupBox) TumButonlariBoyat(item.Controls);
            }
        }

        // Tek bir butona stil verir
        void ButonStil(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.BackColor = Color.Transparent;
            btn.ForeColor = Color.White;
            btn.FlatAppearance.BorderColor = Color.White;
            btn.FlatAppearance.BorderSize = 2;
            btn.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            btn.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 255, 255, 255);
        }

        // RESİM SEÇ BUTONU
        private void btnResimSec_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog(); // Dosya seçiciyi aç

            // Eğer boş değilse (bir resim seçildiyse)
            if (openFileDialog1.FileName != "")
            {
                pctResim.ImageLocation = openFileDialog1.FileName; 
                resimDosyaYolu = openFileDialog1.FileName; 
            }
        }

        // KAYDET BUTONU
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // 1. GÜVENLİK KONTROLÜ: Sayısal alanlar boş mu?
            if (string.IsNullOrEmpty(txtUcret.Text) || string.IsNullOrEmpty(txtKm.Text) || string.IsNullOrEmpty(txtYil.Text))
            {
                MessageBox.Show("Lütfen Yıl, Kilometre ve Ücret alanlarını boş bırakmayınız.", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // SQL Bağlantısı ve Ekleme Sorgusu
                SqlCommand komut = new SqlCommand("insert into Araclar (Plaka, Marka, Model, Yil, YakitTuru, VitesTuru, GunlukUcret, Kilometre, Renk, Durum, ResimYolu) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", bgl.Baglanti());

                // String (Metin) Değerler
                komut.Parameters.AddWithValue("@p1", txtPlaka.Text.ToUpper());
                komut.Parameters.AddWithValue("@p2", txtMarka.Text.Trim());
                komut.Parameters.AddWithValue("@p3", txtModel.Text.Trim());
                komut.Parameters.AddWithValue("@p4", txtYil.Text.Trim());
                komut.Parameters.AddWithValue("@p5", cmbYakit.Text);
                komut.Parameters.AddWithValue("@p6", cmbVites.Text);

                komut.Parameters.AddWithValue("@p7", decimal.Parse(txtUcret.Text.Trim()));
                komut.Parameters.AddWithValue("@p8", int.Parse(txtKm.Text.Trim()));

                komut.Parameters.AddWithValue("@p9", txtRenk.Text.Trim());
                komut.Parameters.AddWithValue("@p10", "Musait");

               

                string kaydedilecekDosyaAdi = "";

                if (!string.IsNullOrEmpty(resimDosyaYolu))
                {
                    // 1. Resmin sadece adını al (Örn: bmw_resmi.jpg)
                    string dosyaAdi = Path.GetFileName(resimDosyaYolu);


                    // 3. Projenin çalıştığı yerde "Resimler" diye bir klasör hedefle
                    string hedefKlasor = Application.StartupPath + "\\Resimler";

                    // 4. Eğer klasör yoksa oluştur
                    if (!Directory.Exists(hedefKlasor))
                    {
                        Directory.CreateDirectory(hedefKlasor);
                    }

                    // 5. Resmi oraya kopyala
                    string hedefYol = Path.Combine(hedefKlasor, dosyaAdi);
                    File.Copy(resimDosyaYolu, hedefYol, true); // true: varsa üzerine yazar

                    // 6. Veritabanına kaydedilecek ismi ayarla
                    kaydedilecekDosyaAdi = dosyaAdi;
                }

                // Veritabanına sadece dosya adını gönderiyoruz (Tüm yolu değil!)
                komut.Parameters.AddWithValue("@p11", kaydedilecekDosyaAdi);

               

                // İşlemi Yap
                komut.ExecuteNonQuery();
                bgl.Baglanti().Close();

                MessageBox.Show("Araç Başarıyla Kaydedildi!", "İşlem Tamam", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                txtPlaka.Text = "";
                txtMarka.Text = "";
                txtModel.Text = "";
                txtYil.Text = "";
                txtUcret.Text = "";
                txtKm.Text = "";
                txtRenk.Text = "";
                resimDosyaYolu = ""; 
                pctResim.ImageLocation = ""; 
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen 'Ücret' ve 'Kilometre' kutularına harf girmeden sadece sayı yazdığınızdan emin olun.", "Sayı Format Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception hata)
            {
                MessageBox.Show("Veritabanı hatası oluştu: " + hata.Message);
            }
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int secilenSatir = dgwAraclar.SelectedCells[0].RowIndex;

                // Sütun isimlerinden emin değilsen indeks (0, 1, 2..) kullan:
                string aracId = dgwAraclar.Rows[secilenSatir].Cells["AracID"].Value.ToString();
                string durum = dgwAraclar.Rows[secilenSatir].Cells["Durum"].Value.ToString();

                if (durum == "Kirada" || durum == "Dolu")
                {
                    SqlBaglantisi bgl = new SqlBaglantisi();
                    // Baglanti() metodunun baş harfini kontrol et (b mi B mi?)
                    SqlCommand komut = new SqlCommand("SELECT TOP 1 * FROM Hareketler WHERE AracID=@p1 ORDER BY HareketID DESC", bgl.Baglanti());
                    komut.Parameters.AddWithValue("@p1", aracId);

                    SqlDataReader dr = komut.ExecuteReader();
                    if (dr.Read()) 
                    {
                        MessageBox.Show("Müşteri: " + dr["MusteriAdSoyad"].ToString() +
                      "\nTC: " + dr["TCKimlik"].ToString() +
                      "\nTelefon: " + dr["Telefon"].ToString() +
                      "\nPaket: " + dr["PaketSecimi"].ToString() +
                      "\nGün Sayısı: " + dr["GunSayisi"].ToString() +  
                      "\nToplam Tutar: " + dr["ToplamTutar"].ToString() + " TL","Kiralama Detayı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    bgl.Baglanti().Close();
                }
            }
            catch (Exception)
            {
               
            }
        }
        void IstatistikGetir()
        {
            try
            {
                SqlBaglantisi bgl = new SqlBaglantisi();

                // Kazanç Sorgusu
                SqlCommand komut1 = new SqlCommand("SELECT SUM(ToplamTutar) FROM Hareketler", bgl.Baglanti());
                object sonuc = komut1.ExecuteScalar();
                lblToplamKazanc.Text = (sonuc == DBNull.Value ? "0" : sonuc.ToString()) + " TL";

                // Sayı Sorgusu
                SqlCommand komut2 = new SqlCommand("SELECT COUNT(*) FROM Araclar WHERE Durum='Kirada' OR Durum='Dolu'", bgl.Baglanti());
                lblKiradakiArac.Text = komut2.ExecuteScalar().ToString();

                bgl.Baglanti().Close();

                // GÖRSEL: Labelları en öne getir ve renklendir
                lblToplamKazanc.BringToFront();
                lblKiradakiArac.BringToFront();
                lblToplamKazanc.ForeColor = Color.SpringGreen;
                lblKiradakiArac.ForeColor = Color.White;
            }
            catch (Exception ex)
            {
                // Eğer bir hata varsa sessiz kalma, bize söyle:
                MessageBox.Show("İstatistik hatası: " + ex.Message);
            }
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // 1. Önce uyarı 
            DialogResult secim = MessageBox.Show("Bu aracı silmek istediğinize emin misiniz?", "Silme İşlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (secim == DialogResult.Yes)
            {
                // 2. Seçili satırdaki "AracID" değerini al
                // (Burası SQL'deki sütun adınla aynı olmalı)
                string id = dgwAraclar.CurrentRow.Cells["AracID"].Value.ToString();

                // 3. SQL Silme Komutu
                SqlCommand komutSil = new SqlCommand("Delete From Araclar Where AracID = @k1", bgl.Baglanti());
                komutSil.Parameters.AddWithValue("@k1", id);

                komutSil.ExecuteNonQuery();
                bgl.Baglanti().Close();

                MessageBox.Show("Araç silindi.");

            }
        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            IstatistikGetir();
            // 1. Tablodan hangi aracın seçildiğini buluyoruz
            if (dgwAraclar.SelectedRows.Count > 0)
            {
                int secilenSatir = dgwAraclar.SelectedCells[0].RowIndex;
                string secilenAracID = dgwAraclar.Rows[secilenSatir].Cells["AracID"].Value.ToString();
                string durum = dgwAraclar.Rows[secilenSatir].Cells["Durum"].Value.ToString();

                // 2. Kontrol: Araç zaten müsaitse bir şey yapmaya gerek yok
                if (durum == "Musait")
                {
                    MessageBox.Show("Bu araç zaten galeride, teslim alınacak bir durumu yok.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // 3. Onay alalım
                DialogResult onay = MessageBox.Show("Araç teslim alındı mı? Vitrine tekrar eklenecek.", "Teslim Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (onay == DialogResult.Yes)
                {
                    SqlBaglantisi bgl = new SqlBaglantisi();
                    // Aracı tekrar 'Musait' durumuna çekiyoruz
                    SqlCommand komut = new SqlCommand("UPDATE Araclar SET Durum='Musait' WHERE AracID=@p1", bgl.Baglanti());
                    komut.Parameters.AddWithValue("@p1", secilenAracID);
                    komut.ExecuteNonQuery();
                    bgl.Baglanti().Close();


                    MessageBox.Show("Araç başarıyla teslim alındı. Artık vitrinde tekrar 'Müsait' görünecek.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Yönetici tablosunu yenile
                    Listele();
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce listeden teslim alınacak aracı seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
