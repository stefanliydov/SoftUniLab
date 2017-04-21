using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var listInput = Console.ReadLine().Split().ToList();
            var rndm = new Random();
            var count = listInput.Count;
            for (int i = 0; i < count; i++)
            { var n = rndm.Next(0, listInput.Count - 1);
                Console.WriteLine(listInput[n]);
                listInput.RemoveAt(n);
            }
        }
    }
}
