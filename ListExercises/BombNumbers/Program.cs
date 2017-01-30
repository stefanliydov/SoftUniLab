using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var power = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var bombPos = 0;

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == power[0])
                {
                    bombPos = i;
                    for (int r = 0; r < power[1]; r++)
                    {
                        if (bombPos + 1 == list.Count)
                            break;
                        list.RemoveAt(bombPos + 1);

                    }
                    for (int p = 0; p < power[1]; p++)
                    {
                        if (bombPos - 1 < 0)
                            break;
                        list.RemoveAt(bombPos - 1);
                        bombPos--;
                    }
                    if (bombPos - power[1] < 0)
                        list.RemoveAt(0);
                    else
                        list.RemoveAt(bombPos - power[1]);
                    i = -1;
                }
                
            }

            var sum = 0;
            for (int i = 0; i < list.Count; i++)
            {
                sum += list[i];
            }
            Console.WriteLine(sum);
        }
    }
}
