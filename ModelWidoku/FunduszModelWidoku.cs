using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Fundusz.DAL;

namespace Fundusz.ModelWidoku {
    public class FunduszModelWidoku : Powiadomienia {

        private readonly FunduszModel.Fundusz daneFunduszu; 

        public decimal Gotowka {
            get {
                return daneFunduszu.Gotowka;
            }
            set {
                daneFunduszu.Gotowka = value;
                OnPropertyChanged(nameof(Gotowka), nameof(LacznaKwota));
            }
        }
        public decimal Pozyczki {
            get {
                return daneFunduszu.Pozyczki;
            }
            set {
                daneFunduszu.Pozyczki = value;
                OnPropertyChanged(nameof(Pozyczki), nameof(LacznaKwota));
            }
        }
        public decimal Lokaty {
            get {
                return daneFunduszu.Lokaty;
            }
            set {
                daneFunduszu.Lokaty = value;
                OnPropertyChanged(nameof(Lokaty), nameof(LacznaKwota));
            }
        }
        public decimal InneInwestycje { 
            get {
                return daneFunduszu.InneInwestycje;
            }
            set {
                daneFunduszu.InneInwestycje = value;
                OnPropertyChanged(nameof(InneInwestycje), nameof(LacznaKwota));
            }
        }
        public decimal LacznaKwota {
            get {
                return daneFunduszu.Gotowka 
                        + daneFunduszu.Pozyczki 
                        + daneFunduszu.Lokaty 
                        + daneFunduszu.InneInwestycje;
            }
        }

        //KONSTRUKTOR
        public FunduszModelWidoku() {
            daneFunduszu = FunduszDAL.DaneFunduszu.CzytajDane();
        }

        public void Testowy() {
            Widoki.Testowy testPozyczki = new Widoki.Testowy(this);
            testPozyczki.ShowDialog();
        }
    }
}
