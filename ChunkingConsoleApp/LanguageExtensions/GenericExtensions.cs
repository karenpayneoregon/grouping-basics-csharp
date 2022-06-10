using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChunkingConsoleApp.LanguageExtensions
{
    public static class GenericExtensions
    {

        /// <summary>
        /// Create a List of List of T from a List of T split by integer
        /// </summary>
        /// <typeparam name="T">Type of List</typeparam>
        /// <param name="source">List to split</param>
        /// <param name="chunkSize">Split list by</param>
        /// <returns>Chunked list</returns>
        public static List<List<T>> ChunkBy<T>(this List<T> source, int chunkSize) =>
            source
                .Select((value, index) => new { Index = index, Value = value })
                .GroupBy(item => item.Index / chunkSize)
                .Select(item => item.Select(value => value.Value).ToList())
                .ToList();
    }
}
