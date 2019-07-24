using Fundusz.DAL;
using System.Windows.Input;

namespace Fundusz.ModelWidoku
{
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

        #endregion

        public void Testowy() {
            Widoki.Testowy testPozyczki = new Widoki.Testowy(this);
            testPozyczki.ShowDialog();
        }
    }
}
