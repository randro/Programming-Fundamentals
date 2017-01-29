using System;


namespace _2.Reverse_an_Array_of_Integers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            var numbers = new int[n];

            for (int i = 0; i <numbers.Length; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            for (int i = numbers.Length-1; i >=0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
