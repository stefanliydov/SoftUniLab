using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TearListInHalf
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var listCount = list.Count;
           var count = 0;
            for (int i = list.Count / 2 -1; i >= 0 ; i--)
            {
             int lastDig = list[listCount / 2 + i+count] % 10;
             int firstdig = list[listCount / 2 + i+count] / 10;
                list.RemoveAt(listCount / 2 + i+count);
                list.Insert(i + 1, lastDig);
                list.Insert(i, firstdig);
                count +=2;
            }
            Console.WriteLine(string.Join(" ",list));
        }
    }
}
