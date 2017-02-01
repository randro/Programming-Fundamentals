using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.Count_Real_Numbers
{
    public class Count
    {
        public static void Main(string[] args)
        {

            var numbers = Console.ReadLine().Split(' ');

            var counts = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                double parsedNum = double.Parse(number);
                if (counts.ContainsKey(parsedNum))
                {
                    counts[parsedNum]++;
                }
                else
                {
                    counts[parsedNum] = 1;
                }
            }

            foreach (var num in counts.Keys)
            {
                Console.WriteLine($"{num} -> {counts[num]}");
            }

        }
    }
}
