using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_02.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split().Select(int.Parse).ToList();

            var command = Console.ReadLine(); 

            while( command != "end")
            {
                var splitted = command.Split();

                switch (splitted[0])
                {
                    case "exchange":
                        var splitIndex = int.Parse(splitted[1]);
                        if (splitIndex < list.Count  && splitIndex >= 0)
                        {
                            var currList = list.GetRange(splitIndex+1, list.Count  - 1 - splitIndex);
                            list.RemoveRange(splitIndex + 1, list.Count - 1 - splitIndex);
                            list.InsertRange(0, currList);
                        }
                        else
                            Console.WriteLine("Invalid index");
                            break;

                    case "max":
                    if(splitted[1] == "even")
                        {
                            var evenList = list.Where(x => x % 2 == 0).ToList();
                            if (evenList.Count > 0)
                            {
                                var biggestEvenNumber = evenList.Max();
                                var indexOf = list.LastIndexOf(biggestEvenNumber);
                                Console.WriteLine(indexOf);
                            }
                            else
                                Console.WriteLine("No matches");
                        }
                    else if (splitted[1] == "odd")
                        {
                            var oddList = list.Where(x => x % 2 != 0).ToList();
                            if (oddList.Count > 0)
                            {
                                var biggestOddNumber = oddList.Max();
                                var indexOf = list.LastIndexOf(biggestOddNumber);
                                Console.WriteLine(indexOf);
                            }
                            else
                                Console.WriteLine("No matches");
                        }
                        break;

                    case "min":
                        if (splitted[1] == "even")
                        {
                            var evenList = list.Where(x => x % 2 == 0).ToList();
                            if (evenList.Count > 0)
                            {
                                var smallestEvenNumber = evenList.Min();
                                var indexOf = list.LastIndexOf(smallestEvenNumber);
                                Console.WriteLine(indexOf);
                            }
                            else
                                Console.WriteLine("No matches");
                        }
                        else if (splitted[1] == "odd")
                        {
                            var oddList = list.Where(x => x % 2 != 0).ToList();
                            if (oddList.Count > 0)
                            {
                                var smallestOddNumber = oddList.Min();
                                var indexOf = list.LastIndexOf(smallestOddNumber);
                                Console.WriteLine(indexOf);
                            }
                            else
                                Console.WriteLine("No matches");
                        }
                        break;

                    case "first":
                        var count = int.Parse(splitted[1]);
                        if (list.Count >= count)
                        {
                            if (splitted[2] == "even")
                            {
                                var evenList = list.Where(x => x % 2 == 0).ToList();
                                if (evenList.Count > 0)
                                {
                                    if (evenList.Count < count)
                                        count = evenList.Count;

                                    evenList = evenList.GetRange(0, count);                               
                                Console.WriteLine("[" + string.Join(", ", evenList) + "]");
                            }
                            else
                            Console.WriteLine("[]");
                      
                            }
                            if (splitted[2] == "odd")
                            {
                                var oddList = list.Where(x => x % 2 != 0).ToList();
                                if (oddList.Count >= 0)
                                {
                                    if (oddList.Count < count)
                                        count = oddList.Count;
                                    oddList = oddList.GetRange(0, count);
                                    Console.WriteLine("[" + string.Join(", ", oddList) + "]");
                                }
                                else
                                    Console.WriteLine("[]");
                            }
                        }
                        else
                            Console.WriteLine("Invalid count");
                        break;

                    case "last":
                        var count1 = int.Parse(splitted[1]);
                        if (list.Count >= count1)
                        {
                            if (splitted[2] == "even")
                            {
                                var evenList = list.Where(x => x % 2 == 0).ToList();
                                if (evenList.Count > 0)
                                {
                                    if (evenList.Count < count1)
                                        count1 = evenList.Count;
                                    evenList = evenList.GetRange(evenList.Count - count1, count1);
                                    Console.WriteLine("[" + string.Join(", ", evenList) + "]");
                                }
                                else
                                    Console.WriteLine("[]");

                            }
                            if (splitted[2] == "odd")
                            {
                                var oddList = list.Where(x => x % 2 != 0).ToList();
                                if (oddList.Count > 0)
                                {
                                    if (oddList.Count < count1)
                                        count1 = oddList.Count;
                                    oddList = oddList.GetRange(oddList.Count - count1, count1);
                                    Console.WriteLine("[" + string.Join(", ", oddList) + "]");
                                }
                                else
                                    Console.WriteLine("[]");
                            }
                        }
                        else
                            Console.WriteLine("Invalid count");
                        break;
                        



                }
                command = Console.ReadLine();
            }


            Console.WriteLine("["+ string.Join(", ",list) +"]");
        }
    }
}
