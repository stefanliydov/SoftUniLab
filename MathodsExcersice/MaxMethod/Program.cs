using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMax(a,b,c));

        }
        static int GetMax(int a, int b)
        {
            int max = Math.Max(a, b);
            return max;
        }
        static int GetMax(int a, int b, int c)
        {
            int test= GetMax(a, b);
            if (test > c)
                return test;
            else
                return c;
        }
    }
}
