using System;
using System.Collections.Generic;
using GroupByMultipleProperties.Classes;
using GroupByMultipleProperties.Models;

namespace GroupByMultipleProperties
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var members = MemberOperations.MembersList();
            List<GroupedMember> groups = MemberOperations.GroupedMembers(members);
            
            foreach (GroupedMember groupMember in groups)
            {
                Console.WriteLine(groupMember);
                foreach (Member member in groupMember.Lists)
                {
                    Console.WriteLine($"\t{member.Id,-3}{member.Active}");
                }
            }

            Console.ReadLine();
        }


    }
}
