using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries_Lambda_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').Select(double.Parse);

            var dict = new SortedDictionary<double,int>();
            foreach (var number in numbers)
            {
                if (!dict.ContainsKey(number))
                {
                    dict[number] = 0;
                }
                dict[number]++;
            }
            foreach (var item in dict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value} times");
            }
        }
    }
}
