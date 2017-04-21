using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlattenDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, Dictionary<string, string>>();
            var command = Console.ReadLine().Split();

            while(command[0] != "end")
            {
                var type = command[0];
                var company = command[1];
                var model = command[2];

                var newDict = new Dictionary<string, string>();
                
                if (!dict.ContainsKey(type))
                    dict[type] = newDict;

                dict[type][company] = model;
                              
            }

            dict.OrderByDescending(x => x.Key.Length);
            
            foreach (var item in dict)
            {
                item.Value.OrderBy(x => x.Key.Le)
            }
        }
    }
}
