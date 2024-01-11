using Entities;
using DataAccess.Interfaces;

namespace DataAccess;

public class TodoDataAccess : Repository<Todo>, ITodoDataAccess
{
}