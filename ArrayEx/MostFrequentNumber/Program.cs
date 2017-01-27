using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var count = 0;
            var number = 0;
            
            var maxCount = 0;
            for (int i = 0; i <=arr.Length-1; i++)
            {
                for (int r = i+1; r <= arr.Length -1; r++)
                {
                    if (arr[i] == arr[r])
                    {
                        count++;
                        
                        if (count > maxCount)
                        {
                            maxCount = count;
                            number = arr[i];
                        }
                    }
                    count = 0;
                }
                


            }
            Console.Write(number + " ");
            Console.WriteLine();
        }
    }
}
