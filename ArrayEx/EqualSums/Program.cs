using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
            
            bool ifFound = false;
            for (int middleElement = 0; middleElement < arr.Length ; middleElement++)
            {
                int rightsum = 0;
                int leftsum = 0;
                for (int i = middleElement+1; i <   arr.Length ; i++)
                {
                    rightsum += arr[i];
                }
                for (int i = 0; i < middleElement; i++)
                {
                    leftsum += arr[i];
                }
                if (rightsum == leftsum)
                {
                    ifFound = true;
                    Console.WriteLine(middleElement);
                }
            }
            if(ifFound == false)
                Console.WriteLine("no");
        }
    }
}
