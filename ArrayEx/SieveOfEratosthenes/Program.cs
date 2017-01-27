using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            bool isPrime = true;
            for (int i = 2; i < n; i++)
            {
                for (int j = 2; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                    else
                        isPrime = true;
                }
                if(isPrime==true)
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
    }
}
