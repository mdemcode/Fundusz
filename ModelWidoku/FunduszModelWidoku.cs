using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fundusz.DAL;
using System.IO;

namespace Fundusz.ModelWidoku {
    public class FunduszModelWidoku {
        public string Gotowka { get; set; }
        public string Pozyczki { get; set; }
        public string Lokaty { get; set; }
        public string InneInwestycje { get; set; }
        public string LacznaKwota { get; set; }

        public FunduszModelWidoku() {
            var daneFunduszu = FunduszDAL.Instancja.DaneFunduszu;
            Gotowka = daneFunduszu.Gotowka.ToString() + " zł";
            Pozyczki = daneFunduszu.Pozyczki.ToString() + " zł";
            Lokaty = daneFunduszu.Lokaty.ToString() + " zł";
            InneInwestycje = daneFunduszu.InneInwestycje.ToString() + " zł";
            var suma = daneFunduszu.Gotowka + daneFunduszu.Pozyczki + daneFunduszu.Lokaty + daneFunduszu.InneInwestycje;
            LacznaKwota = suma.ToString() + "zł";
        }
    }
}
