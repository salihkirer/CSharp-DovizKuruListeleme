using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DovizKuruAPI.DovizModel;

namespace DovizKuruAPI
{
    public class DovizModel
    {
        public class GramAltin
        {
            public string satis { get; set; }
            public string alis { get; set; }
            public string degisim { get; set; }
        }

        public class Bitcoin
        {
            public string satis { get; set; }
            public string alis { get; set; }
            public string degisim { get; set; }
        }

        public class Dolar
        {
            public string satis { get; set; }
            public string alis { get; set; }
            public string degisim { get; set; }
        }

        public class Euro
        {
            public string satis { get; set; }
            public string alis { get; set; }
            public string degisim { get; set; }
        }

        public class Doviz
        {
            public GramAltin GA { get; set; }
            public Bitcoin BTC { get; set; }
            public Dolar USD { get; set; }
            public Euro EUR { get; set; }
        }
    }
}
