using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var dict = new Dictionary<char, int>();
            var list = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var currentInout = Console.ReadLine();
                list.Add(currentInout);
            }
            var currCount = 0; 
            var lettersToCount = 1;
            var finalCount = 0;
            var winner = String.Empty;
            for (int i = 0; i < list.Count; i++)
            {

                var charArr =  list[i].ToCharArray();

                for (int p = 0; p < charArr.Length; p++)
                {
                 if(i == 0)
                    {
                        if (!dict.ContainsKey(charArr[p]))
                        {
                            dict[charArr[p]] = 1; 
                        }
                    }
                 else
                    {
                        if (charArr[i] == charArr[i - 1])
                        {
                            currCount++;
                            if (currCount == lettersToCount)
                            {
                                if (!dict.ContainsKey(charArr[i]))
                                {
                                    dict[charArr[i]] = 0;
                                }
                                dict[charArr[i]] += 1;
                            }
                        }

                        else
                        {
                            currCount = 0;
                        }
                    }
                }


            }

        }
    }
}
