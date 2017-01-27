using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequenceOfEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrElements = Console.ReadLine().Split(' ');

            var start = 0;
            var len = 1;
            var bestStart = start;
            var bestLen = 0;
           
            for (int i = 0; i < arrElements.Length - 1; i++)
            {
                if (arrElements[i] == arrElements[i + 1])
                {
                    len++;
                    if (len == 2)
                    {
                        start = i;
                        
                    }
                    

                        if (len > bestLen)
                    {
                        bestStart = i+1-len;
                        bestLen = len;

                    }
                }                              
                else if (arrElements[i] != arrElements[i + 1])
                {
                    
                    len = 1;
                }
                
                

            }
            
            for (int i = bestStart+1; i <= bestLen+bestStart-1; i++)
            {
                Console.Write($"{arrElements[i]} ");
            }
            Console.WriteLine();
        }
    }
}
