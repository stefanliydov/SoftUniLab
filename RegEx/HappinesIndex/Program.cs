using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HappinesIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputString = Console.ReadLine();
            var regexHappy = new Regex(@"([c\[(*}:;/][)D}\]:;/])|[:;]\*");
            var regexSad = new Regex(@"[:;D)}\]][:;c({\[]");


            var happyCount = regexHappy.Matches(inputString);
            var sadCount = regexSad.Matches(inputString);

            double index = (double)happyCount.Count / sadCount.Count;
            string score = string.Empty;

            if (index >= 2)
                score = ":D";
            else if (index > 1)
                score = ":)";
            else if (index == 1)
                score = ":|";
            else
                score = ":(";

            Console.WriteLine("Happiness index: {0:f2} {1}", index, score);
            Console.WriteLine($"[Happy count: {happyCount.Count}, Sad count: {sadCount.Count}]");


        }
    }
}
