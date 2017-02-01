using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace АMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            bool test = true;
            var resQuaDict = new Dictionary<string, long>();
            while(test == true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    test = false;
                    break;              
                }
                 long quantity = long.Parse(Console.ReadLine());
                if (resQuaDict.ContainsKey(resource))
                    resQuaDict[resource] += quantity;
                else
                resQuaDict[resource] = quantity;
            }
            foreach (var resource in resQuaDict)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
