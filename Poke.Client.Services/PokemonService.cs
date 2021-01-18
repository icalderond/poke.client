using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Poke.Client.Models;

namespace Poke.Client.Services
{
    public class PokemonService : WebApiBase
    {
        public async Task<IList<Pokemon>> GetPokemonAsync(int offset, int limit)
        {
            try
            {
                var pokemonList = new List<Pokemon>();
                var pokemonUri = $"{AppSettings.BASE_URL}?offset=${offset}&limit=${limit}";

                var response = await Client.GetAsync(pokemonUri);
                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var responseString = await response.Content.ReadAsStringAsync();
                    var pokemonResult = JsonConvert.DeserializeObject<PokeResult>(responseString);
                    pokemonList = pokemonResult.Results;
                }
                return pokemonList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public string GetPokeImage(int id)
        {
            try
            {
                return $"{AppSettings.BASE_SPRITE_URL}{id}.png";
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
