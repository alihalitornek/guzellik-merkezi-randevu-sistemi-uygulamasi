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
    public partial class personelkontrol : UserControl
    {
        public personelkontrol()
        {
            InitializeComponent();
            List<personel> liste = veriislemleri.veriokupersonel("C:\\Users\\technopc\\source\\repos\\proje v1\\proje v1\\personeller.xlsx");
            dataGridView1.DataSource = liste; // Ekrana veriyi yazar
        }
    }
}
