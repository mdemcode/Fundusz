using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunduszModel;

namespace Fundusz.DAL {
    public sealed class FunduszDAL {

        public FunduszModel.Fundusz DaneFunduszu {
            get {
                return CzytajDane();
            }
            set {
                ZapiszDane(value);
            }
        }

        private static FunduszDAL _instancja = null;
        public static FunduszDAL Instancja {
            get {
                if (_instancja == null) {
                    _instancja = new FunduszDAL();
                }
                return _instancja;
            }
        }
        private FunduszDAL() {
            //Konstruktor blokujący możliwość utworzenia obiektu FunduszDAL w normalny sposob (wzorzec SINGLETON)
        }

        public FunduszModel.Fundusz CzytajDane() {
            var dane = new FunduszModel.Fundusz();
            dane.Pozyczki = 90000;
            dane.Lokaty = 111000;
            dane.Gotowka = 5000;
            dane.InneInwestycje = 123000;
                //TODO
            return dane; 
        }
        public void ZapiszDane(FunduszModel.Fundusz daneFunduszu) {
            
        }
    }
}
