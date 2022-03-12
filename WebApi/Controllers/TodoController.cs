using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace WebApi.Controllers
{
    [Route("api/todos")]
    [ApiController]
    public class TodoController : ControllerBase
    {
        private ITodoService _todoService;

        public TodoController(ITodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet]
        public IList<Todo> Get() => _todoService.GetList();

        [HttpGet("{todoId}")]
        public Todo Get(string todoId) => _todoService.Get(todoId);

        [HttpPost]
        public Todo Post(Todo todo) => _todoService.Add(todo);

        [HttpPut]
        public Todo Put(Todo todo) => _todoService.Update(todo);

        [HttpDelete("{todoId}")]
        public Todo Delete(string todoId) => _todoService.Delete(todoId);

    }
}
