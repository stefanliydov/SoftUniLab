using System;
using System.Text.RegularExpressions;

namespace MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"[A-Z]\w+\s[A-Z]\w+";
            Regex stringa = new Regex(pattern);

            var stringInput = Console.ReadLine();

            var test = stringa.IsMatch(stringInput);
            Console.WriteLine(test);
        }
    }
}
