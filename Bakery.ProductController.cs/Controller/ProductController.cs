using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bakery.Repository.Models;
using Bakery.Repository;

namespace Bakery.ProductController
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
        [HttpPost]
        public ActionResult<ProductModel> GetBakeryElements([FromBody] ProductModel newProduct)
        {
            newProduct = _service.CreateProduct(newProduct);
            return Created($"/api/bakery/{newProduct.Id}",newProduct);
        }
    }
}