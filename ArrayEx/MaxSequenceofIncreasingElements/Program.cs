using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceofIncreasingElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var start = 0;
            var len = 0;
            var maxLen = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    len++;
                    if (len > maxLen)
                    {
                        start = i - len ;
                        maxLen = len;
                    }
                }

                else
                    len = 0;
            }
            for (int i = start+1; i <= start+maxLen+1; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();
        }
    }
}
