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
        private readonly ILogger<Shop> _logger;

        public Shop(ILogger<Shop> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetAll_PurchaseData")]
        public IEnumerable<Cart> GetAll_PurchaseData()
        {
            return Cart.Carts;
        }
    }
}
