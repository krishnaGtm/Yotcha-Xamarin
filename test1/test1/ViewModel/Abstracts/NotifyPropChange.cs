using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace test1.ViewModel.Abstracts
{
    public abstract class NotifyPropChange : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
