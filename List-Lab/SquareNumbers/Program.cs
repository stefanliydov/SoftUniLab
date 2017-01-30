using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var sqrtOnlyList = new List<int>();
            foreach (var item in list)
            {
                if (Math.Sqrt(item)==(int)Math.Sqrt(item))
                {
                    sqrtOnlyList.Add(item);
                }
            }
            sqrtOnlyList.Sort();
            sqrtOnlyList.Reverse();
            Console.WriteLine(string.Join(" ",sqrtOnlyList));
        }
    }
}
