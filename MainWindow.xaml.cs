using System.Windows;

namespace Fundusz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ZamknijButton_Click(object sender, RoutedEventArgs e)
        {
            //var dane = Resources["daneFunduszu"] as FunduszModelWidoku;
            //FunduszDAL.DaneFunduszu.ZapiszDane(dane.daneFunduszu);
            Close();
        }

    }
}
