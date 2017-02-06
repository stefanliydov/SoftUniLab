using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseMakesPerfection
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            for (char i = (char)'a'; i < (char)(n+97); i++)
            {
                for (char j = (char)'a'; j <(char)(n + 97); j++)
                {
                    for (char p = (char)'a'; p < (char)(n + 97); p++)
                    {
                        Console.WriteLine("{0}{1}{2}",(char)i , (char)j ,(char)p);
                    }
                }
            }
            
        }
    }
}
