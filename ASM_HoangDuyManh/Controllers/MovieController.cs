using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASM_HoangDuyManh.Models;
using ASM_HoangDuyManh.Service;

namespace ASM_HoangDuyManh.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : Controller
    {
        public MovieController(JsonFileMovieService movieService)
        {
            MovieService = movieService;
        }
        public JsonFileMovieService MovieService { get; }
        [HttpGet]
        public ActionResult Get(
            [FromQuery] string MovieId,
            [FromQuery] int Rating)
        {
            MovieService.AddRating(MovieId, Rating);
            return Ok();
        }
    }
}
