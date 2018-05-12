using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using youless.core.connector;

namespace youless.core
{
    public class YoulessConnector
    {
        private readonly string ipAddress;
        private readonly HttpClient httpClient;

        public YoulessConnector(string ipAddress)
        {
            this.ipAddress = ipAddress;
            this.httpClient = new HttpClient();
            this.httpClient.BaseAddress = new Uri($"http://{ipAddress}");

        }

        public async Task<Status> GetStatus()
        {
            var x = await httpClient.GetStringAsync("/a?f=j");
            var result = JsonConvert.DeserializeObject<Status>(x);
            SetTimeStamp(result);
            return result;
        }

        /// <summary>
        /// LS-120 : Gets the per minutes (only last 10 hours are retained).
        /// </summary>
        /// <returns>The per minutes.</returns>
        /// <param name="number">Number.</param>
        public async Task<Statistic> GetPerMinute(int number = 1)
        {
            var x = await httpClient.GetStringAsync($"/V?h={number}&f=j");
            var result = JsonConvert.DeserializeObject<Statistic>(x);
            return result;
        }

        /// <summary>
        /// LS-120: Gets the per hour (only the last 10 days are retained).
        /// </summary>
        /// <returns>The per hour.</returns>
        /// <param name="number">Number.</param>
        public async Task<Statistic> GetPer10Minutes(int number = 1)
        {
            var x = await httpClient.GetStringAsync($"/V?w={number}&f=j");
            var result = JsonConvert.DeserializeObject<Statistic>(x);
            return result;
        }

        /// <summary>
        /// LS-120: Gets the per day (only the last 70 days are retained).
        /// </summary>
        /// <returns>The usage for a day.</returns>
        /// <param name="daysAgo">Number.</param>
        public async Task<Statistic> GetPerHour(int daysAgo = 1)
        {
            var x = await httpClient.GetStringAsync($"/V?d={daysAgo}&f=j");
            var result = JsonConvert.DeserializeObject<Statistic>(x);
            return result;
        }

        /// <summary>
        /// LS-120: Gets the per month (only the last year is retained).
        /// </summary>
        /// <returns>The usage in the last year for the specified month.</returns>
        /// <param name="month">Number.</param>
        public async Task<Statistic> GetPerDay(int month = 12)
        {
            var x = await httpClient.GetStringAsync($"/V?m={month}&f=j");
            var result = JsonConvert.DeserializeObject<Statistic>(x);
            return result;
        }

        private void SetTimeStamp(Status x) 
        {
            x.timestamp = DateTime.Now.ToString("HH:mm:ss");
        }

    }
}
