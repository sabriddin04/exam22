namespace _001Task;
public class People
{
    public int Id { get; set; }
    public string FirstName { get; set; }=null!;
    public string LastName { get; set; }=null!;
    public int Age { get; set; }
    public int CityId { get; set; }
    public City? City { get; set; }
}