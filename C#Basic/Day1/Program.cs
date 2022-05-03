using System;
using System.Collections.Generic;

namespace Day1
{
    class Program
    {
        public static MemberService memberService = new MemberService();
        public static List<Member> members = MemberService.MembersInitializing();
        static void Main(string[] args)
        {
            while (true)
            {
                InputOptions();
            }
        }

        public static void InputOptions()
        {
            Console.WriteLine("--------#C Day 1--------");
            Console.WriteLine("1.List of members who is Male");
            Console.WriteLine("2.The oldest");
            Console.WriteLine("3.List that contains Full Name");
            Console.WriteLine("4.List birthday year compared to 2000");
            Console.WriteLine("5.The first person who was born in Ha Noi");
            Console.WriteLine("6.Exit");
            Console.Write("Enter Choice(1-6): ");
            int i = Int32.Parse(Console.ReadLine());
            switch (i)
            {
                case 1:
                    DisplayMaleMembers();
                    break;
                case 2:
                    DisplayTheOldest();
                    break;
                case 3:
                    DisplayFullNames();
                    break;
                case 4:
                    DisplayCompareYearWith2000();
                    break;
                case 5:
                    DisplayBornInHN();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
            Console.ReadKey();
        }

        public static void DisplayMaleMembers()
        {
            Console.WriteLine("***List of members who is Male:");
            foreach (Member member in memberService.GetMaleMembers(members))
            {
                Console.WriteLine(member.FullInfo);
            }
        }

        public static void DisplayTheOldest()
        {
            Console.WriteLine("***The oldest:");
            Member oldest = memberService.GetOldestMember(members);
            Console.WriteLine(oldest.FullInfo);
        }

        public static void DisplayFullNames()
        {
            Console.WriteLine("***List that contains Full Name:");
            foreach (string member in memberService.GetMembersWithFullName(members))
            {
                Console.WriteLine(member);
            }
        }

        public static void DisplayCompareYearWith2000()
        {
            Console.WriteLine("***List birthday year compared to 2000***");
            Console.WriteLine("1.List of members who has birth year is 2000");
            Console.WriteLine("2.List of members who has birth year greater than 2000");
            Console.WriteLine("3.List of members who has birth year less than 2000");
            Console.Write("Enter Choice(1-3): ");
            int list2K = Convert.ToInt32(Console.ReadLine());
            List<Member> check2000List = memberService.Check2000(list2K, members);
            foreach (Member member in check2000List)
            {
                Console.WriteLine(member.FullInfo);
            }
        }

        public static void DisplayBornInHN()
        {
            Console.WriteLine("***The first person who was born in Ha Noi:");
            Member bornInHN = memberService.BornInHaNoi(members);
            Console.WriteLine(bornInHN.FullInfo);
        }
    }
}
