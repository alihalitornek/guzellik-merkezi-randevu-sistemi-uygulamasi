using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_v1
{
    interface IRandevu
    {
        string musteriAdi { get; set; }
        string musteriSoyadi { get; set; }
        double musteriTel { get; set; }
        string randevuAdi { get; set; }
        double ucret { get; set; }
        string personelAdi { get; set; }
        string randevuTarihi { get; set; } // Randevunun gerçekleşeceği gün
        string randevuOluşturulmaTarihi { get; set; } // Randevunun oluşturulma tarihi
    }
}
