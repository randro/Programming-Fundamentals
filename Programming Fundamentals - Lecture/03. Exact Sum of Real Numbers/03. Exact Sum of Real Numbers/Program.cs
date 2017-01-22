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
            var n = decimal.Parse(Console.ReadLine());
            var sum = 0M;

            for (int i = 0; i < n; i++)
            {
                var n1 = decimal.Parse(Console.ReadLine());

                sum = sum + n1;


            }

            Console.WriteLine(sum);

        }
    }
}
