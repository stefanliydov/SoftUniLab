using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiesByContinentsAndCountrys
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var currInput = Console.ReadLine().Split();
                var continent = currInput[0];
                var country = currInput[1];
                var city = currInput[2];

                if (!dict.ContainsKey(continent))
                { var dictList = new SortedDictionary<string, SortedSet<string>>();
                    dict[ continent] = dictList;
                }
                
                
                    if (!dict[continent].ContainsKey(country))
                    {
                        var cityList = new SortedSet<string> { city };
                        dict[continent][country] = cityList;
                    }
                    else
                    {
                        dict[continent][country].Add(city);
                    }
                
            }
            foreach (var item in dict)
            {
                Console.WriteLine(item.Key+":");
                foreach (var country in item.Value)
                {
                    Console.WriteLine($"  {country.Key} -> "+ string.Join(", ", country.Value));
                }
            }
        }
    }
}
