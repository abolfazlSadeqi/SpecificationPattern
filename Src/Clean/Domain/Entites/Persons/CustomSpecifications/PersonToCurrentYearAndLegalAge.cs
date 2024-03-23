using Domain.Entites.Persons;
using Domain.Specifications.Public;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites.Persons.CustomSpecifications;

public class PersonToCurrentYearAndLegalAgeSpecification : CompositeSpecification<Person>
{
    private readonly PersonCurrentRegisterDateSpecification personCurrentRegisterDate = new();
    private readonly PersonLegalAgeSpecification personLegalAge = new();

    public override bool IsSatisfiedBy(Person person)
        => personCurrentRegisterDate
            .And(personLegalAge)
            .IsSatisfiedBy(person);


}