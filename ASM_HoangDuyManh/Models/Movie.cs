using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ASM_HoangDuyManh.Models
{
    public class Movie
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public string Url { get; set; }
        [JsonPropertyName("Img")]
        public string Image { get; set; }
        public int[] Ratings { get; set; }
        public string Description { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Movie>(this);
    }
}
