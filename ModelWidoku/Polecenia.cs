using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fundusz.ModelWidoku
{
    public class Polecenia : ICommand {

        public event EventHandler CanExecuteChanged {
            add {
                if (_canExecute != null) CommandManager.RequerySuggested += value;
            }
            remove {
                if (_canExecute != null) CommandManager.RequerySuggested -= value;
            }
        }
        readonly Action<object> _execute;
        readonly Predicate<object> _canExecute;

        //KONSTRUKTOR
        public Polecenia(Action<object> execute, Predicate<object> canExecute = null) {
            _execute = execute ?? throw new ArgumentNullException(nameof(execute));
            _canExecute = canExecute;
        }

        public bool CanExecute(object parameter) {
            return _canExecute == null ? true: _canExecute(parameter);
        }

        public void Execute(object parameter) {
            _execute(parameter);
        }
    }
}
