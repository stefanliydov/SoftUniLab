using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var revList = new List<int>();

            foreach (var number in list )
            {
                int left = number;
                int n = number;
                int rev = 0;
                while (n > 0)
                {
                    left %= 10;
                    rev = rev * 10 + left;
                    n /= 10;
                    left = n;
                }
                revList.Add(rev);
            }
            var sum = 0;
            for (int i = 0; i < revList.Count; i++)
                sum += revList[i];
            Console.WriteLine(sum);
           

        }
    }
}
