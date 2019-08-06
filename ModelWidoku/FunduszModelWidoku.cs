using Fundusz.DAL;
using System.Windows;
using System.Windows.Input;

namespace Fundusz.ModelWidoku {
    public class FunduszModelWidoku : Powiadomienia.Powiadomienia {

        private readonly FunduszModel.Fundusz daneFunduszu = FunduszDAL.DaneFunduszu.CzytajDane();

        public decimal Gotowka {
            get {
                return daneFunduszu.Gotowka;
            }
            set {
                daneFunduszu.Gotowka = value;
                OnPropertyChanged(nameof(Gotowka));
            }
        }
        public decimal Pozyczki {
            get {
                return daneFunduszu.Pozyczki;
            }
            set {
                daneFunduszu.Pozyczki = value;
                OnPropertyChanged(nameof(Pozyczki));
            }
        }
        public decimal Lokaty {
            get {
                return daneFunduszu.Lokaty;
            }
            set {
                daneFunduszu.Lokaty = value;
                OnPropertyChanged(nameof(Lokaty));
            }
        }
        public decimal InneInwestycje { 
            get {
                return daneFunduszu.InneInwestycje;
            }
            set {
                daneFunduszu.InneInwestycje = value;
                OnPropertyChanged(nameof(InneInwestycje));
            }
        }

        #region POLECENIA
        private ICommand polecenieTestowe;
        public ICommand PolecenieTestowe {
            get {
                if (polecenieTestowe==null) {
                    polecenieTestowe = new Polecenia(argument => { Testowy(); }, argument => { return true; } );
                }
                return polecenieTestowe;
            }
        }

        private ICommand polecenieTest;
        public ICommand PolecenieTest {
            get {
                if (polecenieTest == null) {
                    polecenieTest = new Polecenia(argument => { Test2(); }, argument => { return true; });
                }
                return polecenieTest;
            }
        }
        #endregion

        public void Test2() {
            MessageBox.Show("Zmieniam dane");
            Gotowka = 1000m;
            Pozyczki = 2000m;
            Lokaty = 3000m;
            InneInwestycje = 4000m;
        }

        public void Testowy() {
            Widoki.Testowy testPozyczki = new Widoki.Testowy();
            testPozyczki.ShowDialog();
        }
    }
}
