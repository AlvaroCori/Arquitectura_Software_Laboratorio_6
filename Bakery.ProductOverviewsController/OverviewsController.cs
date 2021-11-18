using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bakery.Repository.Models;
using Bakery.Repository;

namespace Bakery.ProductOverviewsController
{
    public class OverviewsController
    {
    [Route("api/[controller]")]
    public class BakeryController : ControllerBase
    {
        private IProductService _service;
        public BakeryController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductModel>> GetBakeryElements()
        {
            return Ok(_service.GetProducts());
        }
    }
    }
}
