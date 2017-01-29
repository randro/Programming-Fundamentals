using System;


namespace _1.HelloName
{
    public class Hello_Name
    {
        public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            PrintName(name);
        }

        public static void PrintName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
    }
}
