using BlazorLabb.PersonInfo;

namespace BlazorLabb
{
    public interface IFetchData
    {
        List<Person> GetUsers();
    }
}
