using System;
using System.Linq;

namespace numberOfSubStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToLower();
            string subString = Console.ReadLine().ToLower();
            int occurances = 0;

            while (input.Contains(subString))
            {
                input=input.Remove(input.IndexOf(subString), subString.Length);
                occurances++;
            }

            Console.WriteLine(occurances);
        }
    }
}
