using ClosedXML.Excel;
using ExcelDataReader;
using form_proje_v1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace proje_v1
{
    static class veriislemleri // Veri okuma yazma işlemleri burada yapılır
    {
        public static List<musteri> verioku(string dosyayol) // Musteri verilerini okumak için kullanılır
        {
            List<musteri> musteriler = new List<musteri>();
            musteri temp = null;

            using (var filestream = File.Open(dosyayol, FileMode.Open, FileAccess.Read))
            {
                IExcelDataReader reader = ExcelDataReader.ExcelReaderFactory.CreateReader(filestream);
                while (reader.Read())
                {
                    if(Convert.ToDouble(reader[2])!=0) // Boş mu diye kontrol eder ve yeni verileri listeye ekler
                    {
                        temp = new musteri();
                        temp.musteriAdi = Convert.ToString(reader[0]);
                        temp.musteriSoyadi = Convert.ToString(reader[1]);
                        temp.musteriTel = Convert.ToDouble(reader[2]);
                        musteriler.Add(temp);
                    }
                    
                }
            }

            return musteriler; // Listeyi döndürür
        }
        

        public static void veriyaz(string dosyayol, List<musteri> musteriler) // Musteri verilerini yazmak için kullanılır
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Sheet1");

                // Verileri Excel dosyasına yazar
                for (int i = 0; i < musteriler.Count; i++)
                {
                    worksheet.Cell(i + 1, 1).Value = musteriler[i].musteriAdi;
                    worksheet.Cell(i + 1, 2).Value = musteriler[i].musteriSoyadi;
                    worksheet.Cell(i + 1, 3).Value = musteriler[i].musteriTel;
                }

                // Dosyayı kaydeder
                workbook.SaveAs(dosyayol);
            }
        }

        // Musteri verilerini düzenlemek için kullanılır
        public static void veriduzenle(string dosyayol, string eskiAdi, string eskiSoyadi, double eskiTel, string yeniAdi, string yeniSoyadi, double yeniTel)
        {
            // Önce veriyi okur
            List<musteri> musteriler = verioku(dosyayol);

            // Düzenlenecek kişiyi bulur
            musteri duzenlenecekKisi = musteriler.FirstOrDefault(x => x.musteriAdi == eskiAdi && x.musteriSoyadi == eskiSoyadi && x.musteriTel == eskiTel);

            if (duzenlenecekKisi != null)
            {
                // Kişinin bilgilerini günceller
                duzenlenecekKisi.musteriAdi = yeniAdi;
                duzenlenecekKisi.musteriSoyadi = yeniSoyadi;
                duzenlenecekKisi.musteriTel = yeniTel;

                // Güncellenmiş verileri Excel dosyasına kaydeder
                veriyaz(dosyayol, musteriler);
            }
        }

        // Randevu verilerini okumak için kullanılır
        public static List<randevu> veriokurandevu(string dosyayol,int kacgunsonra,hizmet hizmet, musteri musteri, personel personel)
        {
            List<randevu> randevular = new List<randevu>();
            randevu temp = null;

            using (var filestream = File.Open(dosyayol, FileMode.Open, FileAccess.Read))
            {
                IExcelDataReader reader = ExcelDataReader.ExcelReaderFactory.CreateReader(filestream);
                while (reader.Read())
                {
                    if (Convert.ToDouble(reader[2]) != 0) // Boş mu diye kontrol eder ve yeni verileri listeye ekler
                    {
                        temp = new randevu(kacgunsonra, hizmet, musteri, personel);
                        temp.musteriAdi = Convert.ToString(reader[0]);
                        temp.musteriSoyadi = Convert.ToString(reader[1]);
                        temp.musteriTel = Convert.ToDouble(reader[2]);
                        temp.randevuAdi = Convert.ToString(reader[3]);
                        temp.ucret = Convert.ToDouble(reader[4]);
                        temp.personelAdi = Convert.ToString(reader[5]);
                        temp.randevuTarihi = Convert.ToString(reader[6]);
                        temp.randevuOluşturulmaTarihi = Convert.ToString(reader[7]);
                        randevular.Add(temp);
                    }

                }
            }

            return randevular; // Listeyi döndürür
        }
        public static List<randevu> veriokurandevu(string dosyayol) // Randevu verilerini okumak için kullanılır
        {
            List<randevu> randevular = new List<randevu>();
            randevu temp = null;

            using (var filestream = File.Open(dosyayol, FileMode.Open, FileAccess.Read))
            {
                IExcelDataReader reader = ExcelDataReader.ExcelReaderFactory.CreateReader(filestream);
                while (reader.Read())
                {
                    if (Convert.ToDouble(reader[2]) != 0) // Boş mu diye kontrol eder ve yeni verileri listeye ekler
                    {
                        temp = new randevu();
                        temp.musteriAdi = Convert.ToString(reader[0]);
                        temp.musteriSoyadi = Convert.ToString(reader[1]);
                        temp.musteriTel = Convert.ToDouble(reader[2]);
                        temp.randevuAdi = Convert.ToString(reader[3]);
                        temp.ucret = Convert.ToDouble(reader[4]);
                        temp.personelAdi = Convert.ToString(reader[5]);
                        temp.randevuTarihi = Convert.ToString(reader[6]);
                        temp.randevuOluşturulmaTarihi = Convert.ToString(reader[7]);
                        randevular.Add(temp);
                    }

                }
            }

            return randevular; // Listeyi döndürür
        }

        public static void veriyazrandevu(string dosyayol, List<randevu> randevular) // Randevu verilerini yazmak için kullanılır
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Sheet1");

                // Verileri Excel dosyasına yazar
                for (int i = 0; i < randevular.Count; i++)
                {
                    worksheet.Cell(i + 1, 1).Value = randevular[i].musteriAdi;
                    worksheet.Cell(i + 1, 2).Value = randevular[i].musteriSoyadi;
                    worksheet.Cell(i + 1, 3).Value = randevular[i].musteriTel;
                    worksheet.Cell(i + 1, 4).Value = randevular[i].randevuAdi;
                    worksheet.Cell(i + 1, 5).Value = randevular[i].ucret;
                    worksheet.Cell(i + 1, 6).Value = randevular[i].personelAdi;
                    worksheet.Cell(i + 1, 7).Value = randevular[i].randevuTarihi;
                    worksheet.Cell(i + 1, 8).Value = randevular[i].randevuOluşturulmaTarihi;
                }

                // Dosyayı kaydeder
                workbook.SaveAs(dosyayol);
            }
        }

        // Randevu verilerini düzenlemek için kullanılır
        public static void veriduzenlerandevu(string dosyayol, string eskiAdi, string eskiSoyadi,double eskiTel, string yeniAdi, string yeniSoyadi, double yeniTel, string yeniPersonelAdi, double yeniKacgun, hizmet hizmet)
        {
            // Önce veriyi okur
            List<randevu> randevular = veriokurandevu(dosyayol);

            // Düzenlenecek kişiyi bulur
            randevu duzenlenecekRandevu = randevular.FirstOrDefault(x => x.musteriAdi == eskiAdi && x.musteriSoyadi == eskiSoyadi && x.musteriTel == eskiTel);

            if (duzenlenecekRandevu != null)
            {
                // Kişinin bilgilerini günceller
                duzenlenecekRandevu.musteriAdi = yeniAdi;
                duzenlenecekRandevu.musteriSoyadi = yeniSoyadi;
                duzenlenecekRandevu.musteriTel = yeniTel;
                duzenlenecekRandevu.personelAdi = yeniPersonelAdi;
                duzenlenecekRandevu.randevuAdi = hizmet.hizmetAdi;
                duzenlenecekRandevu.ucret = hizmet.ucret;
                duzenlenecekRandevu.randevuTarihi = Convert.ToString(DateTime.Now.Day + yeniKacgun + "." + DateTime.Now.Month + "." + DateTime.Now.Year);

                // Güncellenmiş verileri dosyasyaya kaydeder
                veriyazrandevu(dosyayol, randevular);
            }
        }
        public static List<hizmet> veriokuhizmet(string dosyayol) // Hizmet verilerini okumak için kullanılır
        {
            List<hizmet> hizmetler = new List<hizmet>();
            hizmet temp = null;

            using (var filestream = File.Open(dosyayol, FileMode.Open, FileAccess.Read))
            {
                IExcelDataReader reader = ExcelDataReader.ExcelReaderFactory.CreateReader(filestream);
                while (reader.Read())
                {
                    if (Convert.ToDouble(reader[1]) != 0) // Boş mu diye kontrol eder ve yeni verileri listeye ekler
                    {
                        temp = new hizmet();
                        temp.hizmetAdi = Convert.ToString(reader[0]);
                        temp.ucret = Convert.ToDouble(reader[1]);
                        hizmetler.Add(temp);
                    }

                }
            }

            return hizmetler; // Listeyi döndürür
        }
        public static List<personel> veriokupersonel(string dosyayol) // Personel verilerini okumak için kullanılır
        {
            List<personel> personeller = new List<personel>();
            personel temp = null;

            using (var filestream = File.Open(dosyayol, FileMode.Open, FileAccess.Read))
            {
                IExcelDataReader reader = ExcelDataReader.ExcelReaderFactory.CreateReader(filestream);
                while (reader.Read())
                {
                    if (Convert.ToDouble(reader[1]) != 0) // Boş mu diye kontrol eder ve yeni verileri listeye ekler
                    {
                        temp = new personel();
                        temp.personelAdi = Convert.ToString(reader[0]);
                        temp.personelTel = Convert.ToDouble(reader[1]);
                        personeller.Add(temp);
                    }

                }
            }

            return personeller; // Listeyi döndürür
        }

    }
}
