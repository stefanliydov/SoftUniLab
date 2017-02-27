using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootListElement
{
    class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            var list = new List<string>();
            var lastRemoved = string.Empty;
            while (command != "stop")
            {
                if (command == "bang")
                {
                   
                    if(list.Count == 0)
                    {
                        Console.WriteLine($"nobody left to shoot! last one was {lastRemoved}");
                        break;
                    }
                    var average = 0.0;
                    for (int i = 0; i < list.Count; i++)
                    {
                        average += int.Parse(list[i]); 
                    }
                    average /= list.Count;

                    for (int i = 0; i < list.Count; i++)
                    {
                        if (int.Parse(list[i]) <= average)
                        {
                            lastRemoved = list[i]; 
                            list.RemoveAt(i);
                            break;
                        }
                    }
                    Console.WriteLine("shot "+lastRemoved);
                    for (int i = 0; i < list.Count; i++)
                    {
                        var num = int.Parse(list[i]);
                        if (num > 0)
                            num--;
                        list.RemoveAt(i);
                        list.Insert(i, num.ToString());
                    }
                }
                else
                    list.Insert(0, command);
                command = Console.ReadLine();
            }
            if (command == "stop"&& list.Count==0)
            {
                Console.WriteLine($"you shot them all. last one was {lastRemoved}");
            }
            else if(command =="stop"&& list.Count > 0)
            {
                Console.WriteLine("survivors: "+ string.Join(" ", list));
            }
        }
    }
}
