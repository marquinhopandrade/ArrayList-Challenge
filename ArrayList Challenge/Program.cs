using System;
using System.Collections.Generic;

namespace ArrayList_Challenge
{
    internal class Program
    {

        public static List<int> RetornaPar(List<int> Numbers)
        {
            List <int> Pares = new List<int>(71);
            for (int i = 0; i < Numbers.Count; i++)
            {
                int number = Numbers[i];
                if (number % 2 == 0)
                {
                    Pares.Add(number);

                }
            }
            return Pares;
        }
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>(71);
            for (int i = 100; i <= 170; i++)
            {
                Numbers.Add(i);
            }
            List<int> NumerosPares = RetornaPar(Numbers);
            foreach(int numeros in NumerosPares)
            {
                Console.WriteLine(numeros);
            }
        }
    }
}
