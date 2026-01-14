using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace rentacar
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Şifre kontrolü (Şifreyi buraya istediğin gibi yazabilirsin)
            if (txtSifre.Text == "1234")
            {
                // Şifre doğruysa Yönetici panelini (Form1) aç
                Form1 yoneticiEkrani = new Form1();
                yoneticiEkrani.Show();

                // Giriş ekranını gizle
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Şifre! Lütfen tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSifre.Clear(); // Kutuyu temizle
            }
        }
        
        private void FrmAdminGiris_Load(object sender, EventArgs e)
        {
            // --- 1. "Yönetici Şifresi:" ETİKETİ AYARLARI ---
            label1.BackColor = Color.Transparent; 
            label1.ForeColor = Color.White;       
            label1.Font = new Font("Segoe UI", 14, FontStyle.Bold); 

            // --- 2. ŞİFRE KUTUSU (TextBox) AYARLARI ---
            txtSifre.BackColor = Color.FromArgb(64, 64, 64); 
            txtSifre.ForeColor = Color.White;              
            txtSifre.BorderStyle = BorderStyle.FixedSingle; 
            txtSifre.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            
            txtSifre.PasswordChar = '*';

            // --- 3. "GİRİŞ" BUTONU AYARLARI (Hayalet Stil) ---
            button1.FlatStyle = FlatStyle.Flat;
            button1.BackColor = Color.Transparent; 
            button1.FlatAppearance.BorderSize = 2;   
            button1.FlatAppearance.BorderColor = Color.White;
            button1.ForeColor = Color.White;      
            button1.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            // Butonun üzerine gelince ve tıklayınca efektler
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 255, 255, 255);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 255, 255, 255);
        }
    }
}
