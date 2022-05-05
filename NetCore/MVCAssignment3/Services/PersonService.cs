using System;
using System.Collections.Generic;
using System.Linq;
using MVCAssignment3.Models.DTO;
using MVCAssignment3.Models.Entities;
using MVCAssignment3.Services.Interfaces;

namespace MVCAssignment3.Services
{
    public class PersonService : IPersonService
    {
        private static List<Person> _people;

        public List<Person> People
        {
            get
            {
                if (_people != null)
                {
                    return _people;
                }
                else
                {
                    return InitDummyMembers();
                }
            }
        }
        public PersonService()
        {
            if (_people == null)
            {
                _people = InitDummyMembers();
            }
        }
        private List<Person> InitDummyMembers()
        {
            return new List<Person>{
                new Person(1,"Lan","Nguyen",false,new DateTime(1990,10,20),"0216352489","Hai Phong",true),
                new Person(2,"Tuan","Nguyen",true,new DateTime(2000,10,20),"0216352489","Ha Noi",false),
                new Person(3,"Hoa","Le",false,new DateTime(2000,02,20),"0216352489","Ha Noi",true),
                new Person(4,"Xuan","Pham",false,new DateTime(1999,10,20),"0216352489","Hai Phong",true),
                new Person(5,"Son","Vu",true,new DateTime(2002,10,20),"0216352489","Hai Phong",false),
                new Person(6,"Quang","Nguyen",true,new DateTime(2004,10,20),"0216352489","Hai Phong",false)
            };
        }

        public Person Create(NewPersonDTO personDTO)
        {
            int nextId = 0;
            if (People == null)
            {
                nextId = People.Max(p => p.Id);
            }
            var addingPerson = new Person(
            nextId + 1
            , personDTO.FirstName
            , personDTO.LastName
            , personDTO.Gender
            , personDTO.Dob
            , personDTO.PhoneNumber
            , personDTO.BirthPlace
            , personDTO.IsGraduated);

            People.Add(addingPerson);

            return addingPerson;
        }

        public bool Delete(int id)
        {
            var findPerson = GetPersonById(id);
            if (findPerson == null)
            {
                return false;
            }
            _people.Remove(findPerson);
            return true;
        }

        public Person Edit(EditPersonDTO editPersonDTO)
        {
            var existingPerson = GetPersonById(editPersonDTO.Id);
            if (existingPerson != null)
            {
                existingPerson.FirstName = editPersonDTO.FirstName;
                existingPerson.LastName = editPersonDTO.LastName;
                existingPerson.Gender = editPersonDTO.Gender;
                existingPerson.Dob = editPersonDTO.Dob;
                existingPerson.PhoneNumber = editPersonDTO.PhoneNumber;
                existingPerson.IsGraduated = editPersonDTO.IsGraduated;

                return existingPerson;
            }

            return null;
        }

        public Person GetPersonById(int id)
        {
            return People.FirstOrDefault(p => p.Id == id);
        }

        public IEnumerable<Person> ListAll()
        {
            return People.Select(p => p);
        }
    }
}