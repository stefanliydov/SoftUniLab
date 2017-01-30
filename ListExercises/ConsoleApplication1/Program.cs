using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = 2;
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            for (int i = 0; i < list.Count; i++)
            {
                if (i == list.Count - 1) { }

                else
                {
                    list[i] = list[i] + list[i + 1];
                    list.RemoveAt(i + 1);
                }

            }
            list.ForEach(Console.WriteLine);
        }
    }
}
