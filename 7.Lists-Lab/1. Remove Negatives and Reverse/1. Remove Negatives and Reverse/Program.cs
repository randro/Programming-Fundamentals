using System;
using System.Collections.Generic;
using System.Linq;


namespace _1.Remove_Negatives_and_Reverse
{
    public class RemovindandReversing
    {
        public static void Main(string[] args)
        {
            string values = Console.ReadLine();

            List<string> items = values.Split(' ').ToList();

            var nums = new List<int>();

            for (int i = 0; i < items.Count; i++)
            {
                nums.Add(int.Parse(items[i]));
            }


            nums.Reverse();
            nums.RemoveAll(x => x <= 0);

                foreach (var number in nums)

                {
                    Console.WriteLine(number);
                }
            
        }
    }
}
