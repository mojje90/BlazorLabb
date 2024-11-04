using BlazorLabb.PersonInfo;
using System.Text.Json;

namespace BlazorLabb
{
    public class FetchApiData : IFetchData
    {
        public async Task<List<Person>> GetUsers()
        {
            using HttpClient httpClient = new HttpClient();
            var apiResponse = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/users");
            var content = await apiResponse.Content.ReadAsStringAsync();
            var data = JsonSerializer.Deserialize<List<Person>>(content);

            return data;
        }
    }
}
