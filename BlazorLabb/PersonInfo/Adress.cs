using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BlazorLabb.PersonInfo
{
    public class Adress
    {
        [JsonPropertyName("street")]
        public string Street { get; set; }
        [JsonPropertyName("city")]
        public string City { get; set; }
        [JsonPropertyName("zipcode")]
        public string ZipCode { get; set; }
    }
}
