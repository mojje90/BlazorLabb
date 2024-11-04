using BlazorLabb.PersonInfo;

namespace BlazorLabb
{
    public interface IFetchData
    {
        Task<List<Person>> GetUsers();
    }
}
