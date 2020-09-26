using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PRACTICE_HoangDuyManh.Models;
using PRACTICE_HoangDuyManh.Services;

namespace PRACTICE_HoangDuyManh.Controllers
{
    [ApiController]
       [Route("[controller]")]
    public class ProductController : Controller
    {
       public   ProductController(JsonFileProductSevice productSevice)
        {
            ProductSevice = productSevice;
        }
        public JsonFileProductSevice ProductSevice { get; }

        public IEnumerable<Product> Get()
        {
            return ProductSevice.GetProducts();
        }
    }
}
