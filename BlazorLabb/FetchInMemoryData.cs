using BlazorLabb.PersonInfo;

namespace BlazorLabb
{
    public class FetchInMemoryData : IFetchData
    {
        public List<Person> GetUsers()
        {
            List<Person> people = new List<Person>
            {
                new Person { Id = 1, Name = "Kalle", Email = "Kalle@msn.se", Adress = new Adress { City = "Stockholm", Street = "Kungsgatan 1", ZipCode = "123456" }, Company = new Company { Name = "Apple", CatchPhrase = "Cheap products!" } },
                new Person { Id = 2, Name = "Anna", Email = "Anna@msn.se", Adress = new Adress { City = "Göteborg", Street = "Avenyn", ZipCode = "54321" }, Company = new Company { Name = "Google", CatchPhrase = "Don't be evil!" } },
                new Person { Id = 3, Name = "Erik", Email = "Erik@msn.se", Adress = new Adress { City = "Malmö", Street = "Stortorget", ZipCode = "12345" }, Company = new Company { Name = "Microsoft", CatchPhrase = "Empowering us all!" } },
                new Person { Id = 4, Name = "Lina", Email = "Lina@msn.se", Adress = new Adress { City = "Uppsala", Street = "Sundinvägen", ZipCode ="67890" }, Company = new Company { Name = "Facebook", CatchPhrase = "Connect with friends!" } },
                new Person { Id = 5, Name = "Jonas", Email = "Jonas@msn.se", Adress = new Adress { City = "Linköping", Street = "Torggatan", ZipCode = "11223" }, Company = new Company { Name = "Tesla", CatchPhrase = "Accelerating the world's transition to sustainable energy." } },
                new Person { Id = 6, Name = "Sofia", Email = "Sofia@msn.se", Adress = new Adress { City = "Västerås", Street = "Västeråsgatan", ZipCode = "123123" }, Company = new Company { Name = "Amazon", CatchPhrase = "Work hard. Have fun. Make history." } },
                new Person { Id = 7, Name = "Marcus", Email = "Marcus@msn.se", Adress = new Adress { City = "Örebro", Street = "Köpmangatan", ZipCode = "32123" }, Company = new Company { Name = "Spotify", CatchPhrase = "Music for everyone!" } },
                new Person { Id = 8, Name = "Elin", Email = "Elin@msn.se", Adress = new Adress { City = "Helsingborg", Street = "Stadsgatan", ZipCode = "45678" }, Company = new Company { Name = "Netflix", CatchPhrase = "See what's next." } },
                new Person { Id = 9, Name = "David", Email = "David@msn.se", Adress = new Adress { City = "Lund", Street = "Lundagatan", ZipCode = "98765" }, Company = new Company { Name = "Adobe", CatchPhrase = "Changing the world through digital experiences." } },
                new Person { Id = 10, Name = "Sara", Email = "Sara@msn.se", Adress = new Adress { City = "Norrköping", Street = "Norrköpingsgatan", ZipCode = "23456" }, Company = new Company { Name = "IBM", CatchPhrase = "Think." } }
            };
            return people;
        }
    }
}
