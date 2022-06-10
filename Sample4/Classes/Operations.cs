using System;
using System.Collections.Generic;
using System.Linq;
using Sample4.Models;

namespace Sample4.Classes
{
    public class AuthorContainer
    {
        public string AuthorName { get; }
        public List<Book> Books { get; }

        public AuthorContainer(string authorName, List<Book> books)
        {
            AuthorName = authorName;
            Books = books;
        }
    }

    public class GroupedAuthor
    {
        public IEnumerable<AuthorContainer> Container { get; }

        public GroupedAuthor(IEnumerable<AuthorContainer> container)
        {
            Container = container;
        }
    }

    class Operations
    {
        
        public delegate void IterateAuthors(string authorName, List<Book> books);
        public static event IterateAuthors OnIterate;


        public static void GetAuthorAndBooks()
        {
            List<GroupedAuthor> groupedAuthors = Mocked.Books()
                .GroupBy(author => author.Name, StringComparer.InvariantCultureIgnoreCase)
                .Select(group => new GroupedAuthor(group
                        .Select(author => new AuthorContainer(author.Name, author.Books))))
                .ToList();
            
            foreach (GroupedAuthor author in groupedAuthors)
            {
                author.Container
                    .ToList().ForEach(current => OnIterate?.Invoke(current.AuthorName, current.Books));
            }
        }

        public static List<GroupedAuthor> GetAuthorAndBooks1() => 
            Mocked
                .Books()
                .GroupBy(author => author.Name, StringComparer.InvariantCultureIgnoreCase)
                .Select(group => new GroupedAuthor(group
                    .Select(author => new AuthorContainer(author.Name, author.Books))))
                .ToList();


        
    }


}
