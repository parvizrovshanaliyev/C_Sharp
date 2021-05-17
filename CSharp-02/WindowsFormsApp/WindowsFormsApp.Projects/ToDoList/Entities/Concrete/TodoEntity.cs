using System;
using System.ComponentModel;
using ToDoList.Entities.Abstract;
using ToDoList.Enums;

namespace ToDoList.Entities.Concrete
{
    public class TodoEntity : BaseEntity<Guid>
    {
        [DisplayName("Title")]
        public string Title { get; set; }
        [DisplayName("Short Description")]
        public string ShortDescription { get; set; }
        [DisplayName("Description")]
        public string Description { get; set; }
        [DisplayName("Importance Level")]
        public int ImportanceLevel { get; set; }
        [DisplayName("Status")]
        public Status Status { get; set; }

        [DisplayName("Created Date")]
        public DateTime CreatedDate { get; set; }=DateTime.Now;
    }
}