using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BlazorLabb.PersonInfo
{
    public class Person
    {
        [JsonPropertyName("id")]
        [Required(ErrorMessage = "Field is required!")]
        public int Id { get; set; }

        [JsonPropertyName("name")]
        [Required(ErrorMessage = "Field is required!")]
        public string Name { get; set; }

        [JsonPropertyName("email")]
        [Required(ErrorMessage = "Field is required!")]
        public string Email { get; set; }

        [JsonPropertyName("address")]
        public Adress Adress { get; set; }

        [JsonPropertyName("company")]
        public Company Company { get; set; }
    }
}
