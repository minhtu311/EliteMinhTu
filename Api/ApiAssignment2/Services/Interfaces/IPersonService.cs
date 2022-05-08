using System;
using System.Collections.Generic;
using ApiAssignment2.Models.DTO;
using ApiAssignment2.Models.Entities;

namespace ApiAssignment2.Services.Interfaces
{
    public interface IPersonService
    {
        bool AddNewPerson(NewPersonDTO newPerson);
        bool UpdatePerson(EditPersonDTO editPerson);
        bool DeletePerson(Guid id);
        Person GetPersonById(Guid id);
        IEnumerable<Person> GetNameList(string name);
        IEnumerable<Person> GetGender(bool gender);
        IEnumerable<Person> GetBirthPlace(string birthPlace);
        IEnumerable<Person> GetAll();
    }
}