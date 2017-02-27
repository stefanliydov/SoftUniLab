using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElementsOnOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().ToList();

            for (int i = 1; i < list.Count; i+=2)
                Console.Write(list[i]);
            Console.WriteLine();

        }
    }
}
