using MoqyClient.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MoqyClient
{
    public class Program
    {
        private static readonly HttpClient client = new HttpClient();

        HttpClient Client
        {
            get
            {
                client.BaseAddress = new Uri("https://moqyapi.azurewebsites.net/api");

                return client;
            }
        }

        public async Task<List<Cart>> GetAll_Cart()
        {

            HttpResponseMessage response = await Client.GetAsync("Shop/GetAll_PurchaseData");

            response.EnsureSuccessStatusCode();

            string responseBody = response.Headers.ToString();

            return new();
        }
    }

}