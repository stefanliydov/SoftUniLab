using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            Console.WriteLine(Factorial(num));
        }
        public static BigInteger Factorial(int num)
        {
            BigInteger totalMulti = 1;
            
            for (int i = 1; i <= num; i++)
            {
                totalMulti*=i;
            }
            return totalMulti;
        }
    }
}
