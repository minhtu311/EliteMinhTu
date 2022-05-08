using System;
using System.Collections.Generic;
using ApiAssignment2.Models.DTO;
using ApiAssignment2.Models.Entities;
using ApiAssignment2.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ApiAssignment2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : Controller
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpPost]
        public bool Create([FromBody] NewPersonDTO newPerson)
        {
            return _personService.AddNewPerson(newPerson);
        }

        [HttpPut]
        public bool Update([FromBody] EditPersonDTO editPerson)
        {
            return _personService.UpdatePerson(editPerson);
        }

        [HttpDelete]
        public bool Delete(Guid id)
        {
            return _personService.DeletePerson(id);
        }

        [HttpGet]
        public IEnumerable<Person> GetAll()
        {
            return _personService.GetAll();
        }

        [HttpGet("/get-name")]
        public IEnumerable<Person> GetNameList(string name)
        {
            return _personService.GetNameList(name);
        }

        [HttpGet("/get-gender")]
        public IEnumerable<Person> GetGender(bool gender)
        {
            return _personService.GetGender(gender);
        }

        [HttpGet("/get-birth-place")]
        public IEnumerable<Person> GetBirthPlace(string birthPlace)
        {
            return _personService.GetBirthPlace(birthPlace);
        }
    }
}