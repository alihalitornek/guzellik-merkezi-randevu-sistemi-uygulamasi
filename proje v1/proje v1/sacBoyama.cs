using form_proje_v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_v1
{
    class sacBoyama : hizmet, IHizmet
    {
        public override string hizmetAdi { get; set; } = "saçboyama";
        public override double ucret { get; set; } = 200;
        public sacBoyama()
        {
        }
    }
}
