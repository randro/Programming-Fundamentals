using System;


namespace _2.MaxMethod
{
   public class Max
    {
        public static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

            if (c>GetMax(a,b))
            {
                Console.WriteLine(c);
            }
            else
            {
                Console.WriteLine(GetMax(a,b));
            }
        }

        public static int GetMax(int a, int b)
        {
            if (a>b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
