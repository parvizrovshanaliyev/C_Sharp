using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Entities.Concrete;

namespace ToDoList.Business.Abstract
{
    public interface IUserService
    {
        UserEntity GetUser(string username, string password);
    }


    public interface ITodoService
    {
    }
}
