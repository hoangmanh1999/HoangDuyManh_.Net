using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text;
using Testshop.Services;
using Testshop.Models;

namespace Testshop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
       public ProductsController(JsonFileProductService productService)
        {
            ProductService = productService;
        }
        public JsonFileProductService ProductService { get; }
        [HttpGet]
        public IEnumerable<Products> Get()
        {
            return ProductService.GetProducts();
        }

        [Route("Rate")]
        [HttpGet]
        public ActionResult Get(
            [FromQuery] string ProductId,
            [FromQuery] int Rating
            )
        {
            ProductService.AddRating(ProductId, Rating);
            return Ok();
        }
    }
}
