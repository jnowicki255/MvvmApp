using MvvmApp.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace MvvmApp.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}