using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PRACTICE_HoangDuyManh.Services;

namespace PRACTICE_HoangDuyManh.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger,JsonFileProductSevice productSevice)
        {
            _logger = logger;
            ProductSevice = productSevice;
        }
        public JsonFileProductSevice ProductSevice { get; }
        public IEnumerable<Models.Product> products { get; private set; }
        public void OnGet()
        {
            products = ProductSevice.GetProducts();
        }
    }
}
