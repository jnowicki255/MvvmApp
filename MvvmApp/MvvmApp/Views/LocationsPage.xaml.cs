using MvvmApp.ViewModels;
using MvvmApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

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