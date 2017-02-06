using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesReport
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var salesArray = new string[n];
            var salesDict = new SortedDictionary<string, double>();
            for (int i = 0; i < n; i++)
            {

                var input = Console.ReadLine();
                

                var splited = input.Split(' ');
                var sales = new Sale()
                { town = splited[0], product = splited[1], price = double.Parse(splited[2]), quantity =double.Parse(splited[3]) };

                if(!salesDict.ContainsKey(splited[0]))
                    salesDict[splited[0]]= (sales.price * sales.quantity);
                else
                salesDict[splited[0]] += (sales.price* sales.quantity);
            }
            foreach (var product in salesDict)
            {
                Console.WriteLine($"{product.Key} ->" +" {0:f2}", product.Value);
            }


        }
    }
    class Sale
    {
        public string town { set; get; }

        public string product { set; get; }

        public double price { get; set; }

        public double quantity { get; set; }


    }
}
