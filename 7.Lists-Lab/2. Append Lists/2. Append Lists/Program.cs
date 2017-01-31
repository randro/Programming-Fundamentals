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

            List<string> items = n.Split('|', ' ').ToList();
            items.Remove();

            var nums = new List<int>();
            

            foreach (var item in items)

            {
                Console.WriteLine(item);
            }


        }

    }
}

