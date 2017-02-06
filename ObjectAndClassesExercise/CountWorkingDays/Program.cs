using System;
using System.Collections.Generic;
using System.Globalization;
namespace CountWorkingDays
{
    public class Program
    {
        private static int i;

        public  static void Main()
        {

            var firstDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            var secondDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            List<DateTime> holidays = new List<DateTime> {
                DateTime.ParseExact("01-01-2016","dd-MM-yyyy",CultureInfo.InvariantCulture ),
                DateTime.ParseExact("03-03-2016","dd-MM-yyyy",CultureInfo.InvariantCulture ),
                DateTime.ParseExact("01-05-2016","dd-MM-yyyy",CultureInfo.InvariantCulture ),
                DateTime.ParseExact("06-05-2016","dd-MM-yyyy",CultureInfo.InvariantCulture ),
                DateTime.ParseExact("24-05-2016","dd-MM-yyyy",CultureInfo.InvariantCulture ),
                DateTime.ParseExact("06-09-2016","dd-MM-yyyy",CultureInfo.InvariantCulture ),
                DateTime.ParseExact("22-09-2016","dd-MM-yyyy",CultureInfo.InvariantCulture ),
                DateTime.ParseExact("01-11-2016","dd-MM-yyyy",CultureInfo.InvariantCulture ),
                DateTime.ParseExact("24-12-2016","dd-MM-yyyy",CultureInfo.InvariantCulture ),
                DateTime.ParseExact("25-12-2016","dd-MM-yyyy",CultureInfo.InvariantCulture ),
                DateTime.ParseExact("26-12-2016","dd-MM-yyyy",CultureInfo.InvariantCulture ),
            };
            int workingDays = 0;
            for (DateTime currentDate = firstDate;  currentDate <= secondDate; currentDate= currentDate.AddDays(1))
            {
                DateTime holiday = new DateTime(2016, currentDate.Month, currentDate.Day);
                if (currentDate.DayOfWeek != DayOfWeek.Saturday
                    && currentDate.DayOfWeek != DayOfWeek.Sunday
                   && !holidays.Contains(holiday))
                    workingDays++;
            }
            Console.WriteLine(workingDays);
        }
    }
}
