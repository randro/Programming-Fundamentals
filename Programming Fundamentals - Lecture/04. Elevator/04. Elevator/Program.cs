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
            var person = int.Parse(Console.ReadLine());
            var capacity = int.Parse(Console.ReadLine());
            var courses = (int)Math.Ceiling((double)person / capacity);

            Console.WriteLine(courses);


        }
    }
}
