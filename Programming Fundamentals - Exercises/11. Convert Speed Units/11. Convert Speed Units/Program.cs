using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            var distance = float.Parse(Console.ReadLine());
            var hours = float.Parse(Console.ReadLine());
            var minutes = float.Parse(Console.ReadLine());
            var seconds = float.Parse(Console.ReadLine());
            float time = hours * 3600 + minutes * 60 + seconds;

            float mettersPerSecond = distance / time;
            float kilometersPerHour = mettersPerSecond * 3.6F;
            float milesPerHour =(mettersPerSecond * 2.2369F);
            Console.WriteLine(mettersPerSecond);
            Console.WriteLine(kilometersPerHour);
            Console.WriteLine(milesPerHour);
            
            




        }
    }
}
