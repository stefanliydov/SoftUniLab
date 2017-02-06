using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PopulationCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var countryCityPopulationDic = new Dictionary<string, Dictionary<string, int>>();
            while( input != "report")
            {
                var splittedData = input.Split('|');

                var city = splittedData[0];
                var country = splittedData[1];
                var populationNumber = int.Parse(splittedData[2]);

                if (!countryCityPopulationDic.ContainsKey(country))
                    countryCityPopulationDic[country] = new Dictionary<string, int>();
                if (!countryCityPopulationDic[country].ContainsKey(city))
                    countryCityPopulationDic[country][city] = populationNumber;
                else
                    countryCityPopulationDic[country][city] += populationNumber;


                input = Console.ReadLine();
            }
          
            

            foreach (var item in countryCityPopulationDic.OrderByDescending(x => x.Key))
            {
                var totalCountryPopulation = item.Value;
                
                Console.WriteLine(item.Key + " (total population: " + totalCountryPopulation.Values.Sum().ToString() + ")");
                Console.WriteLine("=>"+  string.Join(" =>",item.Value.Select(x=> x.Key+": "+x.Value).OrderByDescending(x=>x)));
                
            }
        }
    }
}
