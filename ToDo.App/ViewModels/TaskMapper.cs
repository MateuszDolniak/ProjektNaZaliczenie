using JetBrains.Annotations;
using ToDo.Model.Model;

namespace ToDo.App.ViewModels
{
    [UsedImplicitly(ImplicitUseKindFlags.InstantiatedNoFixedConstructorSignature)]
    public class TaskMapper : ITaskMapper
    {
        public Task ConvertToTask(TaskDto taskDto)
        {
            return new Task
            {
                Deadline = taskDto.Deadline,
                Priority = taskDto.Priority,
                Description = taskDto.Description,
                Title = taskDto.Title,
                Status = taskDto.Status,
                Id = taskDto.Id
            };
        }

        public TaskDto ConvertToTaskDto(Task task)
        {
            return new TaskDto
            {
                Deadline = task.Deadline,
                Description = task.Description,
                Priority = task.Priority,
                Title = task.Title,
                Status = task.Status,
                Id = task.Id
            };
        }
    }
}
