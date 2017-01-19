using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExchangeVariableValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 5;
            var b = 10;
            var c = a;
            Console.WriteLine("Before:");
            Console.WriteLine(" a = {0}", a );
            Console.WriteLine(" b = {0}", b);
            Console.WriteLine("After");
            a = b;
            b = c;
            Console.WriteLine(" a = {0}", a);
            Console.WriteLine(" b = {0}", b);
        }
    }
}
