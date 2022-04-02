using MvvmApp.Services;
using MvvmApp.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmApp
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
        }

        protected override void OnStart()
        {
            Shell.Current.GoToAsync("//LoginPage").Wait();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
