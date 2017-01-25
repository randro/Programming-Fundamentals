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
            int n = int.Parse(Console.ReadLine());
            for (int num = 1; num <= n; num++)
            {
                int sumOfnumbers = 0;
                int digits = num;
                while (digits > 0)
                {
                    sumOfnumbers += digits % 10;
                    digits = digits / 10;
                }
                bool special = (sumOfnumbers == 5) || (sumOfnumbers == 7) || (sumOfnumbers == 11);
                Console.WriteLine("{0} -> {1}", num, special);
            }

        }
    }
}
