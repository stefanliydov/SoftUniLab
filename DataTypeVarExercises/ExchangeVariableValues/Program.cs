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
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
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
