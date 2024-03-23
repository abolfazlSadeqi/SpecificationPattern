using SpecificationPattern.Entites;

namespace SpecificationPattern.CustomSpecifications;

public class PersonCurrentRegisterDateSpecification : CompositeSpecification<Person>
{
    public override bool IsSatisfiedBy(Person o)
    {
        return o.RegisterDate.Date.Year == DateTime.Now.Year;
    }
}
