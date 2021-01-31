using MoqyClient.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MoqyClient
{
    public class Moqy
    {
        private static HttpClient Client;

        public static async Task<List<Cart>> GetAll_Cart()
        {
            Client = InitializeClient();

            HttpResponseMessage response = await Client.GetAsync("Shop/GetAll_PurchaseData");

            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            List<Cart> responseList = JsonConvert.DeserializeObject<List<Cart>>(responseBody);
            
            return responseList;
        }

        public static async Task<List<Customer>> GetAll_Customer()
        {
            Client = InitializeClient();

            HttpResponseMessage response = await Client.GetAsync("Shop/GetAll_CustomerData");

            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            List<Customer> responseList = JsonConvert.DeserializeObject<List<Customer>>(responseBody);

            return responseList;
        }

        private static HttpClient InitializeClient()
        {
            Client = new();
            Client.BaseAddress = new Uri("https://moqyapi.azurewebsites.net/api/");

            return Client;
        }

    }

}