using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotateAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int[] num = new int[input.Length];

            
            for (int i = 0; i <= input.Length-1; i++)
            {
                num[i] =Convert.ToInt32(input[i]);
            }
            
         
        }
    }
}
