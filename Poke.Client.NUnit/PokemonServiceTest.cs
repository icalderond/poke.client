using System.Threading.Tasks;
using NUnit.Framework;
using Poke.Client.Services;

namespace Poke.Client.NUnit
{
    [TestFixture()]
    public class PokemonServiceTest
    {
        PokemonService PokemonService = new PokemonService();

        [Test()]
        public async Task Test_GetPokemonAsync_Get_IsSuccesfull()
        {
            var result = await PokemonService.GetPokemonAsync(20, 20);
            Assert.IsNotNull(result);
        }

        [Test()]
        public void Test_GetPokeImageAsync_Get_IsSuccesfull()
        {
            var result = PokemonService.GetPokeImage(1);
            Assert.IsNotNull(result);
        }
    }
}
