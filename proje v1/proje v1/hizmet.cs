using proje_v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace form_proje_v1
{
    class hizmet : IHizmet
    {
        public virtual string hizmetAdi { get; set; }
        public virtual double ucret { get; set; }

       
    }
}
