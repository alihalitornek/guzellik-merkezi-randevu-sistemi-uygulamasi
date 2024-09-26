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
    public partial class hizmetkontrol : UserControl
    {
        public hizmetkontrol()
        {
            InitializeComponent();
            List<hizmet> liste = veriislemleri.veriokuhizmet("C:\\Users\\technopc\\source\\repos\\proje v1\\proje v1\\hizmetler.xlsx");
            dataGridView1.DataSource = liste; // Ekrana veriyi yazar
        }
    }
    
}
