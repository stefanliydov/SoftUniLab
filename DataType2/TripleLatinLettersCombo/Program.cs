using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleLatinLettersCombo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for(var i1 = 0; i1 < n; i1++)
                for (var i2 = 0; i2 < n; i2++)
                    for (var i3 = 0; i3 < n; i3++)
                    {
                        Console.WriteLine($"{(char)(i1 + 97)}{(char)(i2 + 97)}{(char)(i3 + 97)}");
                    }     
        }
    }
}
