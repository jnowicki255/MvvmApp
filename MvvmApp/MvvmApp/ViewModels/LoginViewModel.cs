using MvvmApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace MvvmApp.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string username;
        private string secret;

        public Command LoginCommand { get; }

        public string Username
        {
            get => username;
            set => SetProperty(ref username, value);
        }

        public string Secret
        {
            get => secret;
            set => SetProperty(ref secret, value);
        }

        public LoginViewModel()
        {
            LoginCommand = new Command(OnLoginClicked);
        }

        private async void OnLoginClicked(object obj)
        {
            if (Username == "tester" && Secret == "123")
            {
                // Prefixing with `//` switches to a different navigation stack instead of pushing to the active one
                await Shell.Current.GoToAsync($"//{nameof(CharactersPage)}");
            }
        }
    }
}
