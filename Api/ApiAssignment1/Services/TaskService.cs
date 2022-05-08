using System;
using System.Collections.Generic;
using System.Linq;
using ApiAssignment1.Controllers.Models;
using ApiAssignment1.Models.DTO;
using ApiAssignment1.Services.Interfaces;

namespace ApiAssignment1.Services
{
    public class TaskService : ITaskService
    {
        public static List<TaskModel> TaskModels;
        public TaskService()
        {
            if (TaskModels == null)
            {
                TaskModels = new List<TaskModel>
                            {
                                new TaskModel("Title 1", false),
                                new TaskModel("Title 2", false),
                                new TaskModel("Title 3", false),
                                new TaskModel("Title 4", false),
                                new TaskModel("Title 5", false)
                            };
            }
        }



        public bool AddMultipleTasks(IEnumerable<NewTaskDTO> newTasks)
        {
            try
            {
                if (newTasks != null && newTasks.Any())
                {
                    var addingTasks = newTasks.ToList().Select(x => new TaskModel(x.Title, x.IsCompleted));
                    TaskModels.AddRange(addingTasks);
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteATask(Guid id)
        {
            if (TaskModels == null)
            {
                return false;
            }
            var findTask = GetTask(id);
            TaskModels.Remove(findTask);
            return true;
        }

        public int DeleteMultipleTasks(IEnumerable<Guid> ids)
        {
            return TaskModels.RemoveAll(x => ids.Contains(x.Id));
        }

        public TaskModel Edit(EditTaskDTO editTask)
        {
            if (TaskModels == null)
            {
                return null;
            }
            var findTask = GetTask(editTask.Id);
            findTask.IsCompleted = editTask.IsCompleted;
            findTask.Title = editTask.Title;
            
            return findTask;
        }

        public IEnumerable<TaskModel> GetAll()
        {
            return TaskModels.Select(t => t);
        }

        public TaskModel GetTask(Guid id)
        {
            return TaskModels.Find(t => t.Id == id);
        }
    }
}