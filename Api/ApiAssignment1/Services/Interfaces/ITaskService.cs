using System;
using System.Collections.Generic;
using ApiAssignment1.Controllers.Models;
using ApiAssignment1.Models.DTO;

namespace ApiAssignment1.Services.Interfaces
{
    public interface ITaskService
    {
        IEnumerable<TaskModel> GetAll();
        TaskModel GetTask(Guid id);
        bool DeleteATask(Guid id);
        TaskModel Edit(EditTaskDTO editTask);
        bool AddMultipleTasks(IEnumerable<NewTaskDTO> newTasks);
        int DeleteMultipleTasks(IEnumerable<Guid> ids);
    }
}