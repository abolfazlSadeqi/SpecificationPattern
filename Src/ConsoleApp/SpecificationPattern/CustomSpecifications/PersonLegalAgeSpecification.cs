using SpecificationPattern.Entites;

namespace SpecificationPattern.CustomSpecifications;

public class PersonLegalAgeSpecification : CompositeSpecification<Person>
{
    public override bool IsSatisfiedBy(Person o)
    {
        return o.Age > 18;
    }
}
