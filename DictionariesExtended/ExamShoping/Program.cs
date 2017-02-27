using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamShoping
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();

            var command = Console.ReadLine().Split();
            while(command[0] !="shopping" && command[1] != "time")
            {
                var item = command[1];
                var quantity = int.Parse(command[2]);
                if (!dict.ContainsKey(item))
                    dict[item] = quantity;
                else
                dict[item] += quantity; 
                command = Console.ReadLine().Split();
            }
            command = Console.ReadLine().Split();
            while (command[0] != "exam" )
            {
                var item = command[1];
                var quantity = int.Parse(command[2]);
                if (!dict.ContainsKey(item))
                    Console.WriteLine(item + " doesn't exist");
                else if (dict[item] == 0)
                    Console.WriteLine(item + " out of stock");
                else if (dict[item] <= quantity)
                    dict[item] = 0;
                else
                    dict[item] -= quantity;


                command = Console.ReadLine().Split();
            }
            foreach (var item in dict)
            {
                if(item.Value>0)
                    Console.WriteLine(item.Key+ " -> "+ item.Value);
            }
        }
    }
}
