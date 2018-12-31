using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using server.Models.Entities;
using server.Services;

namespace server.Controllers
{
    [Route("")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet("{category}")]
        public ActionResult<List<Product>> GetByCategory(Category category)
        {
            var products = _service.GetByCategory(category);
            return Ok(products);
        }

        [HttpGet("{category}/{itemName}")]
        public ActionResult<List<Product>> GetByItemName(Category category, string itemName)
        {
            var products = _service.GetByItemName(category, itemName);
            return Ok(products);
        }
    }
}
