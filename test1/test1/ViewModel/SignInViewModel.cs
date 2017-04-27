using System.Windows.Input;
using test1.Operations;
using test1.ViewModel.Abstracts;
using Xamarin.Forms;

namespace test1.ViewModel
{
    public class SignInViewModel : NotifyPropChange
    {
        private string _userName;

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                OnPropertyChanged();
            }
        }
        private string _password;

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }
        public ICommand SignInCommand {get;set;}
        public ICommand GotoSignUP { get; set; }
        public SignInViewModel()
        {
            SignInCommand = new Login();
            //GotoSignUP = new NavigateSignup();
            GotoSignUP = new Command(() =>
            {
                App.Navigation.PushAsync(new View.SignUp());
            });

        }
    }
}
