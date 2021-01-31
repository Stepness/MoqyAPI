﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoqyClient.Models
{
    public class Product
    {
        public int ProductID { get; private set; }

        public string Name { get; set; }

        public int PiecesLeft { get; set; }

    }
}
