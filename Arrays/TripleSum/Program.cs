using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripleSum
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] arr = Console.ReadLine().Split().Select(long.Parse).ToArray();
            var count = 0;
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                for (int r = 1+i; r <= arr.Length - 1; r++)
                {
                    for (int t = 0; t <= arr.Length - 1; t++)
                    {
                        if (arr[i] + arr[r] == arr[t])
                        {
                            count++;
                            Console.WriteLine($"{arr[i]} + {arr[r]} == {arr[t]}");
                        }
                    }
                }
            }
            if (count == 0)
                Console.WriteLine("No");
        }
    }
}
