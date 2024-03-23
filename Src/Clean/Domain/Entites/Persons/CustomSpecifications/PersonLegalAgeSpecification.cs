using Domain.Entites.Persons;
using Domain.Specifications.Public;

namespace Domain.Entites.Persons.CustomSpecifications;

public class PersonLegalAgeSpecification : CompositeSpecification<Person>
{
    public override bool IsSatisfiedBy(Person o)
    {
        return o.Age > 18;
    }
}
