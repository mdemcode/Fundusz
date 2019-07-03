using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunduszModel;

namespace Fundusz.DAL
{
    public sealed class FunduszDAL
    {
        public double Gotowka { get; set; }
        public double Pozyczki { get; set; }
        public double Lokaty { get; set; }
        public double InneInwestycje { get; set; }

        private static FunduszDAL _daneFunduszu = null;
        public FunduszDAL DaneFunduszu {
            get {
                if (_daneFunduszu == null) {
                    _daneFunduszu = new FunduszDAL();
                }
                return _daneFunduszu;
            }
        }
        private FunduszDAL() {
            //Konstruktor blokujący możliwość utworzenia obiektu FunduszDAL w normalny sposob (wzorzec SINGLETON)
        }
        public void CzytajDane()
        {

        }
        public void ZapiszDane()
        {

        }
    }
}
