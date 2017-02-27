using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineCraft
{
    class Program
    {
        static void Main(string[] args)
        {
            var grapeList = Console.ReadLine().Split().Select(int.Parse).ToList();
            var n = int.Parse(Console.ReadLine());

            while (grapeList.Count > n)
            {
                for (int i = 0; i < n; i++)
                {
                    for (int i = 0; i < grapeList.Count; i++)
                    {
                        if(i==0|| i == grapeList.Count - 1)
                        {
                            grapeList
                        }
                    }
                }
            }

        }
    }
}
