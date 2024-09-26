/****************************************************************************
**					    SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					    2023-2024 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: 1.Proje
**				ÖĞRENCİ ADI............: Ali Halit ÖRNEK
**				ÖĞRENCİ NUMARASI.......: B231210385
**              DERSİN ALINDIĞI GRUP...: B
****************************************************************************/
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            randevukontrol1.BringToFront();
        }

        private void randevu_Click(object sender, EventArgs e)
        {
            randevukontrol1.BringToFront(); // Randevu ekranı öne gelir
        }

        private void musteriler_Click(object sender, EventArgs e)
        {
            musterikontrol1.BringToFront(); // Müsteri ekranı öne gelir
        }

        private void personel_Click(object sender, EventArgs e)
        {
            personelkontrol1.BringToFront(); // Personel ekranı öne gelir

        }

        private void hizmetler_Click(object sender, EventArgs e)
        {
            hizmetkontrol1.BringToFront(); // Hizmet ekranı öne gelir
        }
    }
}
