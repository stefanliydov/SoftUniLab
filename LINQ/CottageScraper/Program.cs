using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CottageScraper
{
    class Program
    {
        static void Main(string[] args)
        {
            var treeDict = new Dictionary<string, List<int>>();

            var currInput = Console.ReadLine();
            while(currInput != "chop chop")
            {
                string[] splitter = currInput.Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                var treeType = splitter[0];
                int quantity = int.Parse(splitter[1]);

                if (!treeDict.ContainsKey(treeType))
                    treeDict[treeType] = new List<int>();
                treeDict[treeType].Add(quantity);
                currInput = Console.ReadLine();
            }
            string chosenTree = Console.ReadLine();
            int quantityChosenTree = int.Parse(Console.ReadLine());
            var sumOfAllTrees = 0.0;
            var count = 0;
            var usedLogs = 0;
            var unusedLogs = 0;

            foreach (var item in treeDict)
            {
            
                foreach (var quant in item.Value)
                {
                    sumOfAllTrees += quant;
                    count++;

                    if (item.Key == chosenTree && quant >= quantityChosenTree)
                        usedLogs += quant;

                    else
                        unusedLogs += quant;      
                } 
            }
            double pricePerMeter =Math.Round( sumOfAllTrees / count, 2);
            double usedLogsPrice = usedLogs * pricePerMeter;
            double unusedLogsPrice = unusedLogs * pricePerMeter * 0.25;
            double usedAndUnusedPrice = usedLogsPrice + unusedLogsPrice;

            Console.WriteLine("Price per meter: ${0:f2}",pricePerMeter);
            Console.WriteLine("Used logs price: ${0:f2}",usedLogsPrice);
            Console.WriteLine("Unused logs price: ${0:f2}",unusedLogsPrice);
            Console.WriteLine("CottageScraper subtotal: ${0:f2}",usedAndUnusedPrice);

        }
    }
}
