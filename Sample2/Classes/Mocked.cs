using System.Collections.Generic;
using System.Linq;
using Bogus;
using Sample2.Models;

namespace Sample2.Classes;

public class Mocked
{

    public static List<string> Names()
    {
        Faker<Student> data = new Faker<Student>()
            .RuleFor(s => s.FullName, f => f.Person.FullName);
        return data.Generate(10).Select(x => x.FullName).ToList();
    }

    public static List<Student> GetStudents()
    {
        var students = new List<Student>()
        {
            new() { Id = 1001, Gender = "Female", Branch = "CSE", Age = 20 },
            new() { Id = 1002, Gender = "Male", Branch = "ETC", Age = 21 },
            new() { Id = 1003, Gender = "Male", Branch = "CSE", Age = 21 },
            new() { Id = 1004, Gender = "Male", Branch = "CSE", Age = 20 },
            new() { Id = 1005, Gender = "Female", Branch = "ETC", Age = 20 },
            new() { Id = 1006, Gender = "Female", Branch = "CSE", Age = 21 },
            new() { Id = 1007, Gender = "Male", Branch = "CSE", Age = 22 },
            new() { Id = 1008, Gender = "Female", Branch = "CSE", Age = 20 },
            new() { Id = 1009, Gender = "Female", Branch = "ETC", Age = 22 },
            new() { Id = 1010, Gender = "Male", Branch = "ETC", Age = 21 }
        };


        var fullNames = Names();
        for (int index = 0; index < students.Count; index++)
        {
            students[index].FullName = Names()[index];
        }
        return students;
    }
}