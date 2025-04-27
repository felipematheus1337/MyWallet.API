using System.Linq.Expressions;

namespace MyWalletApi.Repositories;

public interface IRepository<T>
{
    Task<IEnumerable<T>> GetAll();

    Task<T?> Get(Expression<Func<T, bool>> predicate);

    Task<T?> Create(T entity);

    void Delete(T entity);

}
