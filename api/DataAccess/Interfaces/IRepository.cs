using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace DataAccess.Interfaces;
public interface IRepository<T> where T : class, IEntity, new()
{
    IList<T> GetList(Expression<Func<T, bool>> filter = null);
    T Get(string id);
    T Add(T entity);
    T Update(T entity);
    T Delete(string id);
}