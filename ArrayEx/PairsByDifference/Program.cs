using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairsByDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int diff = int.Parse(Console.ReadLine());
            var count = 0;
            for (int i = 0; i <= arr.Length -1; i++)
            {
                for (int r = i+1; r <= arr.Length -1; r++)
                {
                    if(arr[i] -arr[r] ==diff|| arr[i] - arr[r] == -(diff))
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
