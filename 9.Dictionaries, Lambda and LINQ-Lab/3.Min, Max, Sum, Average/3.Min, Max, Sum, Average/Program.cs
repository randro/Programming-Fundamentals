using System;
using System.Collections.Generic;
using System.Linq;


namespace _3.Min__Max__Sum__Average
{
    public class MinMaxSumAverage
    {
        public static void Main(string[] args)
        {
           
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];

            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Sum = {nums.Sum()}");

            Console.WriteLine($"Min = {nums.Min()}");

            Console.WriteLine($"Max = {nums.Max()}");

            Console.WriteLine($"Average = {nums.Average()}");

        }
    }
}
