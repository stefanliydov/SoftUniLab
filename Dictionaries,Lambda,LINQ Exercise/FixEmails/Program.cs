using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            bool test = false;
            var dict = new Dictionary<string, string>();
            while(test == false)
            {
                string name = Console.ReadLine();
                string email = Console.ReadLine();
                if(name =="stop" || email == "stop")
                {
                    test = true;
                    break;
                }
                
                dict[name] = email;
            }
            var finalDict = dict
                .Where(x => !x.Value.ToLower().EndsWith("uk") && !x.Value.ToLower().EndsWith("us"))
                .ToDictionary(x => x.Key, x => x.Value);
            foreach (var item in finalDict)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
