using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoqyAPI.Models
{
    public class Cart
    {
        public int PurchaseID { get; set; }

        public int CustomerID { get; set; }

        public int ProductID { get; set; }

        public DateTime PurchaseDate { get; set; }




        public static List<Cart> Carts = new List<Cart>
        {
            new Cart() { PurchaseID = 1, CustomerID = 1, ProductID = 1, PurchaseDate = new DateTime(2019, 11, 2, 11, 00, 0)},
            new Cart() { PurchaseID = 2, CustomerID = 2, ProductID = 2, PurchaseDate = new DateTime(2018, 10, 13, 15, 30, 0)},
            new Cart() { PurchaseID = 3, CustomerID = 3, ProductID = 3, PurchaseDate = new DateTime(2020, 12, 3, 12, 30, 0)}
        };
    }
}
