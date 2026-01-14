using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rentacar
{
    public partial class AnaMenu : Form
    {
        public AnaMenu()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            FrmAdminGiris giris = new FrmAdminGiris();
            giris.Show();
           
        }

        private void btnVitrin_Click(object sender, EventArgs e)
        {
            Vitrin vr = new Vitrin(); 
            vr.Show();
            
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {
            // YÖNETİCİ BUTONU (btnAdmin) AYARLARI
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.BackColor = Color.Transparent;
            btnAdmin.FlatAppearance.BorderSize = 2;
            btnAdmin.FlatAppearance.BorderColor = Color.White;
            btnAdmin.ForeColor = Color.White;
            btnAdmin.Font = new Font("Segoe UI", 14, FontStyle.Bold); 

            // Üzerine gelince hafif parlasın
            btnAdmin.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 255, 255, 255);
            // Tıklayınca koyulaşsın
            btnAdmin.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 255, 255, 255);

            // MÜŞTERİ BUTONU (btnVitrin) AYARLARI
            btnVitrin.FlatStyle = FlatStyle.Flat;
            btnVitrin.BackColor = Color.Transparent;
            btnVitrin.FlatAppearance.BorderSize = 2;
            btnVitrin.FlatAppearance.BorderColor = Color.White;
            btnVitrin.ForeColor = Color.White;
            btnVitrin.Font = new Font("Segoe UI", 14, FontStyle.Bold);

            // Hover efektleri
            btnVitrin.FlatAppearance.MouseOverBackColor = Color.FromArgb(40, 255, 255, 255);
            btnVitrin.FlatAppearance.MouseDownBackColor = Color.FromArgb(80, 255, 255, 255);
        }
    }
}
