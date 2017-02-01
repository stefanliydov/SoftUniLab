using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsersLog
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var userIpPair = new SortedDictionary<string, Dictionary<string, int>>();
            

            while(input != "end")
            {
                var inputSplit = input.Split(' ');
                
                var ipAdress = inputSplit[0].Remove(0,3);
                
                var userName     = inputSplit[2].Remove(0,5);


                if (!userIpPair.ContainsKey(userName))
                    userIpPair[userName] = new Dictionary<string, int>();
                if (!userIpPair[userName].ContainsKey(ipAdress))
                    userIpPair[userName][ipAdress] = 1;
                else
                    userIpPair[userName][ipAdress]++;


                input = Console.ReadLine();
            }

           
                foreach (var item in userIpPair)
                {
                    Console.WriteLine(item.Key+": ");
                Console.WriteLine(string.Join(", ",item.Value.Select(x => x.Key +" => "+ x.Value).ToArray())+".");

                }
            

        }
    }
}
