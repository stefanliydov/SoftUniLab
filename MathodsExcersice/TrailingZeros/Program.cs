using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TrailingZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var n = Factorial(num);
            Console.WriteLine($"{ZeroCounter(n)} trailing zeroes");
        }

        public static BigInteger Factorial(int num)
        {
            BigInteger totalMulti = 1;

            for (int i = 1; i <= num; i++)
            {
                totalMulti *= i;
            }
            return totalMulti;
        }
        public static int ZeroCounter(BigInteger n)
        {
            var zerocount = 0;
            var number = n;
            while(n % 10 == 0)
            {
                number = n % 10;
                n /= 10;
                if (number == 0)
                    zerocount++;
                else
                    break;
                
                  
            }
            return zerocount;
        }
    }
}
