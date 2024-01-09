using NewsApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsApp.Services
{
    public class ApiServices
    {

        public async Task<Root> GetNews()
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync("https://gnews.io/api/v4/top-headlines?token=4afede633af5ee44b4ea04f7ae938361&topic=breaking-news");

            return JsonConvert.DeserializeObject<Root>(response);
        }

    }
}
