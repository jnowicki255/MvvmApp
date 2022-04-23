using MvvmApp.ViewModels;
using Xamarin.Forms;

namespace MvvmApp.Views
{
    public partial class CharactersPage : ContentPage
    {
        public CharactersPage()
        {
            InitializeComponent();
            BindingContext = new CharactersViewModel();
        }
    }
}