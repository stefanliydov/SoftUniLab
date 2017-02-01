using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();
            dict["Pesho"] = 5;
            var value = dict["Pesho"];
            Console.WriteLine(value);
        }
    }
}
