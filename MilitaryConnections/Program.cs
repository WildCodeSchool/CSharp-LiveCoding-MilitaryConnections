using System;
using System.Collections.Generic;

namespace MilitaryConnections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            foreach (int x in Range(10))
            {
                Console.WriteLine(x);
            }
        }

        static IEnumerable<int> Range(int n)
        {
            for (int i=0; i < n; i++)
            {
                yield return i;
            }
        }
    }
}
