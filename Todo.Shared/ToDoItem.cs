using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo.Shared
{
    public class ToDoItem
    {
        public ToDoItem()
        {

        }

        public ToDoItem(Guid id, string title = "", bool isDone = false,DateTime? dateTime=null)
        {
            Id = id;
            Title = title;
            IsDone = isDone;
            Date = dateTime;
        }

        public Guid? Id { get; set; }

        [Required]
        [MaxLength(250, ErrorMessage = "Please make the title shorter")]
        public string Title { get; set; }

        public bool IsDone { get; set; }

        public DateTime? Date { get; set; }
    }
}
