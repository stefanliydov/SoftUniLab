using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extremums
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();
            var command = Console.ReadLine().ToLower();
            if (command == "max")
            {
                var numberList = new List<int>();

                for (int i = 0; i < list.Count; i++)
                {
                    var currNum = list[i];
                    while (currNum > 0)
                    {
                        var temp = currNum % 10;
                        currNum /= 10;
                        numberList.Add(temp);
                    }
                    numberList.Reverse();

                    var number = string.Empty;
                    var numberCheck = 0;
                    for (int k = 0; k < numberList.Count; k++)
                    {
                        number = string.Empty;

                        var temp = numberList[0];
                        numberList.RemoveAt(0);
                        numberList.Add(temp);
                        for (int p = 0; p < numberList.Count; p++)
                        {
                            number += numberList[p];
                        }
                        if (int.Parse(number) > numberCheck)
                            numberCheck = int.Parse(number);
                    }
                    list[i] = numberCheck;
                    numberList.Clear();
                }
            }
            else if (command == "min")
            {
                var numberList = new List<int>();

                for (int i = 0; i < list.Count; i++)
                {
                    var currNum = list[i];
                    while (currNum > 0)
                    {
                        var temp = currNum % 10;
                        currNum /= 10;
                        numberList.Add(temp);
                    }
                    numberList.Reverse();

                    var number = string.Empty;
                    var numberCheck =int.MaxValue();
                    for (int k = 0; k < numberList.Count; k++)
                    {
                        number = string.Empty;

                        var temp = numberList[0];
                        numberList.RemoveAt(0);
                        numberList.Add(temp);
                        for (int p = 0; p < numberList.Count; p++)
                        {
                            number += numberList[p];
                        }
                        if (int.Parse(number) < numberCheck)
                            numberCheck = int.Parse(number);
                    }
                    list[i] = numberCheck;
                    numberList.Clear();
                }

            }
            Console.WriteLine(string.Join(", ", list));
            Console.WriteLine(list.Sum());
        }
    }
}
