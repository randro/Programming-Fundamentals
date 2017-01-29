using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var power =double.Parse(Console.ReadLine());
            Console.WriteLine(RaiseToPower(number, power));
        }


        static double RaiseToPower(double number, double power)
            {

            double result = Math.Pow(number, power);

            return result;
        
            }

       
    }

}
