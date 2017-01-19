using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseChar
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char sec = char.Parse(Console.ReadLine());
            char third = char.Parse(Console.ReadLine());
            Console.WriteLine($"{third}{sec}{first}");
        }
    }
}
