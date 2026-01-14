using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rentacar
{
    class SqlBaglantisi
    {
        public SqlConnection Baglanti()
        {
            // YENİ VE GÜÇLÜ BAĞLANTI CÜMLESİ:
            // 1. Sunucu: .\SQLEXPRESS
            // 2. Veritabanı: OtoGaleriDB
            // 3. Güvenlik: Windows hesabınla gir (Integrated Security)
            // 4. Sertifika: TrustServerCertificate=True (Yeni SQL sürümlerindeki hataları engeller)

            SqlConnection baglan = new SqlConnection(@"Server=.\SQLEXPRESS;Database=OtoGaleriDB;Integrated Security=True;TrustServerCertificate=True;");

            baglan.Open();
            return baglan;
        }
    }
}
