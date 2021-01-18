using System;
using System.Net.Http;

namespace Poke.Client.Services
{
    public class WebApiBase
    {
        private readonly HttpClient client = null;
        public HttpClient Client => client;

        public WebApiBase()
        {
            client = new HttpClient();
            client.DefaultRequestHeaders.Add("Acept", "application/json");
            client.DefaultRequestHeaders.Add("ContentType", "application/json");
            client.Timeout = TimeSpan.FromMinutes(30);
        }
    }
}
