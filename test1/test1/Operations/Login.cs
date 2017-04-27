using System;
using System.Windows.Input;

namespace test1.Operations
{
    public class Login : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            //throw new NotImplementedException();
            return true;
        }

        public void Execute(object parameter)
        {
            
        }
    }
}
