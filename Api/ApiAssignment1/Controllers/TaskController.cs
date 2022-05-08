using System;
using System.Collections.Generic;
using ApiAssignment1.Controllers.Models;
using ApiAssignment1.Models.DTO;
using ApiAssignment1.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiAssignment1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : Controller
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public TaskModel GetATask(Guid id)
        {
            return _taskService.GetTask(id);
        }

        [HttpGet("/get-all")]
        public IEnumerable<TaskModel> GetAll()
        {
            var result = _taskService.GetAll();
            if (result == null) return null;

            return result;
        }

        [HttpDelete]
        public bool Delete(Guid id)
        {
            return _taskService.DeleteATask(id);
        }

        [HttpPut]
        public TaskModel Edit([FromBody] EditTaskDTO editTask)
        {
            return _taskService.Edit(editTask);
        }

        [HttpPost("/add-multiple-tasks")]
        public bool AddMultipleTasks([FromBody] IEnumerable<NewTaskDTO> newTasks)
        {
            return _taskService.AddMultipleTasks(newTasks);
        }

        [HttpPost("/delete-multiple-tasks")]
        public void DeleteMultipleTasks([FromBody] IEnumerable<Guid> ids)
        {
            _taskService.DeleteMultipleTasks(ids);
        }
    }
}