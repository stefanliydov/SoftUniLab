using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilterBase
{
    class Program
    {
        static void Main(string[] args)
        {
            var ageDict = new Dictionary<string, int>();
            var salDict = new Dictionary<string, double>();
            var posDict = new Dictionary<string, string>();

            var command = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            while (command[0] != "filter" && command[1] != "base")
            {
                var name = command[0];
                var ageSalOrPos = command[1];
                int n;
                double d;
                
                bool isInt = int.TryParse(ageSalOrPos, out n);
                bool isDouble = double.TryParse(ageSalOrPos, out d);
                if(isInt == true)
                    ageDict[name] = n;  
                
                else if(isDouble == true)
                    salDict[name] = d;
                
                else
                    posDict[name] = ageSalOrPos;               

                command = Console.ReadLine().Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
            }
            var secondCommand = Console.ReadLine().ToLower();
            if(secondCommand == "age")
            {
                foreach (var item in ageDict)
                {
                    Console.WriteLine( "Name: "+item.Key);
                    Console.WriteLine("Age: "+ item.Value);
                    Console.WriteLine("====================" );
                }
            }
            else if(secondCommand == "salary")
            {
                foreach (var item in salDict)
                {
                    Console.WriteLine("Name: " + item.Key);
                    Console.WriteLine("Salary: {0:F2}", item.Value);
                    Console.WriteLine("====================");
                }
            }
            else if(secondCommand == "position")
            {
                foreach (var item in posDict)
                {
                    Console.WriteLine("Name: " + item.Key);
                    Console.WriteLine("Position: " + item.Value);
                    Console.WriteLine("====================");
                }
            }
        }
    }
}
