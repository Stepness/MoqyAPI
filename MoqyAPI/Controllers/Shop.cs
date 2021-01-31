using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MoqyAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoqyAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Shop : ControllerBase
    {
        #region GET
        [HttpGet("GetAll_PurchaseData")]
        public IEnumerable<Cart> GetAll_PurchaseData()
        {
            return Cart.Carts;
        }

        [HttpGet("GetAll_CustomerData")]
        public IEnumerable<Customer> GetAll_CustomerData()
        {
            return Customer.Customers;
        }

        [HttpGet("GetAll_ProductData")]
        public IEnumerable<Product> GetAll_ProductData()
        {
            return Product.Products;
        }
        #endregion


        [HttpPost("Save_Customer")]
        public Customer Save_Customer([FromBody] Customer customer)
        {
            customer.CustomerID = Customer.Customers.Count + 1;
            Customer.Customers.Add(customer);

            return customer;
        }


        [HttpPut("Update_Customer/{name}")]
        public void Update_Customer(string name, Customer customer)
        {
            var customerToEdit = Customer.Customers.Where(x => x.CustomerName == name).First();
            customerToEdit = customer;
        }


        [HttpDelete("Restore_Customer")]
        public void Restore_Customer()
        {
            Customer.Customers.Clear();
            Customer.Customers = new List<Customer>
            {
            new Customer() { CustomerID = 1, CustomerName = "Wakko", CustomerLastName = "Warner", TelephoneNum = "(434) 263-7517" },
            new Customer() { CustomerID = 2, CustomerName = "Yakko", CustomerLastName = "Warner", TelephoneNum = "(418) 892-7680"},
            new Customer() { CustomerID = 3, CustomerName = "Dot", CustomerLastName = "Princess Angelina Contessa Louisa Francesca Banana Fanna Bo Besca III", TelephoneNum = "(690) 621-6610"}
            };
        }
    }
}
