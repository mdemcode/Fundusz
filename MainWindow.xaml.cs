using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Fundusz.DAL;
using Fundusz.ModelWidoku;

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
            Close();
        }

        private void TestButton_Click(object sender, RoutedEventArgs e)
        {
            var daneFun = new FunduszModel.Fundusz {
                Gotowka = 111m,
                Pozyczki = 222m,
                Lokaty = 333m,
                InneInwestycje = 444m
            };
            FunduszDAL.DaneFunduszu.ZapiszDane(daneFun);
        }
    }
}
