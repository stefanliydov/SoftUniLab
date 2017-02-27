using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistinctList
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> nums2 = new List<int>();
            for (int i = 0; i < num.Count; i++)
            {
                if (!nums2.Contains(num[i]))
                    nums2.Add(num[i]);

            }
            Console.WriteLine(string.Join(" ",nums2));

        }
    }
}
