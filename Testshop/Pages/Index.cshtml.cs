using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Testshop.Models;
using Testshop.Services;

namespace Testshop.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger,JsonFileProductService productService)
        {
            _logger = logger;
            ProductService = productService;
        }

        public JsonFileProductService ProductService { get; }
        public IEnumerable<Products> Products { get; private set; }
        public void OnGet()
        {
            Products = ProductService.GetProducts();
        }
    }
}
