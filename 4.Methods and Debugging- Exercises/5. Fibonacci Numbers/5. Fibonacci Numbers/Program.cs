using System;


namespace _5.Fibonacci_Numbers
{
    public class Fibonacci
    {
        public static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonaciNumber(n));

        }

        public static int FibonaciNumber(int n)
        {
            int a = 0;
            int b = 1;
        
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;

        }
    }
}
