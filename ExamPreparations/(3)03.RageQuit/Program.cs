using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;

namespace _3_03.RageQuit
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputLine = Console.ReadLine();

            var matches = Regex.Matches(inputLine, @"(\D+)(\d+)");
            

            StringBuilder result = new StringBuilder();
            
            foreach (Match match in matches)
            {
                var sym = match.Groups[1].Value;
                var count = int.Parse(match.Groups[2].Value);
                result.Append(Repeat(sym, count).ToUpper());
            
            }
            var count1 = result.ToString().Distinct().Count();
            Console.WriteLine("Unique symbols used: {0}",count1);
            Console.WriteLine(result.ToString());




        }
        public static string Repeat (string sym, int count)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < count; i++)
            {
                result.Append(sym);
            }
            return result.ToString();
        }
    }
}
