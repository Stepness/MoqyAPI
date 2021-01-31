using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoqyAPI.Models
{
    public class Product
    {
        public int ProductID { get; set; }

        public string Name { get; set; }

        public int PiecesLeft { get; set; }


        public static List<Product> Products = new List<Product>
        {
            new Product() { ProductID = 1, Name = "CD", PiecesLeft = 12 },
            new Product() { ProductID = 2, Name = "Sandwich", PiecesLeft = 42},
            new Product() { ProductID = 3, Name = "Doggo", PiecesLeft = 1, }
        };

    }
}
