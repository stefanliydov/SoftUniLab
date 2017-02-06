using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace задачаНаНякъвТип
{
    class Program
    {
        static void Main(string[] args)
        {var input = Console.ReadLine();
        var command = input.First();
        var customerData = input
             .Split(' ')
             .Skip(1);
        var dict = customerData
            .Select(s => s.Split(' '))
            .ToDictionary(key => key[0].Trim(), value => value[0].Trim());
        }
    }
}
