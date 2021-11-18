using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Bakery.ProductOverviewService.Models;
using Bakery.ProductOverviewService;
namespace Bakery.BakeryAPI.Controllers
{
    [Route("api/[controller]")]
    public class OverviewsProductController : ControllerBase
    {
        private IOverviewService _service;
        public OverviewsProductController(IOverviewService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<OverviewModel>> GetOverviews()
        {
            return Ok(_service.GetOverviews());
        }
    }
}