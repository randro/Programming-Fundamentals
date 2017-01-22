using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Centuries_to_Nanoseconds
{
    class Program
    {
        static void Main(string[] args)
        {
            int a  = int.Parse(Console.ReadLine());
            int years = a * 100;
            int days = (int)(365.2422 * years);
            int hours =(int)( 24 * days);
            long minutes =( 60 * hours);
            long seconds = 60 * minutes;
            ulong milliseconds = (ulong)(1000 * seconds);
            ulong microseconds = 1000 * milliseconds;
            ulong nanoseconds = (100 * microseconds);






                Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds",a,years,days,hours,minutes,seconds,milliseconds,microseconds,nanoseconds);


        }
    }
}
