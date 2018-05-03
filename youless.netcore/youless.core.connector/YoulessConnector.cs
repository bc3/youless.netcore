using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace youless.netcore
{
    public class YoulessConnector
    {
        private readonly string ipAddress;

        public YoulessConnector(string ipAddress)
        {
            this.ipAddress = ipAddress;
        }

        public async Task<Status> GetStatus() 
        {
            var httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri($"http://{ipAddress}");
            var x = await httpClient.GetStringAsync("/a?f=j");
            return JsonConvert.DeserializeObject<Status>(x);
        }

    }
}
