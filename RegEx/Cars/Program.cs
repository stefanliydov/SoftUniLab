using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;


namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = @"([1]?[0-9JQKA])[SHDC]";
            var regex = new Regex(pattern);

            var validCards = new List<string>();
            var matches = regex.Matches(input);
            string text = string.Empty;
            foreach (Match item in matches)
            {
                
                int power = 0;
                if(int.TryParse(item.Groups[1].Value, out power))
                {
                    if (power < 2 || power > 10)
                        continue;
                }
                validCards.Add(item.Value);
            }
           
            Console.WriteLine(string.Join(", ",validCards));
        }
    }
}
