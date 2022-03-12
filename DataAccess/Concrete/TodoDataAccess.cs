using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete
{
    public class TodoDataAccess : Repository<Todo>, ITodoDataAccess
    {
    }
}
