using form_proje_v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_v1
{
    class randevu : IRandevu
    {
        public string musteriAdi { get; set; }
        public string musteriSoyadi { get; set; }
        public double musteriTel { get; set; }
        public string randevuAdi { get; set; }
        public double ucret { get; set; }
        public string personelAdi { get; set; }
        public string randevuTarihi { get; set; } // Randevunun gerçekleşeceği gün
        public string randevuOluşturulmaTarihi { get; set; } = Convert.ToString(DateTime.Now.Day + "." + DateTime.Now.Month + "." + DateTime.Now.Year); // Randevunun oluşturulma tarihi
        public randevu(int kacgun, hizmet hizmet, musteri musteri, personel personel)
        {
            randevuTarihi = Convert.ToString(DateTime.Now.Day+kacgun+"."+DateTime.Now.Month+"."+DateTime.Now.Year);
            randevuAdi = hizmet.hizmetAdi;
            ucret = hizmet.ucret;
            musteriAdi = musteri.musteriAdi;
            musteriSoyadi = musteri.musteriSoyadi;
            musteriTel = musteri.musteriTel;
            personelAdi = personel.personelAdi;
        }
        public randevu()
        {
        }
    }
}
