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
    public partial class musterikontrol : UserControl
    {
        public musterikontrol()
        {
            InitializeComponent();
            List<musteri> liste = veriislemleri.verioku("C:\\Users\\technopc\\source\\repos\\proje v1\\proje v1\\musteriler.xlsx");
            dataGridView1.DataSource = liste; // Ekrana veriyi yazar
        }

    }
    
}
