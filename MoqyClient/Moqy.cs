using MoqyClient.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Text;
using System.Linq;

namespace MoqyClient
{
    public class Moqy
    {

        //private static async Task Main()
        //{
        //    //var customers = await GetAll_Customer();
        //    //var updatedCustomer = customers.Where(x => x.CustomerName == "Wakko").FirstOrDefault();
        //    //updatedCustomer.CustomerName = "Steppi";
        //    //await Update_Customer("Wakko", updatedCustomer);
        //    //customers = await GetAll_Customer();
        //    //PrintAll(customers);


        //    //var newCostumer = new Customer() { CustomerName = "Pippo", CustomerLastName = "Mignolo" };
        //    //await Save_Customer(newCostumer);
        //    //var customers = await GetAll_Customer();
        //    //PrintAll(customers);
        //}

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

        public static async Task<Customer> Save_Customer(Customer newCustomer)
        {
            Client = InitializeClient();
            
            var json = JsonConvert.SerializeObject(newCustomer);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await Client.PostAsync("Shop/Save_Customer", data);

            response.EnsureSuccessStatusCode();

            string responseBody = await response.Content.ReadAsStringAsync();

            Customer responseObject = JsonConvert.DeserializeObject<Customer>(responseBody);

            return responseObject;
        }

        public static async Task Update_Customer(string name, Customer Customer)
        {
            Client = InitializeClient();

            var json = JsonConvert.SerializeObject(Customer);
            var data = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await Client.PutAsync($"Shop/Update_Customer/{name}", data);

            response.EnsureSuccessStatusCode();
        }




        private static HttpClient InitializeClient()
        {
            Client = new();
            Client.BaseAddress = new Uri("https://moqyapi.azurewebsites.net/api/");

            return Client;
        }

        private static void PrintAll<T>(List<T> Lista)
        {
            foreach(var obj in Lista)
            {
                foreach(var prop in obj.GetType().GetProperties())
                {
                    Console.WriteLine(prop.GetValue(obj));
                }
                Console.WriteLine();
            }
        }
    }

}