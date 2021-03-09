using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
namespace shifur
{
    class Program
    {
        public static void xorEncryption(string text, string encryptionCode)
        {
            StringBuilder szOutStringBuild = new StringBuilder(text.Length);
            char TextChar;
            int i = 0;
            while (i < text.Length)
            {
                for (int iCount = 0; iCount < encryptionCode.Length; iCount++)
                {
                    if (i >= text.Length)
                    {
                        break;
                    }
                    TextChar = (char)(text[i] ^ encryptionCode[iCount]);
                    szOutStringBuild.Append(TextChar);
                    i++;
                }
            }
            var output = szOutStringBuild.ToString().Select(c => Convert.ToUInt16(c)).ToList();
            foreach(var item in output)
            {
                Console.Write($"\\u{item:X4}");
            }
        }
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string code = Console.ReadLine();
            xorEncryption(input, code);
        }
    }
}
