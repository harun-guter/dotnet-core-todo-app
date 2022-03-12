using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Business.Abstract
{
    public interface ITodoService
    {
        IList<Todo> GetList(Expression<Func<Todo, bool>> filter = null);
        Todo Get(string todoId);
        Todo Add(Todo todo);
        Todo Update(Todo todo);
        Todo Delete(string todoId);
    }
}
