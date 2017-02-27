using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipList
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            Console.WriteLine(ListReverser(list));

  
            

        }

        private static string ListReverser(List<int> list)
        {
            for (int i = 1; i <= (list.Count - 1) / 2; i++)
            {


                var temp = 0;
                temp = list[i];
                list[i] = list[list.Count - 1 - i];
                list[list.Count - 1 - i] = temp;

            }
            string numbers = string.Empty;
            foreach (var item in list)
            {
                numbers += item+" ";
            }
            return numbers;
        }
    }
}
