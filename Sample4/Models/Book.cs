using System.Collections.Generic;

namespace Sample4.Models
{

    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Book> Books { get; set; } = new();
    }
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public override string ToString() => Title;
    }

    public class Mocked
    {
        public static List<Author> Books()
        {
            List<Author> list = new List<Author>();

            list.Add(new Author()
            {
                Id = 1, 
                Name = "Mike Adams",
                Books = new List<Book>()
                {
                    new Book() {Id = 101, Title = "First Book"},
                    new Book() {Id = 102, Title = "first Book"},
                    new Book() {Id = 103, Title = "Second Book"},
                }
            });

            list.Add(new Author()
            {
                Id = 2,
                Name = "Hank Miller",
                Books = new List<Book>()
                {
                    new Book() {Id = 101, Title = "Book 1"},
                    new Book() {Id = 102, Title = "Book 2"},
                    new Book() {Id = 103, Title = "Book 3"},
                }
            });


            list.Add(new Author()
            {
                Id = 3,
                Name = "mike adams",
                Books = new List<Book>()
                {
                    new Book() {Id = 201, Title = "A book"},
                    new Book() {Id = 202, Title = "B Book"},
                }
            });

            list.Add(new Author()
            {
                Id = 4,
                Name = "Jill Smith",
                Books = new List<Book>()
                {
                    new Book() {Id = 201, Title = "Novel 1"},
                    new Book() {Id = 202, Title = "Novel 2"},
                }
            });

            return list;
        }
    }
}