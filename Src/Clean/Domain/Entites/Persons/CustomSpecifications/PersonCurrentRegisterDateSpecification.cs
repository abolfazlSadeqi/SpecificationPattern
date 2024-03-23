using Domain.Entites.Persons;
using Domain.Specifications.Public;

namespace Domain.Entites.Persons.CustomSpecifications;

public class PersonCurrentRegisterDateSpecification : CompositeSpecification<Person>
{
    public override bool IsSatisfiedBy(Person o)
    {
        return o.RegisterDate.Date.Year == DateTime.Now.Year;
    }
}
