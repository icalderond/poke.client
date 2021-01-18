using System.Collections.Generic;
using Newtonsoft.Json;

namespace Poke.Client.Models
{
    public class PokeResult
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("next")]
        public string Next { get; set; }

        [JsonProperty("previous")]
        public object Previous { get; set; }

        [JsonProperty("results")]
        public List<Pokemon> Results { get; set; }
    }
}
