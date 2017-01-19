using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastPrimeChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 0; i <= num; i++)
            {
                bool Check = true;
                for (int checker = 2; checker <= Math.Sqrt(i); checker++)
                {
                    if (i % checker == 0)
                    {
                        Check = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} is prime -> {Check}");
            }

        }
    }
}
