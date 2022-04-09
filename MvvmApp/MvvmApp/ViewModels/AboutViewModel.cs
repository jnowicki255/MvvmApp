using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace MvvmApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private string location;
        public string Location
        {
            get => location;
            set => SetProperty(ref location, value);
        }

        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await GetGeolocation());
        }

        public ICommand OpenWebCommand { get; }

        public async Task GetGeolocation()
        {
            try
            {
                var location = await Geolocation.GetLastKnownLocationAsync();

                if (location != null)
                {
                    Location = $"Latitute: {location.Latitude}, " +
                        $"Longtitude: {location.Longitude}, " +
                        $"Altitude: {location.Altitude}";
                }
                else
                {
                    Location = $"Cannot read location - is null";
                }
            }
            catch (Exception ex)
            {
                Location = $"Cannot read location {ex.ToString()}";
            }
        }
    }
}