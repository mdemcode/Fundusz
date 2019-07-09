using System;
using System.Globalization;
using System.Windows.Data;

namespace Fundusz
{
    public class SumaSkladowychKonwerter : IMultiValueConverter {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture) {
            var gotowka = (decimal)values[0];
            var pozyczki = (decimal)values[1];
            var lokaty = (decimal)values[2];
            var inne = (decimal)values[3];
            return (gotowka + pozyczki + lokaty + inne).ToString() + " zł";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
