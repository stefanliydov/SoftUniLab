using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortWordSorter
{
    class Program
    {
        static void Main(string[] args)
        {

            var list = Console.ReadLine()
                .ToLower()
                .Split(
                new char[] { ' ', '.', ',', ':', ';', '(', ')', '[', ']', '"', '\'', '/', '!', '?', }, StringSplitOptions.RemoveEmptyEntries)
                .ToList()
                .Where(x => x.Length < 5)
                .OrderBy(x => x)
                .Distinct();
                
            Console.WriteLine(string.Join(", ",list));
              
        }
    }
}
