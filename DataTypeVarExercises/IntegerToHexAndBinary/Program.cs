using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

           var a=(Convert.ToString(num,16));
            Console.WriteLine(a.ToUpper());

            Console.WriteLine(Convert.ToString(num, 2));
            
        }
    }
}
