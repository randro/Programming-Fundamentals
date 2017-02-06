using System;
using System.Collections.Generic;
using System.Linq;

namespace _2.Randomize_Words
{
    public class Words
    {
      public  static void Main(string[] args)
        {
            var words = Console.ReadLine()
             .Split(' ');

            var random = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                var currentWord = words[i];
                var randomIndex = random.Next(0, words.Length);

                var tempWord = words[randomIndex];
                words[i] = tempWord;
                words[randomIndex] = currentWord;

                
            }

            foreach (var item in words)
            {
                Console.WriteLine(item);
            }
             
        }
    }
}
