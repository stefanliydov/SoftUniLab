using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endCommand = false;
            var contactList = new SortedDictionary<string, string>();
            

            while(endCommand == false)
            {
                var command = Console.ReadLine().Split(' ').ToList();

                if (command[0] == "END")
                    endCommand = true;

                else if (command[0] =="A")
                {
                    contactList[command[1]] = command[2];
                }
                else if (command[0] == "S")
                {
                    if (contactList.ContainsKey(command[1]))
                    {
                        var value = contactList[command[1]];
                        Console.WriteLine($"{command[1]} -> {value}");
                        value = String.Empty;
                    }
                    
                    else
                        Console.WriteLine($"Contact {command[1]} does not exist.");
                }
                else if (command[0] == "ListAll")
                {
                   
                    foreach (var contact in contactList)
                    {
                        Console.WriteLine($"{contact.Key} -> {contact.Value}");
                    }
                }
                

            }
        }
    }
}
