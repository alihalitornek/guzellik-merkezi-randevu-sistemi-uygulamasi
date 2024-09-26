using ExcelDataReader;
using proje_v1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form_proje_v1
{
    class musteri : IMusteri
    {
        public string musteriAdi { get; set; }
        public string musteriSoyadi { get; set; }
        public double musteriTel { get; set; }
        public musteri(string musteriAdi, string musteriSoyadi, double musteriTel)
        {
            this.musteriAdi = musteriAdi;
            this.musteriSoyadi = musteriSoyadi;
            this.musteriTel = musteriTel;
        }
        public musteri()
        {
            
        }

    }
}
