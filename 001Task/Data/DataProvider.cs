namespace _001Task.Data;

public class DataProvider
{
    public static List<Country> Countries { get; private set; } = new()
    {
        new Country {Id = 1, Name = "USA" },
        new Country {Id = 2, Name = "Canada" },
    };

    public static List<City> Cities { get; private set; } = new()
    {
        new City
        {
            Id = 1, Name = "New York", Population = 8623000, CountryId = 1
        },
        new City
        {
            Id = 2, Name = "Toronto", Population = 2930000, CountryId = 2
        }
    };

    public static List<People> Peoples { get; private set; } = new()
    {

        new People {Id = 1, FirstName = "John", LastName = "Mark", Age = 30, CityId = 1 },
        new People {Id = 2, FirstName = "Jane", LastName = "Doe", Age = 25, CityId = 2 },
        new People {Id = 3, FirstName = "Alice", LastName = "Jane", Age = 35, CityId = 2 },
        new People {Id = 4, FirstName = "Mark", LastName = "Doe", Age = 19, CityId = 1 },
        new People {Id = 5, FirstName = "Malik", LastName = "Malik", Age = 29, CityId = 1 },
        new People {Id = 6, FirstName = "Marks", LastName = "Does", Age = 17, CityId = 1 }
    };
}