using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace test1.Operations
{
    public class SignUp : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            //throw new NotImplementedException();
            return true;
        }

        public void Execute(object parameter)
        {
            //throw new NotImplementedException();
        }
    }
}
