using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_03.EnduranceRally
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = Console.ReadLine().Split();
            var zones = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var checkpointIndexs = Console.ReadLine().Split().Select(int.Parse).ToArray();

            foreach (var name in names)
            {
                var zoneIndex = -1;
                var number = (double)name[0];
                for (int i = 0; i < zones.Length; i++)
                {
                    if (checkpointIndexs.Contains(i))
                        number = number + zones[i];
                    else
                        number = number - zones[i];
                    if (number <= 0)
                    {
                        zoneIndex = i;
                        break;
                    } 
                    
                }
                if(zoneIndex != -1)
                    Console.WriteLine($"{name} - reached {zoneIndex}");
                else
                    Console.WriteLine("{0} - fuel left {1:f2}", name, number);

                
            }


        }
    }
}
