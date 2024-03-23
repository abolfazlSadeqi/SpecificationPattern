
using Domain.Specifications.Public;
using Microsoft.EntityFrameworkCore;

namespace Infra.EF.Repositorys;

public static class IQueryableExtension
{
    public static IQueryable<TEntity>
        Invoke<TEntity>(
           this IQueryable<TEntity> query
          , LinqSpecification<TEntity> specification
        ) where TEntity : class
    {
        query = query.Where(specification.AsExpression());

        if (specification.OrderByAsc is not null) query = query.OrderBy(specification.OrderByAsc);

        if (specification.OrderBydesc is not null) query = query.OrderByDescending(specification.OrderBydesc);

        if (specification.Includes is not null) query = specification.Includes.Aggregate(query, (current, include) => current.Include(include));
        return query;
    }
}