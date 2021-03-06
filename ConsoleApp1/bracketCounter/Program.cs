using System;

namespace bracketCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int openPairs = 0;

            for(int i=0; i<input.Length; i++)
            {
                if (input[i].Equals('('))
                    openPairs++;
                if (input[i].Equals(')'))
                    openPairs--;
                if (openPairs < 0)
                    break;
            }
            if (openPairs != 0)
                Console.WriteLine("Incorrectly placed brackets!");
            else
                Console.WriteLine("Correctly placed brackets!");

        }
    }
}
