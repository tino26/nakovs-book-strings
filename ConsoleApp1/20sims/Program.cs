using System;
namespace _20sims
{
    class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();
            if (input.Length > 20)
            {
                Console.WriteLine("TOO LONG");
            }else if (input.Length == 20)
            {
                return;
            }
            else
            {
                while (input.Length<20)
                {
                    input += '*';
                }
            }
            Console.WriteLine(input);
        }
    }
}
