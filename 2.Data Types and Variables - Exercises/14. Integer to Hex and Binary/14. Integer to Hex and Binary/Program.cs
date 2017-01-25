using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Integer_to_Hex_and_Binary
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            string  b = Convert.ToString(a,16);
            var c = Convert.ToString(a, 2);
           
                
            Console.WriteLine(b);
            Console.WriteLine(c);
            

        }
    }
}
