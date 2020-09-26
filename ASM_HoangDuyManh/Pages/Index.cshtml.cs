using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ASM_HoangDuyManh.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger,Service.JsonFileMovieService movieService)
        {
            _logger = logger;
            MovieService = movieService;
        }
        public Service.JsonFileMovieService MovieService { get; }
        public IEnumerable<Models.Movie> Movies { get; private set; }
        public void OnGet()
        {
            Movies = MovieService.GetMovies();
        }
    }
}
