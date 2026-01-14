using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentacar
{
    // 1. KISIM: Interface (Sözleşme)"Araç işlemleri için standart bir yapı oluşturdum
    public interface IAracYonetimi
    {
        void Ekle();
        void Sil();
        void Guncelle();
        void Listele();
    }

    // 2. KISIM: Class (Kapsülleme)"Verileri güvenli taşımak için Property kullandım
    public class Arac
    {
        public int Id { get; set; }
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }

        // Encapsulation (Kapsülleme)Fiyat negatif girilirse otomatik 0 yapar.
        private decimal _gunlukUcret;
        public decimal GunlukUcret
        {
            get { return _gunlukUcret; }
            set
            {
                if (value < 0)
                {
                    _gunlukUcret = 0;
                }
                else
                {
                    _gunlukUcret = value;
                }
            }
        }
    }
}