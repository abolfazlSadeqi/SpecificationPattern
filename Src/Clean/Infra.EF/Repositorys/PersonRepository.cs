using Ardalis.Specification;
using Ardalis.Specification.EntityFrameworkCore;
using Domain.Entites.Persons;
using Domain.Entites.Persons.ArdalisSpecification;
using Domain.Entites.Persons.CustomSpecifications;
using Domain.Entites.Persons.Linq;
using Domain.interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infra.EF.Repositorys;

public class PersonRepository :  IPersonRepository
{

    protected readonly NewContext _context;
    public PersonRepository(NewContext context)
    {
        _context = context;
    }

    public async Task Add(Person person)
    {
        await _context
                .Persons
                .AddAsync(person);
        await _context.SaveChangesAsync();
    }

        public async Task<List<Person>> GetByCityId(int CityId)
    {
        var _exp = new FindByCityIdLinqSpecification(CityId);
        return await _context
                     .Persons
                     .Invoke(_exp)
                     .ToListAsync();
       
    }


    public async Task<List<Person>> GetAllByLegalAgeAndCurrentDate()
        => await _context
                    .Persons
                    .Invoke(new PersonWithCurrentYearLinqSpecification())
                    .ToListAsync();




    public async Task<List<Person>> GetPersonByLastnameArdalis(string lastname)
        => await _context
                .Persons
                .WithSpecification(
                 new PersonByLastnameWithArdalisSpec(lastname)
                ).ToListAsync();

}
