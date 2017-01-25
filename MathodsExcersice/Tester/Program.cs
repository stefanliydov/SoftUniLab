using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            Console.WriteLine(Test(num));



        }
        public static bool Test(int num)
        {
            var checker = 0;
            var evenDigit = 0;
            while (num > 0)
            {
                checker = num % 10;
                num /= 10;
                if (checker % 2 == 0)
                {
                    evenDigit = checker;
                    return true;
                }

            }
            return false;
        }
    }
}
