﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoqyClient.Models
{
    public class Customer
    {
        public int CustomerID { get; private set; }

        public string CustomerName { get; set; }

        public string CustomerLastName { get; set; }

        public string TelephoneNum { get; set; }
    }
}
