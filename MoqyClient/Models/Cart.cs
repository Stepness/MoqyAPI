using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoqyClient.Models
{
    public class Cart
    {
        public int PurchaseID { get; private set; }

        public int CustomerID { get; private set; }

        public int ProductID { get; private set; }

        public DateTime PurchaseDate { get; set; }

    }
}
