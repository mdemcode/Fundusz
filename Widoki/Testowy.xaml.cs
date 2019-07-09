using Fundusz.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Fundusz.Widoki
{
    /// <summary>
    /// Interaction logic for Testowy.xaml
    /// </summary>
    public partial class Testowy : Window {

        private readonly ModelWidoku.FunduszModelWidoku daneFunduszu;

        public Testowy(ModelWidoku.FunduszModelWidoku dane) {
            InitializeComponent();
            daneFunduszu = dane;
        }

        private void ZamknijButton_Click(object sender, RoutedEventArgs e) {
            Close();
        }

        private void ZmienKwoteButton_Click(object sender, RoutedEventArgs e) {
            //FunduszModel.Fundusz daneFunduszu = FunduszDAL.DaneFunduszu.CzytajDane();
            daneFunduszu.Gotowka = 1000m;
            daneFunduszu.Pozyczki = 2000m;
            daneFunduszu.Lokaty = 3000m;
            daneFunduszu.InneInwestycje = 4000m;
        }
    }
}
