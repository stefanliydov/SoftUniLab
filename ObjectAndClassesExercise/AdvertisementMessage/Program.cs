using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[] phrases = new string[] {"Excellent product.", "Such a great product.", "I always use that product.",
            "Best product of its category.", "Exceptional product.", "I can’t live without this product."};

            string[] events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
              "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};

            string[] author = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random phraseIndex = new Random();
            Random eventsIndex = new Random();
            Random authorIndex = new Random();
            Random citiesIndex = new Random();

            for (int i = 0; i < n; i++)
            {
              int p =  phraseIndex.Next(0, 6);
              int e =  eventsIndex.Next(0, 6);
              int a =  authorIndex.Next(0, 7);
              int c =  citiesIndex.Next(0, 4);
                Console.WriteLine($"{phrases[p]} {events[e]} {author[a]} - {cities[c]}" );
            }
        }
    }
}
