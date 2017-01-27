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
            int k = int.Parse(Console.ReadLine());
            int[] num = new int[input.Length];

            
            for (int i = 0; i <= input.Length-1; i++)
                num[i] = int.Parse(input[i]);

            int[] sumString = new int[input.Length];
           
            for (int r = 0; r < k; r++)
            {
                int lastNumber = num[num.Length - 1];
                for (int i = input.Length - 1; i > 0; i--)
                {
                    num[i] = num[i - 1];
                }
                num[0] = lastNumber;
                for (int i = 0; i < input.Length; i++)
                    sumString[i] += num[i];         

            }
            Console.WriteLine(string.Join(" ",sumString));         
                    
        }
    }
}
