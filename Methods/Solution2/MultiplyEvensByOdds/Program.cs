using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplyEvensByOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            n = Math.Abs(n);
            GetMultipleOfEvensAndOdds(n);
           
        }
        public static void GetMultipleOfEvensAndOdds(int n)
        {
            int evenSum= GetEvenNumbers(n);
            int oddSum = GetOddNumbers(n);
            int Multiply = evenSum * oddSum;
            Console.WriteLine(Multiply);

        }
        public static int GetEvenNumbers(int n)
        {
            var sum = 0;
            while (n > 0)
            {
                int even = n % 2;
                if (even == 0)
                {
                   even= n % 10;
                    sum += even;
                    
                }
                n /= 10;
            }
            return sum;
        }
        public static int GetOddNumbers(int n)
        {
            var sum = 0;
            while (n > 0)
            {
                int odd = n % 2;
                if (odd != 0)
                {
                    odd = n % 10;
                    sum += odd;

                }
                n /= 10;
            }
            return sum;
        }
    }
}
