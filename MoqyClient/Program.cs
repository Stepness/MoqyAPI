using MoqyClient.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MoqyClient
{
    public class Program
    {
        private static readonly HttpClient client = new HttpClient();

        static HttpClient Client
        {
            get
            {
                client.BaseAddress = new Uri("https://moqyapi.azurewebsites.net/api/");

                return client;
            }
        }

        public static async Task<List<Cart>> GetAll_Cart()
        {

            HttpResponseMessage response = await Client.GetAsync("Shop/GetAll_PurchaseData");

            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            List<Cart> responseList = JsonConvert.DeserializeObject<List<Cart>>(responseBody);
            
            return responseList;
        }
    }

}