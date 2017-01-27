using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine().Split(' ');
            string[] secondArray = Console.ReadLine().Split(' ');

            int count = 0;
            int Maxcount = 0;
            int revCount = 0;
            int revMaxCount = 0;
            var arrDiff = Math.Max(firstArray.Length, secondArray.Length) - Math.Min(firstArray.Length, secondArray.Length);
            if (firstArray.Length >= secondArray.Length)
            {
                
                for (int i = 0; i < secondArray.Length-1; i++)
                {
                    if (firstArray[i] == secondArray[i])
                        count++;
                    else
                    {
                        if (Maxcount < count)
                            Maxcount = count;
                    }
                    count = 0;
                        

                }
                for (int i =secondArray.Length-1; i >= 0; i--)
                {

                    if (firstArray[(i + arrDiff)] == secondArray[i])
                        revCount++;
                    else
                    {
                        if (revMaxCount < revCount)
                            revMaxCount = revCount;
                    }
                    revCount = 0;

                }
                
            }

            else
            {
                
                for (int i = 0; i < firstArray.Length-1; i++)
                {
                    if( firstArray[i] == secondArray[i])
                        count++;
                   
                  else
                    {
                        if (Maxcount < count)
                            Maxcount = count;
                    }
                    count = 0;
                }
                for (int i = firstArray.Length-1; i >= 0; i--)
                {
                    if (firstArray[i] == secondArray[i+arrDiff])
                        revCount++;
                    else
                    {
                        if (revMaxCount < revCount)
                            revMaxCount = revCount;
                    }
                    revCount = 0;
                }

            }
            Console.WriteLine(Math.Max(revMaxCount, Maxcount));
            
        }
    }
}
