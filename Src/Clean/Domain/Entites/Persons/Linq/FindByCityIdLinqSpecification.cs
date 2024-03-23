using Domain.Specifications.Public;
using System.Linq.Expressions;

namespace Domain.Entites.Persons.Linq;

public class FindByCityIdLinqSpecification : LinqSpecification<Person>
{
    private readonly int _cityId;

    public FindByCityIdLinqSpecification(int cityId)
    {
        _cityId = cityId;
        AddOrderBy(d => d.CityId, OrderByType.Asc);
        AddInclude(d => d.City);
    }
    public override Expression<Func<Person, bool>> AsExpression()
     => x => x.CityId == _cityId;

}
