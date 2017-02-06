using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace DayOfWeek
{
   public class Program
    {
        public static void Main(string[] args)
        {
            var inputDate = Console.ReadLine();

            var date = DateTime.ParseExact(inputDate, "d-M-yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine(date.DayOfWeek);
            
        }
    }
}
