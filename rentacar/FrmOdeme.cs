using System;
using System.Data.SqlClient; 
using System.Windows.Forms;
using System.Drawing;       
using System.Linq;          


namespace rentacar
{
    public partial class FrmOdeme : Form
    {
        public FrmOdeme()
        {
            InitializeComponent();
        }

        // --- Veritabanı Bağlantısını Çağırıyoruz ---
        SqlBaglantisi bgl = new SqlBaglantisi();

        
        public string gelenAracId;
        public string gelenUcret;
        public string gelenAdSoyad;
        public string gelenTC;
        public string gelenTelefon;
        public string gelenPaket;
        public string gelenGun;

        private void FrmOdeme_Load(object sender, EventArgs e)
        {
        
            lblUcret.Text = gelenUcret;

          
            Panel pnlMain = new Panel();
            pnlMain.Size = new Size(this.Width - 60, this.Height - 60);
            pnlMain.Location = new Point(30, 30);
            pnlMain.BackColor = Color.FromArgb(180, 0, 0, 0); 
            this.Controls.Add(pnlMain);
            pnlMain.BringToFront();

            
            foreach (Control item in this.Controls.Cast<Control>().ToList())
            {
                if (item != pnlMain)
                {
                    this.Controls.Remove(item);
                    pnlMain.Controls.Add(item);

                    
                    if (item is Label)
                    {
                        item.BackColor = Color.Transparent;
                        item.ForeColor = Color.White;
                        item.Font = new Font("Segoe UI", 11, FontStyle.Bold);
                    }

                   
                    if (item is TextBox || item is MaskedTextBox)
                    {
                        item.BackColor = Color.FromArgb(64, 64, 64);
                        item.ForeColor = Color.White;
                        
                        if (item.Name == "txtCVV") ((TextBox)item).PasswordChar = '*';
                    }

                    
                    if (item is Button)
                    {
                        Button btn = (Button)item;
                        btn.FlatStyle = FlatStyle.Flat;
                        btn.BackColor = Color.Transparent;
                        btn.FlatAppearance.BorderColor = Color.LimeGreen; // Ödeme vurgusu
                        btn.FlatAppearance.BorderSize = 2;
                        btn.ForeColor = Color.White;
                        btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
                    }
                }
            }
           

            lblUcret.Text = gelenUcret;

           
        }
        


        private void btnOde_Click(object sender, EventArgs e)
        {
            // Kart Bilgileri Boş mu? 
            if (string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Lütfen kart bilgilerini eksiksiz giriniz!", "Güvenlik Uyarısı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            try
            {
                SqlBaglantisi bgl = new SqlBaglantisi();
                SqlCommand komut = new SqlCommand("UPDATE Araclar SET Durum='Dolu' WHERE AracID=@p1", bgl.Baglanti());
                komut.Parameters.AddWithValue("@p1", gelenAracId);
                komut.ExecuteNonQuery();
                bgl.Baglanti().Close();

                MessageBox.Show("Ödeme Başarıyla Alındı. İyi yolculuklar!", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception hata) { MessageBox.Show("Bir hata oluştu: " + hata.Message); }
        }

        private void lblUcret_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnOde_Click_1(object sender, EventArgs e)
        {
            // 1. GÜVENLİK DUVARI: Kutular boş mu?
           
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {
                MessageBox.Show("Lütfen kart bilgilerini eksiksiz doldurunuz!", "Eksik Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            try
            {
                SqlBaglantisi bgl = new SqlBaglantisi();
                SqlCommand komutSatis = new SqlCommand("INSERT INTO Hareketler (AracID, MusteriAdSoyad, ToplamTutar, TCKimlik, PaketSecimi, Telefon) VALUES (@h1, @h2, @h3, @h4, @h5, @h6)", bgl.Baglanti());
                komutSatis.Connection = bgl.Baglanti();
                komutSatis.CommandText = "INSERT INTO Hareketler (AracID, MusteriAdSoyad, ToplamTutar, TCKimlik, PaketSecimi, Telefon) VALUES (@h1, @h2, @h3, @h4, @h5, @h6)";

                // 2. PARAMETRELERİ DOĞRULARIYLA EŞLEŞTİR
                komutSatis.Parameters.AddWithValue("@h1", gelenAracId);
                komutSatis.Parameters.AddWithValue("@h2", gelenAdSoyad);

             
                string temizUcret = gelenUcret.Replace(" TL", "").Trim();
                komutSatis.Parameters.AddWithValue("@h3", decimal.Parse(temizUcret));

                komutSatis.Parameters.AddWithValue("@h4", gelenTC);      
                komutSatis.Parameters.AddWithValue("@h5", gelenPaket);   
                komutSatis.Parameters.AddWithValue("@h6", gelenTelefon);
                komutSatis.Parameters.AddWithValue("@h7", gelenGun);
                komutSatis.ExecuteNonQuery();

                SqlCommand komutDurum = new SqlCommand("UPDATE Araclar SET Durum='Dolu' WHERE AracID=@p1", bgl.Baglanti());
                komutDurum.Parameters.AddWithValue("@p1", gelenAracId);
                komutDurum.ExecuteNonQuery(); 

                bgl.Baglanti().Close();

                MessageBox.Show("Ödeme Başarıyla Alındı. İyi yolculuklar!", "İşlem Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); 
            }
            catch (Exception hata)
            {
                MessageBox.Show("Bir hata oluştu: " + hata.Message);
            }

        }

       

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Eğer girilen karakter bir rakam (Digit) DEĞİLSE ve kontrol tuşu (Backspace vb.) DEĞİLSE
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Girişi engelle
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Harf değilse, kontrol tuşu değilse ve boşluk değilse engelle
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}