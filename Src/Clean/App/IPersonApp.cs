using Domain.Entites.Persons;

namespace App;

public interface IPersonApp
{
    Task<List<Person>> GetAllByLegalAgeAndCurrentDate();

    Task<List<Person>> GetPersonByLastnameArdalis(string lastname);

    Task<List<Person>> GetByCityId(int CityId);

    Task Add(Person person);

}
