using System;
using System.Collections.Generic;
using System.Linq;
using ToDoList.DataAccess.Abstract;
using ToDoList.Entities.Concrete;
using ToDoList.Enums;

namespace ToDoList.DataAccess.Concrete
{
    public class InMemoryTodoDal : ITodoDal
    {
        #region fields

        private static readonly List<TodoEntity> _todoEntities;
        #endregion
        #region ctor

        static InMemoryTodoDal()
        {
            _todoEntities = new List<TodoEntity>();
        }

        #endregion
        #region Implementation of ITodoDal

        public List<TodoEntity> GetAll()
        {
            return _todoEntities;
        }

        public List<TodoEntity> GetAllByStatus(Status status)
        {
            return _todoEntities.Where(i => i.Status == status).ToList();
        }

        public int TodosCount()
        {
            return _todoEntities.Count;
        }

        public int Add(TodoEntity todo)
        {
            int result;
            try
            {
                _todoEntities.Add(todo);
                result = 1;
            }
            catch (Exception e)
            {
                result = 0;
                throw;
            }

            return result;
        }


        public void Update(TodoEntity todo)
        {
            throw new NotImplementedException();
        }

        public void Delete(TodoEntity todo)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}