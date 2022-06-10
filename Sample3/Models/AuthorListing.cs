using System.Collections.Generic;
using System.Linq;

namespace Sample3.Models
{
    /// <summary>
    /// Used for strong typing a select in a group by statement
    /// </summary>
    public class AuthorListing
    {
        /// <summary>
        /// Author name
        /// </summary>
        public string Author { get; }
        /// <summary>
        /// Author's book titles
        /// </summary>
        public List<string> Titles { get; }

        public AuthorListing(string author, IEnumerable<List<string>> bookList)
        {
            Author = author;
            List<string> titles = new();
            bookList.ToList().ForEach(item => item.ForEach(titles.Add));
            Titles = titles.OrderBy(title =>title).ToList();
        }
    }
}