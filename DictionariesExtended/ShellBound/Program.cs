using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShellBound
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, HashSet<int>>();
            var command = Console.ReadLine().Split();
            while (command[0] != "Aggregate")
            {
                var cityName = command[0];
                var shellSize = int.Parse(command[1]);
                if (!dict.ContainsKey(cityName))
                {
                    var hashSet = new HashSet<int> { shellSize };
                    dict[cityName] = hashSet;
                }
                else
                    dict[cityName].Add(shellSize);
                command = Console.ReadLine().Split();
            }
            foreach (var item in dict)
            {
                var cityName = item.Key;
                var shellSizes = string.Join(", ", item.Value);
                var newShellsize = item.Value.Sum() - item.Value.Sum() / item.Value.Count;
                Console.WriteLine($"{cityName} -> {shellSizes} ({newShellsize})");
            }
        }
    }
}
