using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PRACTICE_HoangDuyManh.Models
{
    public class Product
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        [JsonPropertyName("Img")]
        public string Image { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}
