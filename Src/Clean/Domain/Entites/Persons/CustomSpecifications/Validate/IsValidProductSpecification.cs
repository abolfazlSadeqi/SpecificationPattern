using Domain.Entites.Persons;
using Domain.Entites.Persons.CustomSpecifications.Validate;
using Domain.Specifications.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites.Persons.CustomSpecifications;
public class IsValidProductSpecification : CompositeSpecification<Person>
{
    private readonly IsValidProductNameSpecification isValidProductName = new();
    private readonly IsValidProductAgeSpecification  isValidProductAge = new();

    public override bool IsSatisfiedBy(Person person)
        => isValidProductName
            .And(isValidProductAge)
            .IsSatisfiedBy(person);
   

}
