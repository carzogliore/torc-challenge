using System.Linq.Expressions;

namespace Torc.Common;

public interface IRepository<T> where T : IEntity
{
    Task<IReadOnlyCollection<T>> GetAllAsync(Expression<Func<T, bool>> filter);
}