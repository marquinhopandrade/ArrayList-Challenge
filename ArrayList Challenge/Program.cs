using System;
using System.Collections.Generic;

namespace ArrayList_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>(71);
            Console.WriteLine("numbers.count: {0}", Numbers.Count);
            for (int i = 100, j = 0; i < 171;j++, i++)
            {
                int number = i;
                Numbers.Add(number);

            }
        }
    }
}
