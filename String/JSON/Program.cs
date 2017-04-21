using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSON
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            List<string> students = new List<string>();
            while(text != "stringify")
            {
                var splited = text.Split(':');
                var secSplit = splited[1].Split(new[] { '-','>' }, StringSplitOptions.RemoveEmptyEntries);
                var name = splited[0].Trim();
                var age = secSplit[0].Trim();
                var grades = secSplit[1].Trim();
                var readyString = string.Empty;
                readyString ="{name:"+ "\""+ name+"\","+ "age:"+ age+ ","+ "grades:"+ "["+ grades+ "]}";
                students.Add(readyString);
                text = Console.ReadLine();
            }
            Console.WriteLine("["+string.Join(",",students)+"]");
        }
    }
}
