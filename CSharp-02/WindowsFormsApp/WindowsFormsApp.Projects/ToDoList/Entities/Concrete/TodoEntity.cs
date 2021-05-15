using System;
using ToDoList.Entities.Abstract;
using ToDoList.Enums;

namespace ToDoList.Entities.Concrete
{
    public class TodoEntity : BaseEntity<Guid>
    {
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public int ImportanceLevel { get; set; }
        public Status Status { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}