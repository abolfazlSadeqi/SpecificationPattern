
using Domain.Specifications.Public;
using System.Linq.Expressions;


namespace Domain.Entites.Persons.Linq;


public class PersonWithCurrentYearLinqSpecification : LinqSpecification<Person>
{
    public override Expression<Func<Person, bool>> AsExpression()
       => x => x.RegisterDate.Year == DateTime.Now.Year;
}


