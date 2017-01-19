using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexadecimalFormatVar
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            Console.WriteLine((Convert.ToInt32(num1, 16)));
        }
    }
}
