using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var users = new SortedDictionary<string, Dictionary<string, int>>();
            while (input != "end")
            {
                string[] splitted = input.Split(' ');
                string ip = GetValue(splitted[0]);
                string user = GetValue(splitted[2]);

                if (!users.ContainsKey(user))
                {
                    users[user] = new Dictionary<string, int>();
                }

                if (users[user].ContainsKey(ip))
                {
                    users[user][ip]++;
                }
                else
                {
                    users[user][ip] = 1;
                }

                input = Console.ReadLine();
            }

            foreach (var user in users)
            {
                Console.WriteLine($"{user.Key}:");
                Console.WriteLine(string.Join(", ", user.Value.Select(x => x.Key + " => " + x.Value).ToArray()) + ".");
            }
        }

        public static string GetValue(string input)
        {
            string[] splitted = input.Split('=');
            string result = splitted[1];
            return result;
        }
    }
}
