using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreAssignment2.Models;
using NetCoreAssignment2.Services.Interfaces;

namespace NetCoreAssignment2.Services
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
                    return InitDummyData();
                }
            }
        }
        public PersonService()
        {
            if (_people == null)
            {
                _people = InitDummyData();
            }
        }

        private List<Person> InitDummyData()
        {
            return new List<Person>
            {
                new Person(1,"Lan","Nguyen",false,new DateTime(1990,10,20),"0216352489","Hai Phong",true),
                new Person(2,"Tuan","Nguyen",true,new DateTime(2000,10,20),"0216352489","Ha Noi",false),
                new Person(3,"Hoa","Le",false,new DateTime(2000,02,20),"0216352489","Ha Noi",true),
                new Person(4,"Xuan","Pham",false,new DateTime(1999,10,20),"0216352489","Hai Phong",true),
                new Person(5,"Son","Vu",true,new DateTime(2002,10,20),"0216352489","Hai Phong",false),
                new Person(6,"Quang","Nguyen",true,new DateTime(2004,10,20),"0216352489","Hai Phong",false)
            };
        }

        public IEnumerable<Person> GetAll()
        {
            return People.Select(member => member);
        }

        public IEnumerable<Person> GetMaleMembers()
        {
            return People.Where(member => member.Gender == true);
        }

        public Person GetOldestMember()
        {
            if (People.Any())
            {
                int maxAge = People.Max(member => member.Age);
                Person oldest = People.FirstOrDefault(member => member.Age == maxAge);

                return oldest;
            }

            return null;
        }

        public IEnumerable<string> GetMembersWithFullName()
        {
            return People.Select(x => x.FullName);
        }

        public IEnumerable<Person> GetCompareWith2000List(int i)
        {
            switch (i)
            {
                case 1:
                    return GetBirthYearIs2000List();
                case 2:
                    return GetBirthYearGreaterThan2000List();
                default:
                    return GetBirthYearLessThan2000List();
            }
        }

        public IEnumerable<Person> GetBirthYearIs2000List()
        {
            return People.Where(member => member.Dob.Year == 2000);
        }

        public IEnumerable<Person> GetBirthYearGreaterThan2000List()
        {
            return People.Where(member => member.Dob.Year > 2000);
        }

        public IEnumerable<Person> GetBirthYearLessThan2000List()
        {
            return People.Where(member => member.Dob.Year < 2000);
        }

        public Person GetPersonById(int id)
        {
            return _people.Find(p => p.Id == id);
        }

        public Person Create(Person createPerson)
        {
            var maxId = 0;
            if (People != null)
            {
                maxId = People.Max(p => p.Id);
            }
            createPerson.Id = maxId + 1;
            _people.Add(createPerson);
            return createPerson;
        }

        public Person Edit(Person editPerson)
        {
            var findPerson = GetPersonById(editPerson.Id);
            findPerson.FirstName = editPerson.FirstName;
            findPerson.LastName = editPerson.LastName;
            findPerson.Gender = editPerson.Gender;
            findPerson.Dob = editPerson.Dob;
            findPerson.PhoneNumber = editPerson.PhoneNumber;
            findPerson.BirthPlace = editPerson.BirthPlace;
            findPerson.IsGraduated = editPerson.IsGraduated;
            return findPerson;
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
    }
}