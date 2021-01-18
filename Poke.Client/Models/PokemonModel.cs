namespace Poke.Client.Models
{
    public class PokemonModel : Pokemon
    {
        public PokemonModel(Pokemon x)
        {
            this.Name = x.Name;
            this.Url = x.Url;
        }

        public string UriImage { get; set; }
        public string PokeId { get; set; }
    }
}
