namespace _001Task;

public class Country
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public List<City>? Cities { get; set; }
}