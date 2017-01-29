using System;


namespace _8.MultiplyEvvensByOdds
{
    public class Program    
    {
        public static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetMultipleOfEvensAndOdds(number));
        }
        public static int GetMultipleOfEvensAndOdds(int number)
        {
            int sumOfEvvens = GetSumOfDiggits(number);
            int sumOfOdds = GetSumOfDiggits(number);
            return Math.Abs(sumOfEvvens * sumOfEvvens);
        }

        public static int GetSumOfDiggits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                if (lastDigit% 2 !=0 )
                {
                    sum += lastDigit;
                }

                 number /= 10;

            }

            return sum;
        }
    }
}
