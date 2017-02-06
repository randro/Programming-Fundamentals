using System;
using System.Collections.Generic;
using System.Linq;



namespace _4.Distance_Between_Points
{
    public class Points
    {
        public static void Main(string[] args)
        {
            var firstPointParts = Console.ReadLine()
                .Split(' ');

            var secondPointParts = Console.ReadLine()
                .Split(' ');

            var firstPoint = new Point()
            {
                X = double.Parse(firstPointParts[0]),
                Y = double.Parse(firstPointParts[1])
            };

            var secondPoint = new Point
            {
                X = double.Parse(secondPointParts[0]),
                Y = double.Parse(secondPointParts[1])
            };

            var result = CalculateDistance(firstPoint, secondPoint);

            Console.WriteLine("{0:0.0.0.0.0}",result);

        }

        public static double CalculateDistance(Point firstPoint , Point secondPoint)
        {
            var diffx = firstPoint.X - secondPoint.X;
            var diffy = firstPoint.Y - secondPoint.Y;

            var powX = Math.Pow(diffx, 2);
            var powY = Math.Pow(diffy, 2);

            var c = Math.Abs(powY + powX);

            var sqrt = Math.Sqrt(c);

            return sqrt;
 }

        


    }
}
