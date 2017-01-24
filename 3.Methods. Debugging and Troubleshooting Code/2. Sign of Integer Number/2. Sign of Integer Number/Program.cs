using System;

namespace _2.Sign_of_Integer_Number
{
   public class Program
    {
       public static void Main(string[] args)
        {
            PrintSign(int.Parse(Console.ReadLine()));

        }

        public static void PrintSign(int number)
        {
            if (number>0)
            {
                System.Console.WriteLine($"The number {number} is positive.");
            }
            else if (number<0)
            {
                System.Console.WriteLine($"The number {number} is negative.");
            }

            else
            {
                System.Console.WriteLine($"The number {number} is zero.");
            }
        }
    }
}
