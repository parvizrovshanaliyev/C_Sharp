using System;
using ToDoList.Entities.Abstract;

namespace ToDoList.Entities.Concrete
{
    public class UserEntity: BaseEntity<Guid>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
