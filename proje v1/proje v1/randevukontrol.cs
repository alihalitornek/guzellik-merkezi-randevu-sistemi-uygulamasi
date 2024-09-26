using form_proje_v1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje_v1
{
    public partial class randevukontrol : UserControl
    {

        public randevukontrol()
        {
            InitializeComponent();
            
            
            List<randevu> liste = veriislemleri.veriokurandevu("C:\\Users\\technopc\\source\\repos\\proje v1\\proje v1\\randevular.xlsx");
            dataGridView1.DataSource = liste; // Ekrana veriyi yazar
        }
        
        private void ekle_Click(object sender, EventArgs e)
        {

            try // Olası hatalar için
            {
                string musteriadi = Convert.ToString(musteriAdi.Text);
                string musterisoyadi = Convert.ToString(musteriSoyadi.Text);
                double musteritel = Convert.ToDouble(musteriTelefonu.Text);

                if (musteritel < 6000000000 && musteritel > 5000000000) // Tel no kontrolü
                {
                    hizmet hizmet = null;

                    musteri musteri = new musteri(musteriadi, musterisoyadi, musteritel);

                    string personeladi = Convert.ToString(personelAdi.Text);

                    personel personel = new personel(personeladi);
                    int kacGun = Convert.ToInt32(kacgun.SelectedItem);

                    // Mevcut verileri yükle
                    string dosyayol = "C:\\Users\\technopc\\source\\repos\\proje v1\\proje v1\\randevular.xlsx";

                    // Mevcut verileri yükle
                    string dosyayol2 = "C:\\Users\\technopc\\source\\repos\\proje v1\\proje v1\\musteriler.xlsx";
                    List<musteri> musteriler = veriislemleri.verioku(dosyayol2); // Listeye ekle

                    switch (Convert.ToString(hizmetAdi.SelectedItem)) // Hangi hizmet türü seçilmiş ise o hizmet oluşturulur
                    {
                        case "sacBoyama":
                            hizmet = new sacBoyama();
                            break;
                        case "sacKesimi":
                            hizmet = new sacKesimi();
                            break;
                        case "makyaj":
                            hizmet = new makyaj();
                            break;
                    }

                    // Veriler dolu mu
                    if (kacGun != 0 && hizmet != null && musteri != null && personel != null && musteriadi != "" && musterisoyadi != "" && musteritel != 0)
                    {
                        // Listeye ekle
                        List<randevu> randevular = veriislemleri.veriokurandevu(dosyayol, kacGun, hizmet, musteri, personel);

                        // Yeni randevuyu listeye ekle
                        randevular.Add(new randevu(kacGun, hizmet, musteri, personel));

                        // Yeni kişiyi listeye ekle
                        musteriler.Add(new musteri { musteriAdi = musteriadi, musteriSoyadi = musterisoyadi, musteriTel = musteritel });

                        // Verileri dosyaya yaz
                        veriislemleri.veriyaz(dosyayol2, musteriler);

                        // Verileri dosyaya yaz
                        veriislemleri.veriyazrandevu(dosyayol, randevular);

                        // Ekranı güncelle
                        dataGridView1.DataSource = randevular;

                        // Bildirim mesajı
                        MessageBox.Show("Kişi başarıyla kaydedildi");

                        Application.Restart();
                    }
                    else
                    {
                        MessageBox.Show("Lütfen geçerli bir seçim yapınız"); // Bildirim mesajı
                    }
                    
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir telefon numarası giriniz"); // Bildirim mesajı
                }
            }
            catch { MessageBox.Show("Lütfen geçerli bir seçim yapınız"); } // Bildirim mesajı


        }

        private void sil_Click(object sender, EventArgs e)
        {
            try // Olası hatalar için
            {
                string musteriadi = Convert.ToString(musteriAdi.Text);
                string musterisoyadi = Convert.ToString(musteriSoyadi.Text);
                double musteritel = Convert.ToDouble(musteriTelefonu.Text);

                string dosyayol = "C:\\Users\\technopc\\source\\repos\\proje v1\\proje v1\\randevular.xlsx";
                string dosyayol2 = "C:\\Users\\technopc\\source\\repos\\proje v1\\proje v1\\musteriler.xlsx";

                List<randevu> randevular = veriislemleri.veriokurandevu(dosyayol); // Listeleri oluştur
                List<musteri> musteriler = veriislemleri.verioku(dosyayol2);

                // Adı, soyadı ve tel no eşleşen randevuyu ve kişiyi bulalım
                randevu silinecekRandevu = randevular.FirstOrDefault(x => x.musteriAdi == musteriadi && x.musteriSoyadi == musterisoyadi && x.musteriTel == musteritel);
                musteri silinecekMusteri = musteriler.FirstOrDefault(x => x.musteriAdi == musteriadi && x.musteriSoyadi == musterisoyadi && x.musteriTel == musteritel);

                if (silinecekRandevu != null) // Randevu var mı
                {
                    // Kişiyi listeden kaldır
                    randevular.Remove(silinecekRandevu);
                    musteriler.Remove(silinecekMusteri);

                    // Ekranı güncelle
                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = randevular;

                    // Güncellenmiş verileri dosyaya kaydeder
                    veriislemleri.veriyazrandevu(dosyayol, randevular);
                    veriislemleri.veriyaz(dosyayol2, musteriler);

                    MessageBox.Show("Kişi başarıyla silindi");// Bildirim mesajı

                    Application.Restart();
                }
                else
                {
                    MessageBox.Show("Silinecek kişi bulunamadı"); // Bildirim mesajı
                }
            }
            catch { MessageBox.Show("Lütfen geçerli bir seçim yapınız"); } // Bildirim mesajı

        }

        private void düzenle_Click(object sender, EventArgs e)
        {
            try // Olası hatalar için
            {
                // Metin kutularından güncellenecek verileri al
                string eskimusteriadi = eskimusteriAdi.Text;
                string eskimusterisoyadi = eskimusteriSoyadi.Text;
                double eskimusteritel = Convert.ToDouble(eskimusteriTel.Text);
                string yeniAdi = musteriAdi.Text;
                string yeniSoyadi = musteriSoyadi.Text;
                double yeniTel = 0;
                string yeniPersoneladi = personelAdi.Text;
                double yeniKacgun = Convert.ToDouble(kacgun.Text);
  
                try
                {
                    yeniTel = Convert.ToDouble(musteriTelefonu.Text); // Yeni tel girmediyse eskisi kullanılsındiye bu şekilde yazıldı
                }
                catch { }

                
                if ( yeniAdi == "" && yeniSoyadi == "" && yeniTel == 0) // Eğer yeni ad, soyad ve tel girilmediyse zaten var olan eski verileri kullanabilir
                {
                    yeniAdi = eskimusteriadi;
                    yeniSoyadi = eskimusterisoyadi;
                    yeniTel = eskimusteritel;
                }

                // Bütün veriler tam olarak alındı mı
                if (eskimusteriadi != "" && eskimusterisoyadi != "" && eskimusteritel != 0 && yeniAdi != "" && yeniSoyadi != "" && yeniTel != 0 && yeniPersoneladi != "" && yeniKacgun != 0)
                {
                    string dosyayolkontrol = "C:\\Users\\technopc\\source\\repos\\proje v1\\proje v1\\randevular.xlsx";
                    List<randevu> randevularkontrol = veriislemleri.veriokurandevu(dosyayolkontrol); // Listeyi oluştur


                    if (yeniTel < 6000000000 && yeniTel > 5000000000) // Tel no kontrolü
                    {
                        // Adı, soyadı ve tel no eşleşen kişiyi bulalım
                        randevu silinecekRandevu = randevularkontrol.FirstOrDefault(x => x.musteriAdi == eskimusteriadi && x.musteriSoyadi == eskimusterisoyadi && x.musteriTel == eskimusteritel);

                        if (silinecekRandevu != null) // Randevu var mı
                        {
                            hizmet hizmet = null;

                            switch (hizmetAdi.Text) // Hangi hizmet türü seçilmiş ise o hizmet oluşturulur
                            {
                                case "sacBoyama":
                                    hizmet = new sacBoyama();
                                    break;
                                case "sacKesimi":
                                    hizmet = new sacKesimi();
                                    break;
                                case "makyaj":
                                    hizmet = new makyaj();
                                    break;
                            }

                            // Dosya yolunu belirt
                            string dosyayol = "C:\\Users\\technopc\\source\\repos\\proje v1\\proje v1\\randevular.xlsx";
                            string dosyayol2 = "C:\\Users\\technopc\\source\\repos\\proje v1\\proje v1\\musteriler.xlsx";

                            // Veriyi düzenle
                            veriislemleri.veriduzenlerandevu(dosyayol, eskimusteriadi, eskimusterisoyadi, eskimusteritel, yeniAdi, yeniSoyadi, yeniTel, yeniPersoneladi, yeniKacgun, hizmet);
                            veriislemleri.veriduzenle(dosyayol2, eskimusteriadi, eskimusterisoyadi, eskimusteritel, yeniAdi, yeniSoyadi, yeniTel);

                            // Bildirim göster
                            MessageBox.Show("Kişi başarıyla güncellendi"); // Bildirim mesajı

                            List<randevu> randevular = veriislemleri.veriokurandevu(dosyayol); // Listeyi oluştur

                            // Ekranı güncelle
                            dataGridView1.DataSource = null;
                            dataGridView1.DataSource = randevular;

                            Application.Restart();
                        }
                        else
                        {
                            MessageBox.Show("Düzenlenecek kişi bulunamadı"); // Bildirim mesajı
                        }

                    }
                    else
                    {
                        MessageBox.Show("Lütfen geçerli bir telefon numarası giriniz"); // Bildirim mesajı
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir seçim yapınız"); // Bildirim mesajı
                }


            }
            catch { MessageBox.Show("Lütfen geçerli bir seçim yapınız"); } // Bildirim mesajı


        }

        private void musteriAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Sadece harf ve boşluk tuşlarına izin ver
            }
        }

        private void musteriSoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Sadece harf ve boşluk tuşlarına izin ver
            }
        }

        private void musteriTelefonu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Sadece rakam tuşlarına izin ver
            }
        }

        private void eskimusteriAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Sadece harf ve boşluk tuşlarına izin ver
            }
        }

        private void eskimusteriSoyadi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true; // Sadece harf ve boşluk tuşlarına izin ver
            }
        }

        private void eskimusteriTel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Sadece rakam tuşlarına izin ver
            }
        }
    }
}
