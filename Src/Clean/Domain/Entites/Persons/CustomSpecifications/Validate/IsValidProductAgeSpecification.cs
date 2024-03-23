using Domain.Entites.Persons;
using Domain.Specifications.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites.Persons.CustomSpecifications;
public class IsValidProductAgeSpecification : CompositeSpecification<Person>
{
    public override bool IsSatisfiedBy(Person o)
      => o.Age > 10;

}
