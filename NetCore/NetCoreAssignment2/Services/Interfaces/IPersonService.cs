using System.Collections.Generic;
using NetCoreAssignment2.Models;

namespace NetCoreAssignment2.Services.Interfaces
{
    public interface IPersonService
    {
        IEnumerable<Person> GetAll();
        IEnumerable<Person> GetMaleMembers();
        Person GetOldestMember();
        IEnumerable<string> GetMembersWithFullName();
        IEnumerable<Person> GetCompareWith2000List(int i);
        List<Person> People { get; }
        Person GetPersonById(int id);
        Person Create(Person createPerson);
        Person Edit(Person editPerson);
        bool Delete(int id);
    }
}