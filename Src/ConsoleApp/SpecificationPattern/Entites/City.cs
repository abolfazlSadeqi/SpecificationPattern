namespace SpecificationPattern.Entites;

public class City
{
    public long Id { get; private set; }
    public string Name { get; private set; }
    public City(long id, string name)
    {
        Id = id;
        Name = name;
    }
}
