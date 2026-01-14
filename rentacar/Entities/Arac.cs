using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentacar.Entities
{
    public class Arac
    {
        public int AracID { get; set; }
        public string Plaka { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Yil { get; set; }
        public string YakitTuru { get; set; }
        public string VitesTuru { get; set; }
        public decimal GunlukUcret { get; set; }
        public int Kilometre { get; set; }
        public string Renk { get; set; }
        public string Durum { get; set; } // 'Musait', 'Kirada' vs.
        public string ResimYolu { get; set; }
    }
}
