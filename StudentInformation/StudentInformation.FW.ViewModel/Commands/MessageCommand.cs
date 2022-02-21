using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentInformation.FW.ViewModel.Commands
{
    public class MessageCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public Action<string> _execute;
        public MessageCommand(Action<string> execute)
            // ctr + k + c  , ctrl + k u       RoutedUICommand
            //: base
            //(
            //    "Exit",
            //    "Exit",
            //    typeof(MessageCommand),
            //    new InputGestureCollection()
            //    {
            //        new KeyGesture(Key.F4, ModifierKeys.Alt)
            //    }
            //)
        {
            _execute = execute;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _execute.Invoke(parameter as string);
        }

    }
}
