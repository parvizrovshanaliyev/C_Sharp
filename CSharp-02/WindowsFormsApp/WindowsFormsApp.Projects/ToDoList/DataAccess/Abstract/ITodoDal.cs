using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Entities.Concrete;

namespace ToDoList.DataAccess.Abstract
{
    public interface ITodoDal
    {
        List<TodoEntity> GetAll();

        void Add(TodoEntity todo);
        void Update(TodoEntity todo);
        void Delete(TodoEntity todo);
    }
}
