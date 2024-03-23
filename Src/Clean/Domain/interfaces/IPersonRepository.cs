using Domain.Entites.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.interfaces;

public interface IPersonRepository  {

    Task<List<Person>> GetAllByLegalAgeAndCurrentDate();
    Task<List<Person>> GetByCityId(int CityId);

    Task<List<Person>> GetPersonByLastnameArdalis(string lastname);
    Task Add(Person person);

}
