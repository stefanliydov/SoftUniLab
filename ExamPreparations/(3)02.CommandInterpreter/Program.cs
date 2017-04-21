using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_02.CommandInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            var stringArr = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();

            var command = Console.ReadLine();

            while (command != "end")
            {
                var splitted = command.Split();

                if (splitted[0] == "reverse")
                {
                    var start = int.Parse(splitted[2]);
                    var count = int.Parse(splitted[4]);
                    if (start < stringArr.Count && start >= 0 && (count + start) <= stringArr.Count && (count + start) >= 0)
                        stringArr.Reverse(start, count);

                    else
                        Console.WriteLine("Invalid input parameters.");

                }
                else if (splitted[0] == "sort")
                {
                    var start = int.Parse(splitted[2]);
                    var count = int.Parse(splitted[4]);

                    if (start < stringArr.Count && start >= 0 && (count + start) <= stringArr.Count && (count + start) >= 0)
                        stringArr.Sort(start, count, null);

                    else
                        Console.WriteLine("Invalid input parameters.");

                }
                else if (splitted[0] == "rollLeft")
                {

                    var count = int.Parse(splitted[1]);
                    if (count > 0) { 
                    count %= stringArr.Count;
                        for (int i = 0; i < count; i++)
                        {
                            var currNum = stringArr[0];
                            stringArr.RemoveAt(0);
                            stringArr.Add(currNum);

                        }
                    }

                    else
                        Console.WriteLine("Invalid input parameters.");
                }
                else if (splitted[0] == "rollRight")
                {
                    var count = int.Parse(splitted[1]);
                    if(count > 0) { 
                    count %= stringArr.Count;
                        for (int i = 0; i < count; i++)
                        {
                            var currNum = stringArr[stringArr.Count - 1];
                            stringArr.RemoveAt(stringArr.Count - 1);
                            stringArr.Insert(0, currNum);
                        }
                    }

                    else
                        Console.WriteLine("Invalid input parameters.");
                }


                command = Console.ReadLine();
            }
            Console.WriteLine("[" + String.Join(", ", stringArr) + "]");
        }
    }
}
