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
    class personel : IPersonel
    {
        public string personelAdi { get; set; }
        public double personelTel { get; set; }
        public personel(string personelAdi)
        {
            this.personelAdi = personelAdi;
        }
        public personel()
        {
            
        }
    }
}
