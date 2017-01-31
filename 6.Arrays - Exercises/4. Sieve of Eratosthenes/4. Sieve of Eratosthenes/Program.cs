﻿using System;
using System.Collections.Generic;
using System.Linq;


namespace _4.Sieve_of_Eratosthenes
{
    public class Eratosthenes
    {
        public static void Main(string[] args)
        {
            long sum = 0;
            long n = 2000000;
            bool[] e = new bool[n];
            for (int i = 2; i < n; i++)
            {
                e[i] = true;
            }
            
            for (int j = 2; j < n; j++)
            {
                if (e[j])
               
                    for (long p = 2; (p * j) < n; p++)
                    {
                        e[p * j] = false;
                    }
                }
            }
        }
    }

