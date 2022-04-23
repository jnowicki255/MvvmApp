using MvvmApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EpisodesPage : ContentPage
    {
        public EpisodesPage()
        {
            InitializeComponent();
            BindingContext = new EpisodesViewModel();
        }
    }
}