using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                var currNumb = int.Parse(Console.ReadLine());
                arr[i] = currNumb;
            }
            Console.WriteLine("Sum = "+ arr.Sum());
            Console.WriteLine("Min = " +arr.Min());
            Console.WriteLine("Max = " +arr.Max());
            Console.WriteLine("Average = " + arr.Average());
        }
    }
}
