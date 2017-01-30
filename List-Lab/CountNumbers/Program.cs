using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            list.Sort();
            var count = 1;
            var number = 1;
            for (int i = 0; i <= list.Count-1; i++)
            {
                if (i==list.Count-1 )
                 number = list[i];
               else if (list[i] == list[i + 1])
                    count++;
                else
                {
                    Console.WriteLine($"{list[i]} -> {count}");
                    count = 1;
                }
            }
            Console.WriteLine($"{number} -> {count}");
        }
    }
}
