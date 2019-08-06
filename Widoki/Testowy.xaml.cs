using System.Windows;

namespace Fundusz.Widoki {
    public partial class Testowy : Window {
        public Testowy() {
            InitializeComponent();
        }

        private void ZamknijButton_Click(object sender, RoutedEventArgs e) {
            Close();
        }
    }
}
