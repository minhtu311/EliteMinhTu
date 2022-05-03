using System;
using System.Collections.Generic;
using System.Linq;

public class MemberService
{
    public IEnumerable<Member> GetMaleMembers(List<Member> members)
    {
        IEnumerable<Member> maleList = members.Where(member => member.Gender == true);

        return maleList;
    }

    public Member GetOldestMember(List<Member> members)
    {
        if (members.Any())
        {
            int maxAge = members.Max(member => member.Age);
            Member oldest = members.FirstOrDefault(member => member.Age == maxAge);

            return oldest;
        }

        return null;
    }

    public IEnumerable<string> GetMembersWithFullName(List<Member> members)
    {
        var fullNameList = members.Select(x => x.FullName);

        return fullNameList;
    }

    public IEnumerable<Member> Check2000(int i, List<Member> members)
    {
        IEnumerable<Member> check2000List = new List<Member>();
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

    public IEnumerable<Member> BirthYearIs2000(List<Member> members)
    {
        IEnumerable<Member> birthYearIs2000List = members.Where(member => member.Dob.Year == 2000);

        return birthYearIs2000List;
    }

    public IEnumerable<Member> BirthYearGreaterThan2000(List<Member> members)
    {
        IEnumerable<Member> birthYearIsGreaterThan2000List = members.Where(member => member.Dob.Year > 2000);

        return birthYearIsGreaterThan2000List;
    }

    public IEnumerable<Member> BirthYearLessThan2000(List<Member> members)
    {
        IEnumerable<Member> birthYearIsLessThan2000List = members.Where(member => member.Dob.Year < 2000);

        return birthYearIsLessThan2000List;
    }

    public Member BornInHaNoi(List<Member> members)
    {
        Member bornInHaNoi = members.FirstOrDefault(member => !string.IsNullOrEmpty(member.BirthPlace)
                                                              && member.BirthPlace.ToLower() == "ha noi");

        return bornInHaNoi;
    }

    public static List<Member> MembersInitializing()
    {
        return new List<Member>
        {
            new Member("Lan","Nguyen",false,new DateTime(1990,10,20),"0216352489","Hai Phong",true),
            new Member("Tuan","Nguyen",true,new DateTime(2000,10,20),"0216352489","Ha Noi",false),
            new Member("Hoa","Le",false,new DateTime(2000,02,20),"0216352489","Ha Noi",true),
            new Member("Xuan","Pham",false,new DateTime(1999,10,20),"0216352489","Hai Phong",true),
            new Member("Son","Vu",true,new DateTime(2002,10,20),"0216352489","Hai Phong",false),
            new Member("Quang","Nguyen",true,new DateTime(2004,10,20),"0216352489","Hai Phong",false)
        };
    }
}