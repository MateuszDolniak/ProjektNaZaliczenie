using ToDo.Model.Model;

namespace ToDo.App.ViewModels
{
    public interface ITaskMapper
    {
        Task ConvertToTask(TaskDto taskDto);
        TaskDto ConvertToTaskDto(Task task);
    }
}