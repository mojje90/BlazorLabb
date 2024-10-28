using System.Text.Json.Serialization;

namespace BlazorLabb.PersonInfo
{
    public class Company
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("catchPhrase")]
        public string CatchPhrase { get; set; }
    }
}
