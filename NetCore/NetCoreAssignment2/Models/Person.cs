using System;

namespace NetCoreAssignment2.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public DateTime Dob { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthPlace { get; set; }
        public bool IsGraduated { get; set; }

        public Person()
        {

        }

        public Person(int id, string firstName, string lastName, bool gender, DateTime dob, string phone, string birthPlace, bool isGraduated)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Gender = gender;
            this.Dob = dob;
            this.PhoneNumber = phone;
            this.BirthPlace = birthPlace;
            this.IsGraduated = isGraduated;
        }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - this.Dob.Year;
            }
        }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}", this.LastName, this.FirstName);
            }
        }
    }
}