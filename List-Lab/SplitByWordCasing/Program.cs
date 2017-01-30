using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SplitByWordCasing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine().Split(new char[] { ' ', ',', ';', ':', '.', '!', '(', ')', '"', '\'', '/', '\\', '[', ']' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var lowerCase = new List<string>();
            var mixedCase = new List<string>();
            var upperCase = new List<string>();

            int lowerCount = 0;
            int upperCount = 0;

            for (int i = 0; i < list.Count; i++)
            {
                foreach (var letter in list[i])
                {
                    if (char.IsUpper(letter))
                        upperCount++;
                    else if (char.IsLower(letter))
                        lowerCount++;
                    else
                    {
                        lowerCount++;
                        upperCount++;
                    }

                }
               
                    if (lowerCount != 0 && upperCount != 0)
                    mixedCase.Add(list[i]);
                else if(lowerCount!=0)
                    lowerCase.Add(list[i]);
                else if (upperCount != 0)
                    upperCase.Add(list[i]);

                upperCount = 0;
                lowerCount = 0;
            }
            Console.WriteLine("Lower-case: "+ string.Join(", ",lowerCase));
            Console.WriteLine("Mixed-case: " + string.Join(", ", mixedCase));
            Console.WriteLine("Upper-case: " + string.Join(", ", upperCase));
        }
    }
}
