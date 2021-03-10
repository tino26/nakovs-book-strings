using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace keyWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] keyWord = Console.ReadLine().Split(',');
            foreach (var item in keyWord)
            {
                Regex rg = new Regex(@"(\b)" + item + @"(\b)?");
                Match match = rg.Match(input.ToString());
                input=rg.Replace(input.ToString(), new string('*', item.Length));
            }
            Console.WriteLine(input);
        }
    }
}
