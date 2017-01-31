using System;
using System.Collections.Generic;
using System.Linq;


namespace _6.Reverse_Array_of_Strings
{
   public class ReverseArray
    {
      public  static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(' ').ToArray();
            List<string> reverseList = new List<string>(array);
            reverseList.Reverse();
            Console.WriteLine(string.Join(" ", reverseList));
        }
    }
}
