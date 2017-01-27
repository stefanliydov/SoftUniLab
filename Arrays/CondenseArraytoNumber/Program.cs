using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CondenseArraytoNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numString = Console.ReadLine().Split(' ');
            int[] num = new int[numString.Length];
            for (int i = 0; i < numString.Length; i++)
                num[i] = int.Parse(numString[i]);

            while (num.Length > 1)
            {
                int[] condensed = new int[num.Length-1];

                for (int i = 0; i < num.Length-1; i++)
                {
                    condensed[i] = num[i] + num[i + 1];
                    
                }
                num = condensed;

            }
            Console.WriteLine(num[0]);

        }
    }
}
