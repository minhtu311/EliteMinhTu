using System;

namespace ApiAssignment2.Models.Entities
{
    public class Person
    {
        public Guid Id { get; set; }
        public string FristName { get; set; }
        public string LastName { get; set; }
        public DateTime Dob { get; set; }
        public bool Gender { get; set; }
        public string BirthPlace { get; set; }

        public Person()
        {

        }

        public Person(string fristName, string lastName, DateTime dob, bool gender, string birthPlace)
        {
            this.Id = Guid.NewGuid();
            this.FristName = fristName;
            this.LastName = lastName;
            this.Dob = dob;
            this.Gender = gender;
            this.BirthPlace = birthPlace;
        }
    }
}