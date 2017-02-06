using System;
using System.Collections.Generic;
using System.Linq;
using System.Globalization;

namespace _1.Day_of_Week
{
    public class DayOfWeek
    {
       public static void Main(string[] args)
        {
            string dateAsText = Console.ReadLine();

            DateTime date = DateTime.ParseExact(
              
                dateAsText, "d-M-yyyy",
             
                CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);

        }
    }
}
