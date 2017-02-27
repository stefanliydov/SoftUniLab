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
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var k = list.Count / 4;
            var firstHalf = list.Take(k).Reverse().ToList();
            var lastHalf = list.Take(k).Reverse().ToList();
            var middle = list.Skip(k).Take(2 * k).ToList();
          var ready=  firstHalf.Concat(lastHalf).ToList();
            var string1 = string.Empty;
            for (int i = 0; i < k*2; i++)
            {
              var sum= ready[i] + middle[i];
                string1 += sum + " ";

            }
            Console.WriteLine(string1);
        }
    }
}
