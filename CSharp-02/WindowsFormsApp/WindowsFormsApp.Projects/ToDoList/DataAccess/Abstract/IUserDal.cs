using System.Collections.Generic;
using Microsoft.VisualBasic.ApplicationServices;
using ToDoList.Entities.Concrete;

namespace ToDoList.DataAccess.Abstract
{
    public interface IUserDal
    {
        List<UserEntity> GetAll();

        void Add(UserEntity user);
        void Update(UserEntity user);
        void Delete(UserEntity user);

        UserEntity GetUser(string username, string password);
    }
}