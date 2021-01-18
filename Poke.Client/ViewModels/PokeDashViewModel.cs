using System;
using System.Collections.ObjectModel;
using System.Linq;
using Poke.Client.Models;
using Poke.Client.Services;

namespace Poke.Client.ViewModels
{
    public class PokeDashViewModel : NotificationEnabledObject
    {
        public PokeDashViewModel()
        {
            OnAppearing();
        }

        private async void OnAppearing()
        {
            var listPoke = await PokemonService.GetPokemonAsync(20, 20);
            var listPokeModel = listPoke.Select(x =>
            {
                var pokenModel = new PokemonModel(x);
                if (x.Url != null)
                {
                    var buffer = x.Url.Split('/');
                    var number = buffer[buffer.Length - 2];
                    pokenModel.PokeId = number;
                    pokenModel.UriImage = PokemonService.GetPokeImage(Convert.ToInt32(number));
                }
                return pokenModel;
            });
            PokemonList = new ObservableCollection<PokemonModel>(listPokeModel);
        }

        private ObservableCollection<PokemonModel> _PokemonList;
        public ObservableCollection<PokemonModel> PokemonList
        {
            get => _PokemonList;
            set => Set(ref _PokemonList, value);
        }

        private PokemonService _PokemonService;
        public PokemonService PokemonService
        {
            get => _PokemonService = _PokemonService ?? new PokemonService();
        }
    }
}
