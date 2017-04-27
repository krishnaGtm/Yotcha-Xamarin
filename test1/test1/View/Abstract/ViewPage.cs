using Xamarin.Forms;

namespace test1.View.Abstract
{
    public class ViewPage<TViewModel>:ContentPage
    {
        public TViewModel ViewModel => (TViewModel)BindingContext;
    }
}
