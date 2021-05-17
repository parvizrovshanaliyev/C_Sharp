using System.Collections.Generic;
using ToDoList.Business.Abstract;
using ToDoList.DataAccess.Abstract;
using ToDoList.Entities.Concrete;
using ToDoList.Enums;

namespace ToDoList.Business.Concrete
{
    public class TodoService:ITodoService
    {
        #region fields

        private readonly ITodoDal _todoDal;

        #endregion
        #region ctor
        public TodoService(ITodoDal todoDal)
        {
            _todoDal = todoDal;
        }
        #endregion
        #region Implementation of ITodoService

        public int Count()
        {
            return _todoDal.TodosCount();
        }

        public int Add(TodoEntity data)
        {
            return _todoDal.Add(data);
        }

        public List<TodoEntity> GetAll()
        {
            return _todoDal.GetAll();
        }

        public List<TodoEntity> GetAllByStatus(Status status)
        {
            return _todoDal.GetAllByStatus(status);
        }

        #endregion
    }
}