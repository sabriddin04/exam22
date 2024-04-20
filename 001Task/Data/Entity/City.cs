namespace _001Task;
public class City
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int Population { get; set; }
    public int CountryId { get; set; }
    public Country? Country { get; set; }
    public List<People>? Peoples { get; set; }
}