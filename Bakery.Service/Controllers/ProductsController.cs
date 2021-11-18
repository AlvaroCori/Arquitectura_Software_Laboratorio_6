using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bakery.ProductServices.Models;
using Bakery.ProductServices;

namespace Bakery.BakeryAPI.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private IProductService _service;
        public ProductsController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductModel>> GetProducts()
        {
            return Ok(_service.GetProducts());
        }
        [HttpPost]
        public ActionResult<ProductModel> CreateProduct([FromBody] ProductModel newProduct)
        {
            newProduct = _service.CreateProduct(newProduct);
            return Created($"/api/bakery/{newProduct.Id}",newProduct);
        }
    }
}