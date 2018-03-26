using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using nullwines.Interfaces;
using nullwines.Models;

namespace nullwines.Data
{

    public class RestService : IRestService
    {
        HttpClient client;

        public RestService()
        {
            var authData = string.Format("{0}:{1}", Constants.Username, Constants.Password);
            var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authData));

            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);
        }

        public async Task<List<Wine>> GetWines()
        {
            var Items = new List<Wine>();
            var uri = new Uri(Constants.GetWinesUrl);
            var response = await client.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                Items = JsonConvert.DeserializeObject<List<Wine>>(content);
            }

            return Items;
        }
    }
}
