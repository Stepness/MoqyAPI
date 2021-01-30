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
    }
}
