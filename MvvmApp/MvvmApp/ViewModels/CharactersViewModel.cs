using MvvmApp.Models;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MvvmApp.ViewModels
{
    public class CharactersViewModel : BaseViewModel
    {
        private ApiResponse<Character> characters;

        public ApiResponse<Character> Characters
        {
            get => characters;
            set => SetProperty(ref characters, value);
        }

        public override void OnNavigatedTo()
        {
            LoadCharacters();
        }

        public override void OnNavigatedFrom()
        {
            base.OnNavigatedFrom();
        }

        private async Task LoadCharacters()
        {
            try
            {
                var response = await apiClient.GetAsync
                    ("https://rickandmortyapi.com/api/character");

                if (response.IsSuccessStatusCode)
                {
                    var str = await response.Content.ReadAsStringAsync();
                    Characters = await response.Content
                        .ReadAsAsync<ApiResponse<Character>>();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}