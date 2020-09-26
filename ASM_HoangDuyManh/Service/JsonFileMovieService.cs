using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace ASM_HoangDuyManh.Service
{
    public class JsonFileMovieService
    {
        public  JsonFileMovieService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; }
        private string JsonFileName
        {
            get { return Path.Combine(WebHostEnvironment.WebRootPath, "data", "Movie.json"); }
        }

        public IEnumerable<Models.Movie> GetMovies()
        {
            using(var jsonFileReader = File.OpenText(JsonFileName))
            {
                return JsonSerializer.Deserialize<Models.Movie[]>(jsonFileReader.ReadToEnd(), new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                }) ;
                    
            }

        }

        public void AddRating(string movieId,int rating)
        {
            var movie = GetMovies();
            if (movie.First(x => x.ID == movieId).Ratings == null)
            {
                movie.First(x => x.ID == movieId).Ratings = new int[] { rating };
            }
            else
            {
                var ratings = movie.First(x => x.ID == movieId).Ratings.ToList();
                ratings.Add(rating);
                movie.First(x => x.ID == movieId).Ratings = ratings.ToArray();
            }

            using(var outputStream = File.OpenWrite(JsonFileName))
            {
                JsonSerializer.Serialize<IEnumerable<Models.Movie>>(
                    new Utf8JsonWriter(outputStream, new JsonWriterOptions
                    {
                        SkipValidation = true,
                        Indented = true
                    }
                     ),
                    movie);
            }
        }
    }
}
