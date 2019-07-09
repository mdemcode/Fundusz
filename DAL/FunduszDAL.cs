using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FunduszModel;

//DO ZMIANY -> ODCZYT / ZAPIS danych do bazy

namespace Fundusz.DAL {
    public sealed class FunduszDAL {

        private static FunduszDAL _daneFunduszu = null;
        public static FunduszDAL DaneFunduszu {
            get {
                if (_daneFunduszu == null) {
                    _daneFunduszu = new FunduszDAL();
                }
                return _daneFunduszu;
            }
        }
        private FunduszDAL() {
            //Konstruktor blokujący możliwość utworzenia obiektu FunduszDAL w normalny sposob (wzorzec SINGLETON) (?? chyba :) )
        }

        public FunduszModel.Fundusz CzytajDane() {
            var dane = new FunduszModel.Fundusz();
            if (File.Exists(@"C:\Users\Michael_\Desktop\daneFunduszu.txt")) {
                var zPliku = File.ReadAllLines(@"C:\Users\Michael_\Desktop\daneFunduszu.txt");
                dane.Gotowka = decimal.Parse(zPliku[0]);
                dane.Pozyczki = decimal.Parse(zPliku[1]);
                dane.Lokaty = decimal.Parse(zPliku[2]);
                dane.InneInwestycje = decimal.Parse(zPliku[3]);
            }
            else {
                dane.Gotowka = 0m;
                dane.Pozyczki = 0m;
                dane.Lokaty = 0m;
                dane.InneInwestycje = 0m;
            }
            return dane;
        }

        public void ZapiszDane(FunduszModel.Fundusz noweDane) {
            string[] dane = new string[4];
            dane[0] = noweDane.Gotowka.ToString();
            dane[1] = noweDane.Pozyczki.ToString();
            dane[2] = noweDane.Lokaty.ToString();
            dane[3] = noweDane.InneInwestycje.ToString();
            File.WriteAllLines(@"C:\Users\Michael_\Desktop\daneFunduszu.txt", dane);
        }
    }
}
