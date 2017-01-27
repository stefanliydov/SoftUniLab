using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractMiddleElement
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] numString = Console.ReadLine().Split(' ');


            ReturnMiddleDigits(numString);
            

        }
        public static void ReturnMiddleDigits(string[] numString)
        {
            if (numString.Length == 1)
                Console.WriteLine("{ " + $"{numString[0]}" + " }");
            
            else if (numString.Length % 2 == 0)
            {
                string[] newString = new string[2];
                var r = 0;
                for (int i = numString.Length / 2 - 1; i <= numString.Length / 2; i++)
                {
                    newString[r] = numString[i];
                    r++;
                }
                string finishedText = string.Join(",", newString);
                Console.WriteLine("{ " + $"{finishedText}" + " }");
            }
            else
            {
                string[] newString = new string[3];
                var r = 0;
                for (int i = numString.Length / 2 - 1; i <= numString.Length / 2 + 1; i++)
                {
                    newString[r] = numString[i];
                    r++;
                }
                string finishedText = string.Join(",", newString);
                Console.WriteLine("{ " + $"{finishedText}" + " }");
            }
        }
    }
}
