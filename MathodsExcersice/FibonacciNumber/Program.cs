using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = long.Parse(Console.ReadLine());

            Console.WriteLine(Fibonacci(num));
    
        }
        static long Fibonacci(long num)
        {
            long a = 0;
            long b = 1;
            for (int i = 0; i <= num; i++)
            {
                long temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
    }
}
