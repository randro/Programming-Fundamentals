﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace _3.Last_K_Numbers_Sums_Sequence
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            var array = new long[n];
            array[0] = 1;

            for (int current = 1; current < n; current++)
            {
                var start = Math.Max(0, current - k);
                var end = current - 1;
                long sum = 0;
                for (int i = start; i < n; i++)
                {
                    sum += array[i];
                }
                array[current] = sum;
            }
            Console.WriteLine(string.Join(" ", array));



        }
    }
}
