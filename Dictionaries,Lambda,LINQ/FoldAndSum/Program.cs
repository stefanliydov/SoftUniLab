using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = arr.Length / 4;

            var rightRev = arr.Take(k)
                .Reverse()
                .ToArray();

            var leftRev = arr.Reverse()
                .Take(k)
                .ToArray();

            var firstRow = rightRev.Concat(leftRev)
                .ToArray();

            var secondsRow = arr
                .Skip(k)
                .Take(2 * k)
                .ToArray();

            for (int i = 0; i < 2*k; i++)
            {
                Console.Write(firstRow[i]+secondsRow[i]+ " ");
            }
            Console.WriteLine();
        }
    }
}
