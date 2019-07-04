using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fundusz.DAL;

namespace Fundusz.ModelWidoku {
    public class FunduszModelWidoku {
        public decimal Gotowka { get; set; }
        public decimal Pozyczki { get; set; }
        public decimal Lokaty { get; set; }
        public decimal InneInwestycje { get; set; }

        public FunduszModelWidoku() {
            var daneFunduszu = FunduszDAL.Instancja.DaneFunduszu;
            Gotowka = daneFunduszu.Gotowka;
            Pozyczki = daneFunduszu.Pozyczki;
            Lokaty = daneFunduszu.Lokaty;
            InneInwestycje = daneFunduszu.InneInwestycje;
        }
    }
}
