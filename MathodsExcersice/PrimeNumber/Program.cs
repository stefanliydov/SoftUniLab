using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            long n = long.Parse(Console.ReadLine());
            Console.WriteLine(isPrime(n));
        }
        public static bool isPrime(long n)
        {
            if (n == 0|| n==1)
                return false;

            for (int i =2; i<=Math.Sqrt(n); i++)
            {
                var testPrime = n % i;
                if (testPrime == 0)
                    return false;
            }
            return true; 
        }
    }
}
