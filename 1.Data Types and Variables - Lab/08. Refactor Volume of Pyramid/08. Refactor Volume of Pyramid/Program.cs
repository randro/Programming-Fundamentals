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

            Console.Write("Length: ");
            var Length = double.Parse(Console.ReadLine());
            Console.Write("Width: ");
            var Height = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            var Volume = double.Parse(Console.ReadLine());
            Volume = (Length * Height * Volume) / 3;

            Console.WriteLine("Pyramid Volume: {0:F2}", Volume);



        }
    }
}
