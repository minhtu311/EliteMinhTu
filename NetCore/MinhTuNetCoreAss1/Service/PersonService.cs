using System;
using System.Collections.Generic;
using System.Linq;
using MinhTuNetCoreAss1.Models;

namespace MinhTuNetCoreAss1.Service
{
    public class PersonService
    {
        public static IEnumerable<Person> GetMaleMembers(List<Person> members)
        {
            IEnumerable<Person> maleList = members.Where(member => member.Gender == true);

            return maleList;
        }

        public static Person GetOldestMember(List<Person> members)
        {
            if (members.Any())
            {
                int maxAge = members.Max(member => member.Age);
                Person oldest = members.FirstOrDefault(member => member.Age == maxAge);

                return oldest;
            }

            return null;
        }

        public static IEnumerable<string> GetMembersWithFullName(List<Person> members)
        {
            var fullNameList = members.Select(x => x.FullName);

            return fullNameList;
        }

        public static IEnumerable<Person> Check2000(int i, List<Person> members)
        {
            IEnumerable<Person> check2000List = new List<Person>();
            switch (i)
            {
                case 1:
                    Console.WriteLine("***List of members who has birth year is 2000:");
                    check2000List = BirthYearIs2000(members);
                    break;
                case 2:
                    Console.WriteLine("***List of members who has birth year greater than 2000:");
                    check2000List = BirthYearGreaterThan2000(members);
                    break;
                default:
                    Console.WriteLine("***List of members who has birth year less than 2000:");
                    check2000List = BirthYearLessThan2000(members);
                    break;
            }

            return check2000List;
        }

        public static IEnumerable<Person> BirthYearIs2000(List<Person> members)
        {
            IEnumerable<Person> birthYearIs2000List = members.Where(member => member.Dob.Year == 2000);

            return birthYearIs2000List;
        }

        public static IEnumerable<Person> BirthYearGreaterThan2000(List<Person> members)
        {
            IEnumerable<Person> birthYearIsGreaterThan2000List = members.Where(member => member.Dob.Year > 2000);

            return birthYearIsGreaterThan2000List;
        }

        public static IEnumerable<Person> BirthYearLessThan2000(List<Person> members)
        {
            IEnumerable<Person> birthYearIsLessThan2000List = members.Where(member => member.Dob.Year < 2000);

            return birthYearIsLessThan2000List;
        }

        public static Person BornInHaNoi(List<Person> members)
        {
            Person bornInHaNoi = members.FirstOrDefault(member => !string.IsNullOrEmpty(member.BirthPlace)
                                                                  && member.BirthPlace.ToLower() == "ha noi");

            return bornInHaNoi;
        }

        public static List<Person> MembersInitializing()
        {
            return new List<Person>
            {
                new Person("Lan","Nguyen",false,new DateTime(1990,10,20),"0216352489","Hai Phong",true),
                new Person("Tuan","Nguyen",true,new DateTime(2000,10,20),"0216352489","Ha Noi",false),
                new Person("Hoa","Le",false,new DateTime(2000,02,20),"0216352489","Ha Noi",true),
                new Person("Xuan","Pham",false,new DateTime(1999,10,20),"0216352489","Hai Phong",true),
                new Person("Son","Vu",true,new DateTime(2002,10,20),"0216352489","Hai Phong",false),
                new Person("Quang","Nguyen",true,new DateTime(2004,10,20),"0216352489","Hai Phong",false)
            };
        }
    }
}


