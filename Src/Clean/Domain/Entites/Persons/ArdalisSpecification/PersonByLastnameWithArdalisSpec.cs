using Ardalis.Specification;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entites.Persons.ArdalisSpecification;

public class PersonByLastnameWithArdalisSpec : Specification<Person>
{
    public PersonByLastnameWithArdalisSpec(string lastname)
    {
        Query.Where(c => c.LastName == lastname);
    }
}
