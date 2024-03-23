using Domain.Entites.Persons;
using Domain.interfaces;

namespace App;

public class PersonApp : IPersonApp
{
    public readonly IPersonRepository _repository;
    public PersonApp(IPersonRepository repository)
    {
        _repository = repository;
    }
    public async Task<List<Person>> GetAllByLegalAgeAndCurrentDate()
    => await _repository.GetAllByLegalAgeAndCurrentDate();

    public async Task<List<Person>> GetPersonByLastnameArdalis(string lastname)
    => await _repository.GetPersonByLastnameArdalis(lastname);

    public async Task<List<Person>> GetByCityId(int CityId)
        => await _repository.GetByCityId(CityId);

    public async Task Add(Person person)
      => await _repository.Add(person);

}
