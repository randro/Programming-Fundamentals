using System;
using System.Collections.Generic;
using System.Linq;


namespace _4.Largest_3_Numbers
{
    public class PLargestNumber
    {
        public static void Main(string[] args)
        {
            string[] strings = Console.ReadLine()
                .Split(' ');

            List<int> nums = strings
                        .Select(int.Parse)
                        .ToList();
            var sortedNums = nums.OrderByDescending(x => x);

            var largest3Nums = sortedNums.Take(3);

            Console.WriteLine(string.Join(" ", largest3Nums));



        }
    }
}
