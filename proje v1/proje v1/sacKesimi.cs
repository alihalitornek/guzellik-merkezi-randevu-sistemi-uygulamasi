﻿using form_proje_v1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje_v1
{
    class sacKesimi : hizmet, IHizmet
    {
        public override string hizmetAdi { get; set; } = "saçkesimi";
        public override double ucret { get; set; } = 100;
        public sacKesimi()
        {
        }
    }
}
