using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_02.LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrLength = int.Parse(Console.ReadLine());
            var bugIndexes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var command = Console.ReadLine();

            int[] arr = new int[arrLength];
            arr = BugPositions(arr, bugIndexes);
          
            
            while (command != "end")
            {
               var splitted = command.Split();
                var currPos = int.Parse(splitted[0]);
                var direction = splitted[1];
                var steps = int.Parse(splitted[2]);
            
                if(currPos < 0 || currPos >= arr.Length)
                {
                    command = Console.ReadLine();
                    continue;
                }

                var futurePos = 0;
                    try
                {
                    if (arr[currPos] == 0)
                    {
                        command = Console.ReadLine();
                        continue;
                    }
                    arr[currPos] = 0;
                    if (direction == "right")
                        futurePos = currPos + steps;
                    else
                        futurePos = currPos - steps;
                    
                    while (true)
                    {
                        if (arr[futurePos] == 0)
                        {
                            
                            arr[futurePos] = 1;
                            
                            break;
                        }
                        if (direction == "right")
                            futurePos++;
                        else
                            futurePos--;
                   

                    }
                }                  
                  catch
                    {
                      
                    }
                
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", arr));
        }


        public static int[] BugPositions (int[] arr, int[] bugIndexes)
        {
            for (int i = 0; i < bugIndexes.Length; i++)
            {
                try
                {
                    arr[bugIndexes[i]] = 1;
                }
                catch { }


            }
            return arr;
        }
    }
}
