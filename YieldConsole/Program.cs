using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace YieldConsole
{
    partial class Program
    {
        static void Main(string[] args)
        {
            foreach (int index in Power(2, 8))
            {
                Debug.WriteLine("{0} ", index);
            }
        }

        public static IEnumerable<int> Power(int number, int exponent)
        {
            int result = 1;

            for (int index = 0; index < exponent; index++)
            {
                result *= number;
                yield return result;
            }
        }


        public static List<int> Power1(int number, int exponent)
        {
            List<int> list = new();
            int result = 1;

            for (int index = 0; index < exponent; index++)
            {
                result *= number;
                list.Add(result);
            }

            return list;
        }
    }

}
