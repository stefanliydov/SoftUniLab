using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UninionLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var primalList = Console.ReadLine().Split().Select(int.Parse).ToList();

            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var currList = Console.ReadLine().Split().Select(int.Parse).ToList();
                for (int p = 0; p < currList.Count; p++)
                {
                    if (!primalList.Contains(currList[p]))
                        primalList.Add(currList[p]);
                    else
                    {
                        while (primalList.Contains(currList[p]))
                            primalList.Remove(currList[p]);
                    }
              
                    
                }
            }
            primalList.Sort();
            Console.WriteLine(string.Join(" ",primalList));
        }
    }
}
