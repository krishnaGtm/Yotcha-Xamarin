using System;
using test1.ViewModel.Abstracts;

namespace test1.ViewModel
{
    class signUPViewModel: NotifyPropChange
    {
        private string _firstName;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; OnPropertyChanged(); }
        }
        private string _lastName;

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; OnPropertyChanged(); }
        }

        public bool IsUser { get; set; }
        public bool IsAgent { get; set; }
        private DateTime _dob;
        public DateTime DOB
        {
            get { return _dob; }
            set { _dob = value; OnPropertyChanged(); }
        }

        private string _email;

        public string Email
        {
            get { return _email; }
            set { _email = value; OnPropertyChanged(); }
        }
        public string PhoneCode { get; set; }

        private int _mobNumber;
        public int MobNumber
        {
            get { return _mobNumber; }
            set { _mobNumber = value; OnPropertyChanged(); }
        }
        private string _password;

        public string Password
        {
            get { return _password; }
            set { _password = value; OnPropertyChanged(); }
        }
        private string _passwordVerify;

        public string PasswordVerity
        {
            get { return _passwordVerify; }
            set { _passwordVerify = value; OnPropertyChanged(); }
        }
        private string _ceaNumber;

        public string CEANumber
        {
            get { return _ceaNumber; }
            set { _ceaNumber = value; OnPropertyChanged(); }
        }


    }
}
