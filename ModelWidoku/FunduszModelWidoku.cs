using Fundusz.DAL;

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

        public void Testowy() {
            Widoki.Testowy testPozyczki = new Widoki.Testowy(this);
            testPozyczki.ShowDialog();
        }
    }
}
