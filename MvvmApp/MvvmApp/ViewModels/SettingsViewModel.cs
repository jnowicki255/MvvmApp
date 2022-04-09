using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace MvvmApp.ViewModels
{
    public class SettingsViewModel : BaseViewModel
    {
        private string location;
        public string Location
        {
            get => location;
            set => SetProperty(ref location, value);
        }
        public SettingsViewModel()
        {
            Title = "Settings";
            GetGeolocation().Wait();
        }
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
                    Location = "Location is null";
                }
            }
            catch (Exception ex)
            {
                Location = $"Cannot read location {ex.ToString()}";
            }
        }
    }
}
