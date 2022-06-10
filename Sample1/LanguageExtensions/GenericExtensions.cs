using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Sample1.LanguageExtensions
{
    public static class GenericExtensions
    {
        /// <summary>
        /// Determine if there are duplicates in source
        /// </summary>
        /// <typeparam name="T">inferred type</typeparam>
        /// <param name="source">IEnumerable</param>
        /// <returns>true if duplicates, false no duplicates</returns>
        /// <remarks>
        /// Alternate
        /// if(source.Count != source.Distinct().Count())
        /// </remarks>
        public static bool ContainsDuplicates<T>(this IEnumerable<T> source)
        {
            var knownKeys = new HashSet<T>();
            return source.Any(item => !knownKeys.Add(item));
        }

        public static bool In<T>(this T source, params T[] list)
        {
            if (null == source) throw new ArgumentNullException(nameof(source));

            return ((IList)list).Contains(source);

        }
        
        public static bool InCondition<T>(this T sender, params T[] values) => values.Contains(sender);
        public static T GetLast<T>(this List<T> source) => source[^1];
        public static T GetLast<T>(this IEnumerable<T> source) => source.Last(); // redundant but is constant with others
        public static T GetLast<T>(this T[] source) => source[^1];

        /// <summary>
        /// Return a list given a <seealso cref="Range"/>
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">T</param>
        /// <param name="range">Range to get list</param>
        /// <returns></returns>
        public static List<T> GetRange<T>(this List<T> list, Range range)
        {
            /*
             * Named value Tuple
             */
            (int start, int length) = range.GetOffsetAndLength(list.Count);

            return list.GetRange(start, length);

        }
    }
}

