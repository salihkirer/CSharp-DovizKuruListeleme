using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DovizKuruAPI
{
    public class DovizModel
    {
        public class GA
        {
            public string satis { get; set; }
            public string alis { get; set; }
            public string degisim { get; set; }
        }

        public class BTC
        {
            public string satis { get; set; }
            public string alis { get; set; }
            public string degisim { get; set; }
        }

        public class USD
        {
            public string satis { get; set; }
            public string alis { get; set; }
            public string degisim { get; set; }
        }

        public class EUR
        {
            public string satis { get; set; }
            public string alis { get; set; }
            public string degisim { get; set; }
        }

        public class Altin
        {
            public GA GA { get; set; }
            public BTC BTC { get; set; }
            public USD USD { get; set; }
            public EUR EUR { get; set; }
        }
    }
}
