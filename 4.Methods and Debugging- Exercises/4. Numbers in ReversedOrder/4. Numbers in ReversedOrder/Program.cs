using System;
using System.Linq;


namespace _4.Numbers_in_ReversedOrder
{
    public class ReversedOrderNumber
    {
        public static void Main(string[] args)
        {
            string number = Console.ReadLine();
            number = new string(number.ToCharArray().Reverse().ToArray());
            Console.WriteLine(number);
        }



        }
}
