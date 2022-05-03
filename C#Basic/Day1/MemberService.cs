using System;
using System.Collections.Generic;

public class MemberService
{
    public List<Member> GetMaleMembers(List<Member> members)
    {
        List<Member> maleList = new List<Member>();
        foreach (Member member in members)
        {
            if (member.Gender)
            {
                maleList.Add(member);
            }
        }

        return maleList;
    }

    public Member GetOldestMember(List<Member> members)
    {
        if (members.Count <= 0)
        {
            return null;
        }

        var oldest = members[0];
        foreach (Member member in members)
        {
            if (DateTime.Compare(member.Dob, oldest.Dob) < 0)
            {
                oldest = member;
            }
        }

        return oldest;
    }

    public List<string> GetMembersWithFullName(List<Member> members)
    {
        List<string> fullNameList = new List<string>();
        foreach (Member member in members)
        {
            fullNameList.Add(member.FullName);
        }

        return fullNameList;
    }

    public List<Member> Check2000(int i, List<Member> members)
    {
        List<Member> check2000List = new List<Member>();
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

    public List<Member> BirthYearIs2000(List<Member> members)
    {
        List<Member> birthYearIs2000List = new List<Member>();
        foreach (Member member in members)
        {
            if (member.Dob.Year == 2000)
                birthYearIs2000List.Add(member);
        }

        return birthYearIs2000List;
    }

    public List<Member> BirthYearGreaterThan2000(List<Member> members)
    {
        List<Member> birthYearIsGreaterThan2000List = new List<Member>();
        foreach (Member member in members)
        {
            if (member.Dob.Year > 2000)
                birthYearIsGreaterThan2000List.Add(member);
        }

        return birthYearIsGreaterThan2000List;
    }

    public List<Member> BirthYearLessThan2000(List<Member> members)
    {
        List<Member> birthYearIsLessThan2000List = new List<Member>();
        foreach (Member member in members)
        {
            if (member.Dob.Year < 2000)
                birthYearIsLessThan2000List.Add(member);
        }

        return birthYearIsLessThan2000List;
    }

    public Member BornInHaNoi(List<Member> members)
    {
        int i = 0;
        while (i < members.Count)
        {
            if (members[i].BirthPlace.ToLower() == "ha noi")
            {
                return members[i];
            }
            i++;
        }

        return null;
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