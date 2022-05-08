using System;
using System.Collections.Generic;
using System.Linq;
using ApiAssignment2.Models.DTO;
using ApiAssignment2.Models.Entities;
using ApiAssignment2.Services.Interfaces;

namespace ApiAssignment2.Services
{
    public class PersonService : IPersonService
    {
        public static List<Person> people;
        public PersonService()
        {
            if (people == null)
            {
                people = InitDummyData();
            }
        }

        private List<Person> InitDummyData()
        {
            return new List<Person>
            {
                new Person("Lan","Nguyen",new DateTime(1990,10,20),false,"Hai Phong"),
                new Person("Tuan","Nguyen",new DateTime(2000,10,20),true,"Ha Noi"),
                new Person("Hoa","Le",new DateTime(2000,02,20),false,"Ha Noi"),
                new Person("Xuan","Pham",new DateTime(1999,10,20),false,"Hai Phong"),
                new Person("Son","Vu",new DateTime(2002,10,20),true,"Hai Phong"),
                new Person("Quang","Nguyen",new DateTime(2004,10,20),true,"Hai Phong")
            };
        }
        public bool AddNewPerson(NewPersonDTO newPerson)
        {
            if (newPerson != null)
            {
                Person addingPerson = new Person
                (
                    newPerson.FristName,
                    newPerson.LastName,
                    newPerson.Dob,
                    newPerson.Gender,
                    newPerson.BirthPlace
                );
                people.Add(addingPerson);
                return true;
            }
            return false;
        }

        public bool DeletePerson(Guid id)
        {
            if (id != null)
            {
                people.Remove(GetPersonById(id));
                return true;
            }
            return false;
        }

        public IEnumerable<Person> GetBirthPlace(string birthPlace)
        {
            if (birthPlace != null)
            {
                return people.FindAll(p => p.BirthPlace.ToUpper() == birthPlace.ToUpper());
            }
            return null;
        }

        public IEnumerable<Person> GetGender(bool gender)
        {
            if (gender != null)
            {
                return people.FindAll(p => p.Gender == gender);
            }
            return null;
        }

        public IEnumerable<Person> GetNameList(string name)
        {
            if (name != null)
            {
                return people.FindAll(p => p.FristName.ToLower().Contains(name.ToLower())
                || p.LastName.ToLower().Contains(name.ToLower()));
            }
            return null;
        }

        public bool UpdatePerson(EditPersonDTO editPerson)
        {
            if (editPerson != null)
            {
                var findPerson = GetPersonById(editPerson.Id);
                findPerson.FristName = editPerson.FristName;
                findPerson.LastName = editPerson.LastName;
                findPerson.Dob = editPerson.Dob;
                findPerson.Gender = editPerson.Gender;
                findPerson.BirthPlace = editPerson.BirthPlace;
                return true;
            }

            return false;
        }

        public Person GetPersonById(Guid id)
        {
            if (id != null)
            {
                return people.Find(p => p.Id == id);
            }

            return null;
        }

        public IEnumerable<Person> GetAll()
        {
            return people.Select(p => p);
        }
    }
}