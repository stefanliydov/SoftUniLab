using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstText = Console.ReadLine().Split(' ');
            string[] secondText = Console.ReadLine().Split(' ');

            int[] arr1 = new int[firstText.Length];
            int[] arr2
                =new int[secondText.Length];
            for (int i = 0; i < firstText.Length; i++)
            {
                arr1[i]= int.Parse(firstText[i]);
                
            }
            for (int i = 0; i < secondText.Length; i++)
            {
                arr2[i] = int.Parse(secondText[i]);
            }
            var MaxLenght = Math.Max(arr1.Length, arr2.Length);
            var r = 0;
            int[] sum = new int[MaxLenght];
            for (int i = 0; i < MaxLenght; i++)
            {
                if (i >= arr1.Length) {
                    r = i % arr1.Length;
                    sum[i] = arr1[r] + arr2[i];
                }
                else if (i >= arr2.Length)
                        {

                    r = i % arr2.Length;
                    sum[i] = arr1[i] + arr2[r];
                }
                else
                    sum[i] = arr1[i] + arr2[i];

            }
            
            Console.WriteLine(string.Join(" ", sum));
           
        }
    }
}
