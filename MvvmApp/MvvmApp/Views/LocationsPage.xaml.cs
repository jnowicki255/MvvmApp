using MvvmApp.ViewModels;
using Xamarin.Forms;

namespace MvvmApp.Views
{
    public partial class LocationsPage : ContentPage
    {
        LocationsViewModel _viewModel;

        public LocationsPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new LocationsViewModel();
        }
    }
}