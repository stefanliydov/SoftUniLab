using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
           
            bool isReady= false;
            List<int> commandNumber = new List<int>();
            List<int> containsNumber = new List<int>();
            
            while (isReady==false)
            {
              var whatDoYouWannaDo = Console.ReadLine().ToLower().Split(' ').ToList();
                string command = whatDoYouWannaDo[0];
                whatDoYouWannaDo.RemoveAt(0);
                commandNumber.AddRange(whatDoYouWannaDo.Select(s => int.Parse(s)).ToList());
                if (command == "print")                               
                   isReady = true;
               
                else if (command == "add")
                    list.Insert(commandNumber[0], commandNumber[1]);
                else if (command == "addmany")
                    for (int i = commandNumber.Count-1; i > 1; i--)
                    {
                        list.Insert(commandNumber[0], commandNumber[i]);
                    }
                else if (command == "contains")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == commandNumber[0])
                        {
                            containsNumber.Add(i);
                            
                            break;
                        }
                       else if (i == list.Count-1)
                            containsNumber.Add(-1);
                    }
                }
                else if (command == "remove")
                    list.RemoveAt(commandNumber[0]);
                else if (command == "shift")
                {
                    for (int i = 0; i < commandNumber[0]; i++)
                    {
                        var first = list[0];
                        list.RemoveAt(0);
                        list.Add(first);
                    }
                }
                else if (command == "sumpairs")
                {
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (i == list.Count - 1) { }

                        else
                        {
                            list[i] = list[i] + list[i + 1];
                            list.RemoveAt(i + 1);
                        }
                     }
                }
                whatDoYouWannaDo.Clear();
                commandNumber.Clear();

                             
            }
            for (int i = 0; i < containsNumber.Count; i++)
                Console.WriteLine(containsNumber[i]);
 
                Console.Write("["+ string.Join(", ",list)+"]");
            Console.WriteLine();
        }
    }
}
