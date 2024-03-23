using Domain.Specifications.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites.Persons.CustomSpecifications.Validate;
public class IsValidProductNameSpecification : CompositeSpecification<Person>
{
    public override bool IsSatisfiedBy(Person o)
        =>
               !string.IsNullOrWhiteSpace(o.FirstName)
            && !string.IsNullOrWhiteSpace(o.LastName);
    
}
