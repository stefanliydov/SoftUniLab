using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceofEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var count = 1;
            var biggestCount = 1;
            var start = 0;
            for (int i = 0; i < list.Count -1; i++)
            {
                if (list[i] == list[i + 1])
                {
                    count++;

                    if (count > biggestCount)
                    {
                        biggestCount = count;
                        start = i-count+2;
                    }
                }
                else
                    count = 1;
            }
            for (int i = start; i < start+biggestCount; i++)
            {
                Console.Write(list[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
