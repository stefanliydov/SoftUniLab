using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingCrisis
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var list = new List<int>();
            for (int i = 0; i < n; i++)
            {
                var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
                if (list.Count == 0)
                {
                    for (int p = 0; p < numbers.Count; p++)
                    {
                        if (p == 0)
                            list.Add(numbers[p]);
                        else if (numbers[p] >= numbers[p - 1])
                            list.Add(numbers[p]);
                        else
                            break;
                    }
                }

                else
                {
                    bool check = false;
                    for (int p = 1; p < numbers.Count; p++)
                    {
                        if (numbers[p] < numbers[p - 1])
                        {
                            check = true;
                        }
                        if (check == true)
                        {
                            var countSafe = numbers.Count;
                            for (int k = p; k < countSafe; k++)
                            {
                                numbers.RemoveAt(p);
                            }
                            break;
                        }
                     
                    }
                    var pSafe = 0;
                    var numbersSafe = 0;
                    for (int p = 0; p < list.Count; p++)
                    {
                        if (list[p] <= numbers[0])
                        {
                            pSafe = p+1;
                            numbersSafe = list[p];
                        }
                        else
                            break;
                    }
                    if (check == false)
                    {
                        for (int p = numbers.Count-1; p >= 0; p--)
                        {
                            list.Insert(pSafe, numbers[p]);
                        }
                    }
                    else
                    {
                        var countSafe = list.Count;
                        for (int p = pSafe; p < countSafe; p++)
                        {
                            list.RemoveAt(pSafe);
                        }
                        for (int p = numbers.Count-1; p >= 0; p--)
                        {
                            list.Add(numbers[p]);
                        }
                    }
                }      
            }
            list.Sort();
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
