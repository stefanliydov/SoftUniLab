using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            for( var i = 1; i<= n; i++)
            {
                int sum = 0;
                var number = i;
                while (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }
                bool test = sum == 5 || sum == 7 || sum == 11;
                Console.WriteLine($"{i} -> {test}");
            }
        }
    }
}
