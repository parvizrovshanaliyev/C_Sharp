using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Business.Abstract;
using ToDoList.DataAccess.Abstract;
using ToDoList.Entities.Concrete;

namespace ToDoList.Business.Concrete
{
    public class UserService:IUserService
    {
        #region fields

        private readonly IUserDal _userDal;

        #endregion
        #region ctor
        public UserService(IUserDal userDal)
        {
            _userDal = userDal;
        }
        #endregion
        #region Implementation of IUserService

        public UserEntity GetUser(string username, string password)
        {
            return _userDal.GetUser(username, password);
        }

        #endregion
    }

    public class TodoService:ITodoService
    {
    }
}
