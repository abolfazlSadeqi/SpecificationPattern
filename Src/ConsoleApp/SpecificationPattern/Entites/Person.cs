using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecificationPattern.Entites;

public class Person
{
    public long Id { get; private set; }
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Age { get; private set; }
    public DateTime RegisterDate { get; private set; }

    public int CityId { get; private set; }
    public virtual City City { get; private set; }

    public Person(long id, string firstName,string lastName, int age, DateTime registerDate, int cityId)
    {
        Id = id;
        FirstName=firstName;
        LastName=lastName;
        Age=age;
        RegisterDate = registerDate;
        CityId = cityId;
    }



}
