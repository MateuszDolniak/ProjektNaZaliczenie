using System;
using ToDo.Model.Model;

namespace ToDo.App.ViewModels
{
    public class TaskDto
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public DateTime Deadline { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public PriorityState Priority { get; set; }
    }
}
