using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());

            for (int letterOne = 0; letterOne < n; letterOne++)
                for (int letterTwo = 0; letterTwo < n; letterTwo++)
                    for (int letterThree = 0; letterThree < n; letterThree++)
                    {
                        char letter1 = (char)('a' + letterOne);
                        char letter2 = (char)('a' + letterTwo);
                        char letter3 = (char)('a' + letterThree);

                        Console.WriteLine("{0}{1}{2}", letter1, letter2, letter3);
                    }
        }
    }
}
