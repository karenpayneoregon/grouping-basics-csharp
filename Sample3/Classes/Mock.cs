using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sample3.Models;

namespace Sample3.Classes
{
    public class Mock
    {
        public static List<Book> Books() =>
            new()
            {
                new() { AuthorName = "Michael Crichton", Titles = new[] 
                    { "Sphere", "Jurassic Park" } },

                new() { AuthorName = "Michael Feathers", Titles = new[] 
                    { "Working Effectively with Legacy Code" } },

                new() {AuthorName = "michael CRICHTON", Titles = new []
                    { "Sphere", "Jurassic Park" } },

                new() {AuthorName = "Adam Tornhlll", Titles = new []
                    { "Your Code as a Crime Scene", "Software Design X-Rays" } }
            };
    }
}
