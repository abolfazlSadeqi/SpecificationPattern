using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Specification;
using Domain.Entites.Cities;
using Domain.Entites.Persons.CustomSpecifications;

namespace Domain.Entites.Persons;

public class Person
{
    public long Id { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Age { get; private set; }
    public DateTime RegisterDate { get; private set; }

    public long? CityId { get; private set; }
    public virtual City City { get; private set; }

    public Person(string firstName, string lastName, int age, int cityId)
    {

        FirstName = firstName;
        LastName = lastName;
        Age = age;
        RegisterDate = DateTime.Now;
        CityId = cityId;

        if (!(new IsValidProductSpecification().IsSatisfiedBy(this)))
            throw new InvalidOperationException("The specification is not true.");



    }

    protected Person()
    {

    }


}
