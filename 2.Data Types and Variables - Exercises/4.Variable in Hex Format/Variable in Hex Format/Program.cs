﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int b = Convert.ToInt32(a, 16);

            Console.WriteLine(b);

        }
    }
}
