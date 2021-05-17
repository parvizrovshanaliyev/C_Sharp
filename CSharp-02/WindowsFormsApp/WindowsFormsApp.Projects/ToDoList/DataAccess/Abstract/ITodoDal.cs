using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Entities.Concrete;
using ToDoList.Enums;

namespace ToDoList.DataAccess.Abstract
{
    public interface ITodoDal
    {
        List<TodoEntity> GetAll();
        List<TodoEntity> GetAllByStatus(Status status);
        int TodosCount();
        int Add(TodoEntity todo);
        void Update(TodoEntity todo);
        void Delete(TodoEntity todo);
    }
}
