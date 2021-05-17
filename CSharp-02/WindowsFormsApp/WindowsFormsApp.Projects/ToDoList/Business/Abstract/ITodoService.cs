using System.Collections.Generic;
using ToDoList.Entities.Concrete;
using ToDoList.Enums;

namespace ToDoList.Business.Abstract
{
    public interface ITodoService
    {
        int Count();
        int Add(TodoEntity data);
        List<TodoEntity> GetAll();
        List<TodoEntity> GetAllByStatus(Status status);
    }
}