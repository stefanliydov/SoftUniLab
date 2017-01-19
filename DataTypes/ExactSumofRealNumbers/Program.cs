using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExactSumofRealNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbers = int.Parse(Console.ReadLine());
            decimal sum = 0M;

            for ( var i = 0; i< numbers; i++)
            {
                decimal n = decimal.Parse(Console.ReadLine());
                sum =  sum + n;
            }
            Console.WriteLine(sum);
        }
    }
}
