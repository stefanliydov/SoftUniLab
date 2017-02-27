using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JapaneseRullete
{
    class Program
    {
        static void Main(string[] args)
        {
            var cylinder = Console.ReadLine().Split();
            var players = Console.ReadLine().Split().ToArray();
            var cylinderPosition = 0;
            bool deadPlayer = false;
            for (int i = 0; i < players.Length; i++)
            {
               var splitted= players[i].Split(',');
                var spins = int.Parse(splitted[0]);
                var direction = splitted[1].ToLower();

                switch (direction)
                {
                    case "right":
                        for (int p = 0; p < spins; p++)
                        {
                            if (cylinderPosition == 5)
                                cylinderPosition = 0;
                            else cylinderPosition++;
                        }
                        break;
                    case "left":
                        for (int p = 0; p < spins; p++)
                        {
                            if (cylinderPosition == 0)
                                cylinderPosition = 5;
                            else cylinderPosition--;
                        }
                        break;
                }
                if(cylinder[cylinderPosition] == "1")
                {
                    Console.WriteLine($"Game over! Player {i} is dead.");
                    deadPlayer = true;
                    break;
                }
                cylinderPosition++;
            }
            if (!deadPlayer)
                Console.WriteLine("Everybody got lucky!");
        }
    }
}
