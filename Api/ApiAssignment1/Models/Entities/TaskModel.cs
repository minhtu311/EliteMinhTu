using System;

namespace ApiAssignment1.Controllers.Models
{
    public class TaskModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }

        public TaskModel()
        {
        }

        public TaskModel(string title, bool isCompleted)
        {
            this.Id = Guid.NewGuid();
            this.Title = title;
            this.IsCompleted = isCompleted;
        }
    }
}