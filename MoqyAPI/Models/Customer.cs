using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoqyAPI.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public string CustomerName { get; set; }

        public string CustomerLastName { get; set; }

        public string TelephoneNum { get; set; }


        public static List<Customer> Customers = new List<Customer>
        {
            new Customer() { CustomerID = 1, CustomerName = "Wakko", CustomerLastName = "Warner", TelephoneNum = "(434) 263-7517" },
            new Customer() { CustomerID = 2, CustomerName = "Yakko", CustomerLastName = "Warner", TelephoneNum = "(418) 892-7680"},
            new Customer() { CustomerID = 3, CustomerName = "Dot", CustomerLastName = "Princess Angelina Contessa Louisa Francesca Banana Fanna Bo Besca III", TelephoneNum = "(690) 621-6610"}
        };

    }
}
