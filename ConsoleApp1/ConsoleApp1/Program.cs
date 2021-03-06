using System;
using System.Text;
namespace ConsoleApp1
{
    class Program
    {
        public static string flipString(string input)
        {
            StringBuilder flipped = new StringBuilder();
            for(int i=input.Length-1; i>=0; i--)
            {
                flipped.Append(input[i]);
            }
            return flipped.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(flipString(Console.ReadLine()));
            
        }
    }
}
