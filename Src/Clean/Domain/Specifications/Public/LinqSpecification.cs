using System.Linq.Expressions;

namespace Domain.Specifications.Public;

public abstract class LinqSpecification<T> : CompositeSpecification<T>
{
    public abstract Expression<Func<T, bool>> AsExpression();
    public override bool IsSatisfiedBy(T candidate) => AsExpression().Compile()(candidate);
    public Expression<Func<T, object>> OrderByAsc { get; private set; }
    public Expression<Func<T, object>> OrderBydesc { get; private set; }

    public List<Expression<Func<T, object>>> Includes { get; private set; }
    public void AddInclude(Expression<Func<T, object>> includeExpression)
    {
        Includes = new List<Expression<Func<T, object>>>();
        Includes.Add(includeExpression);
    }

    public void AddOrderBy(Expression<Func<T, object>> OrderByex, OrderByType orderByType)
    {
        if (orderByType == OrderByType.Asc)
            OrderByAsc = OrderByex;
        else OrderBydesc = OrderByex;
    }


}
public enum OrderByType
{
    Asc = 1,
    desc = 1
}