using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragonArmy
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var dragonTypeName = new Dictionary<string, SortedDictionary<string, decimal[]>>();
            for (int i = 0; i < n; i++)
            {
                var dragonsInput = Console.ReadLine().Split(' ').ToList();
                var color = dragonsInput[0];
                var name = dragonsInput[1];

                var dmg = 0m;
                if (dragonsInput[2] != "null")
                    dmg = decimal.Parse(dragonsInput[2]);
                else
                    dmg = 45;
                var health = 0m;
                if (dragonsInput[3] != "null")
                    health = decimal.Parse(dragonsInput[3]);
                else
                    health = 250;
                var armor = 0m;
                if (dragonsInput[4] != "null")
                    armor = decimal.Parse(dragonsInput[4]);
                else
                    armor = 10;
            


                if(!dragonTypeName.ContainsKey(color))
                dragonTypeName[color] = new SortedDictionary<string, decimal[]>();

                dragonTypeName[color][name] = new decimal[] { dmg, health, armor };
            }

            foreach (var dragonColor in dragonTypeName)
            {
                var color = dragonColor.Key;
                var nameStats = dragonColor.Value;

                var avarageDmg = nameStats.Values.Average(x => x[0]);
                var avarageHealth = nameStats.Values.Average(x => x[1]);
                var avarageArmor = nameStats.Values.Average(x => x[2]);
                Console.WriteLine("{0}::({1:f2}/{2:f2}/{3:f2})", dragonColor.Key, avarageDmg, avarageHealth, avarageArmor);
                foreach (var item in nameStats)
                {
                    Console.WriteLine($"-{item.Key} -> damage: {item.Value[0]}, health: {item.Value[1]}, armor: {item.Value[2]}" );
                }

            }


        }
    }
}
