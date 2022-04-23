using MvvmApp.ViewModels;
using System;
using Xamarin.Forms;

namespace MvvmApp
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            this.Navigated += OnNavigated;
            this.Navigating += OnNavigating;
        }

        private void OnNavigating(object sender, ShellNavigatingEventArgs e)
        {
            var context = Shell.Current.CurrentPage.BindingContext;
            var viewModel = context != null ? context as BaseViewModel : null;
            viewModel?.OnNavigatedFrom();
        }

        private void OnNavigated(object sender, ShellNavigatedEventArgs e)
        {
            var context = Shell.Current.CurrentPage.BindingContext;
            var viewModel = context != null ? context as BaseViewModel : null;
            viewModel?.OnNavigatedTo();
        }

        private async void OnMenuItemClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("//LoginPage");
        }
    }
}
