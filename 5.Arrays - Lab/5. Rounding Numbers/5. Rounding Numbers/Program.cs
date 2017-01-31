using System;

namespace _5.Rounding_Numbers
{
    public class Rounding_Numbers_Away_from_Zero
    {
       public static void Main(string[] args)
        {
            double numbers = double.Parse(Console.ReadLine());

            var arr = new int[]

            int[] roundedNums = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                roundedNums[i] = (int)Math.Round((double)numbers[i], MidpointRounding.AwayFromZero);
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"{numbers[i]} -> {roundedNums[i]}");
            }






        }
    }
}
    