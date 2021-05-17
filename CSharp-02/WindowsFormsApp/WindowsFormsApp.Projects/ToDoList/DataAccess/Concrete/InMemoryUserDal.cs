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

        private static readonly List<UserEntity> _userEntities;

        #endregion
        #region ctor

        static InMemoryUserDal()
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
}
