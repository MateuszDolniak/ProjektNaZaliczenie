using ToDo.Model.Model;

namespace ToDo.App.ViewModels
{
    public class TaskPatchDto
    {
        public Status? newStatus { get; set; }
        public PriorityState? newPriority { get; set; }
    }
}