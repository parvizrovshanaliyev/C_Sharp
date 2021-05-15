using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.ApplicationServices;
using ToDoList.DataAccess.Abstract;
using ToDoList.Entities.Concrete;

namespace ToDoList.DataAccess.Concrete
{
    public class InMemoryUserDal : IUserDal
    {
        #region fields

        private readonly List<UserEntity> _userEntities;

        #endregion
        #region ctor

        public InMemoryUserDal()
        {
            _userEntities = new List<UserEntity>
            {
                new() {Id = Guid.NewGuid(),Username = "user1",Password = "1234"}
            };
        }

        #endregion
        #region Implementation of IUserDal

        public List<UserEntity> GetAll()
        {
            return _userEntities;
        }

        public void Add(UserEntity user)
        {
            throw new NotImplementedException();
        }

        public void Update(UserEntity user)
        {
            throw new NotImplementedException();
        }

        public void Delete(UserEntity user)
        {
            throw new NotImplementedException();
        }

        public UserEntity GetUser(string username, string password)
        {
            var user = _userEntities.SingleOrDefault(i => i.Username == username && i.Password == password);

            return user;
        }

        #endregion
    }

    public class InMemoryTodoDal : ITodoDal
    {
        #region fields

        private readonly List<TodoEntity> _todoEntities;
        #endregion
        #region ctor

        public InMemoryTodoDal()
        {
            _todoEntities = new List<TodoEntity>();
        }

        #endregion
        #region Implementation of ITodoDal

        public List<TodoEntity> GetAll()
        {
            return _todoEntities;
        }

        public void Add(TodoEntity todo)
        {
            throw new NotImplementedException();
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
