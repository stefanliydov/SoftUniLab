using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForumTopics
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, HashSet<string>>();

            var command = Console.ReadLine().Split(new char[] { ' ', '-', ',', '>' }, StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "filter")
            {
                var topic = command[0];
                var hash = new HashSet<string>();
                for (int i = 1; i < command.Length; i++)
                    hash.Add(command[i]);

                if(!dict.ContainsKey(topic))
                dict[topic]=hash;
                else
                {
                    for (int i = 1; i < command.Length; i++)
                    {
                        var word = command[i];
                        dict[topic].Add(word);
                    }

                }
                command = Console.ReadLine().Split(new char[] { ' ', '-', ',', '>' }, StringSplitOptions.RemoveEmptyEntries);

            }
            command = Console.ReadLine().Split(new char[] { ' ', ',', }, StringSplitOptions.RemoveEmptyEntries);
            foreach (var item in dict)
            {
                var count = 0;
                foreach (var hashItem in item.Value)
                {

                    for (int p = 0; p < command.Length; p++)
                    {
                        if (hashItem == command[p])
                            count++;
                    }
                }
                if(count == command.Length)
                    Console.WriteLine($"{item.Key} | #"+string.Join(", #", item.Value));
            }
        }
    }
}
