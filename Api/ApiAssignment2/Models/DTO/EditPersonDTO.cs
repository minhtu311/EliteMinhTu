using System;

namespace ApiAssignment2.Models.DTO
{
    public class EditPersonDTO
    {
        public Guid Id { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public bool Gender { get; set; }
        public string BirthPlace { get; set; }
    }
}