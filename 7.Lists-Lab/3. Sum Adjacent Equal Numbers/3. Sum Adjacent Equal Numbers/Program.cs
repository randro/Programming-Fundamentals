using System;
using System.Collections.Generic;
using System.Linq;


namespace _3.Sum_Adjacent_Equal_Numbers
{
   public class Sum
    {
       public  static void Main(string[] args)
        {
            string number = Console.ReadLine();

            List<string> items = number.Split(' ').ToList();

            List<int> nums = new List<int>();

            for (int i = 0; i < items.Count; i++)
            {
                nums.Add(int.Parse(items[i]));
            }

            for (int i = 0; i < nums.Count; i++)
            {

            }
        }
    }
}
