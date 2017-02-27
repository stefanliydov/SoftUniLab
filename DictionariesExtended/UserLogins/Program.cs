using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserLogins
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, string>();
            var command = Console.ReadLine().Split(new char[] { ' ',
                '-',
                '>'},
                StringSplitOptions.RemoveEmptyEntries);

            while (command[0] != "login")
            {
                var name = command[0];
                var pass = command[1];

                dict[name] = pass;
                command = Console.ReadLine().Split(new char[] { ' ',
                '-',
                '>'},
                StringSplitOptions.RemoveEmptyEntries);
            }
            command = Console.ReadLine().Split(new char[] { ' ',
                '-',
                '>'},
                StringSplitOptions.RemoveEmptyEntries);
            var count = 0;
            while ( command[0]!= "end")
            {
                var name = command[0];
                var pass = command[1];
                
                if (!dict.ContainsKey(name))
                {
                    Console.WriteLine(name +": login failed");
                    count++;
                }
                else if(dict[name] != pass)
                {
                    Console.WriteLine(name + ": login failed");
                    count++;
                }
                else
                    Console.WriteLine(name +": logged in successfully");


                command = Console.ReadLine().Split(new char[] { ' ',
                '-',
                '>'},
                StringSplitOptions.RemoveEmptyEntries);
            }
            Console.WriteLine("unsuccessful login attempts: "+count);
        }
    }
}
