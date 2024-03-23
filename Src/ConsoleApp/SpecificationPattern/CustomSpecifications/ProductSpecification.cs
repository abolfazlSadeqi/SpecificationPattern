using SpecificationPattern.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern.CustomSpecifications;
public class PersonSpecification : CompositeSpecification<Person>
{
    public override bool IsSatisfiedBy(Person o)
    {
        return 
               !string.IsNullOrWhiteSpace(o.FirstName) 
            && !string.IsNullOrWhiteSpace(o.LastName);
    }
}
