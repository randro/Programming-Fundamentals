﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker___Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <=n; i++)
            {
                bool a = true;
                for (int delio = 2; delio <= Math.Sqrt(i); delio++)
                {
                    if (i % delio == 0)
                    {
                        a = false;
                        break;
                    }
                }
                Console.WriteLine($"{i} -> {a}");
            }

        }
    }
}
