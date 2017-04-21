using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace CapitalizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = Console.ReadLine();
            var list = new List<string>();
            while(text != "end")
            {
                var splited = text.Split();
                var newString = string.Empty;
                foreach (var item in splited)
                {
                    string currString = item.ToString().Trim('.', ',', '!', '?', ' ');
                    var sb = new StringBuilder();
                    sb.Append(currString);
                    try
                    {
                        sb[0] = char.Parse(sb[0].ToString().ToUpper());
                    }
                    catch {  }
                    
                  
                  
                    for (int i = 1; i < sb.Length; i++)
                    {

                        sb[i] = char.Parse(sb[i].ToString().ToLower());
                       
                    }
                   
                    if(sb.ToString().Length>0)
                        newString =string.Concat(newString, sb.ToString(),", ");
                    
                }
                newString = newString.Trim('.', ',', '!', '?', ' ', '-','*','&','^','%','$','#','#','@');
                list.Add(newString);
                text = Console.ReadLine();
                
            }
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
