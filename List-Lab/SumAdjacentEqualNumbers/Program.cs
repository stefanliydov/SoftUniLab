using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumAdjacentEqualNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputList = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();

            for (int i = 0; i < inputList.Count-1; i++)
            {
                if (inputList[i] == inputList[i + 1])
                {
                    inputList[i] = inputList[i] + inputList[i + 1];
                    inputList.RemoveAt(i + 1);
                    i = -1;
                }
            }
            Console.WriteLine(string.Join(" ",inputList));
        }
    }
}
