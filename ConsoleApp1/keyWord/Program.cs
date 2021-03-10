using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace keyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sentences = Console.ReadLine().Split('.');
            string keyWord = Console.ReadLine();
            Console.WriteLine(string.Join(Environment.NewLine, sentences.Where(x=>Regex.IsMatch(x, @"(\b)"+keyWord+@"(\b)?"))));
        }
    }
}
