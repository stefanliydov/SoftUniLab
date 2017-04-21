using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebSites
{
    class Website
    {
       public string Host { get; set; }

       public string Domain { get; set; }

        public List<string> Queries { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Website> Websites = new List<Website>();

            var inputLine = Console.ReadLine();

            while(inputLine != "end")
            {
                var splited = inputLine.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);

                var host = splited[0];
                var domain = splited[1];
                var queries = new List<string>();
                if(splited.Length > 2 )
                  queries = splited[2].Split(',').ToList();

                var newWebsite = new Website()
                {
                    Host = host,
                    Domain = domain,
                    Queries = queries
                };
                Websites.Add(newWebsite);
                inputLine = Console.ReadLine();
            }
            foreach (var website in Websites)
            {
                if(website.Queries.Count == 0)
                    Console.WriteLine($"https://www.{website.Host}.{website.Domain}");
                else
                {
                    Console.Write($"https://www.{website.Host}.{website.Domain}/query?=[{website.Queries[0]}]");
                    for (int i = 1; i < website.Queries.Count; i++)      
                        Console.Write($"&[{website.Queries[i]}]");                   
                }
                Console.WriteLine();         
            }
        }
    }
}
