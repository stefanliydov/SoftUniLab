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
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = numbers.Length / 4;
            int[] middleNum = new int[2 * k];
            int[] firstNumRev = new int[k];
            int[] lastNumRev = new int[k];
            for (int i = 0; i < k; i++)
                firstNumRev[i] = numbers[i];
            for (int i = numbers.Length - 1; i > numbers.Length - 1 - k; i--)
                lastNumRev[i - 3 * k] = numbers[i];
            for (int i = 0 ; i <2* k; i++)
                middleNum[i] = numbers[i+k];

             Array.Reverse(firstNumRev);
             Array.Reverse(lastNumRev);
            
            for (int i = 0; i < k; i++)  
                middleNum[i] += firstNumRev[i];
            for (int i = 0; i < k; i++)
            {
                middleNum[i + k] += lastNumRev[i];
            }
            Console.WriteLine(string.Join(" ",middleNum));

        }
    }
}
