using System;

namespace ApiAssignment1.Models.DTO
{
    public class EditTaskDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
    }
}