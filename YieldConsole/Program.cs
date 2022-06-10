using System;
using System.Collections.Generic;

namespace YieldConsole
{
    partial class Program
    {
        static void Main(string[] args)
        {
            foreach (int i in Power(2, 8))
            {
                Console.Write("{0} ", i);
            }
            Console.ReadLine();
        }
        public static IEnumerable<int> Power(int number, int exponent)
        {
            int result = 1;

            for (int index = 0; index < exponent; index++)
            {
                result = result * number;
                yield return result;
            }
        }
    }

}
