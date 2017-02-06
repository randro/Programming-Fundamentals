using System;
using System.Collections.Generic;
using System.Linq;


namespace _2.Append_Lists
{
    public class Append
    {
        public static void Main(string[] args)
        {
            string n = Console.ReadLine();

            List<string> items = n.Split('|').ToList();

            for (int i = 0; i <3; i++)
            {
                items[i].Split(' ');
            }

            foreach (var item in items)
            {
                Console.WriteLine(item);
            }

        }

    }
}

