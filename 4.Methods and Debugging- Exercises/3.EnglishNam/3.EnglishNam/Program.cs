using System;

namespace _3.EnglishNam
{
    public class English_Name
    {
        public static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            NameOfLastDigit(number);

        }

        public static int NameOfLastDigit(int number)
        {
            var lastDigit = 0;

            for (int i = 0; i <number; i++)
            {
                lastDigit = i % 10+1;
            }

            switch (lastDigit)
            {

                case 0:
                    Console.WriteLine("zero");
                    break;
                case 1:
                    Console.WriteLine("one");
                        break;
                case 2:
                    Console.WriteLine("two");
                    break;

                case 3:
                    Console.WriteLine("three");
                    break;

                case 4:
                    Console.WriteLine("four");
                    break;

                case 5:
                    Console.WriteLine("five");
                    break;

                case 6:
                    Console.WriteLine("six");
                    break;

                case 7:
                    Console.WriteLine("seven");
                    break;

                case 8:
                    Console.WriteLine("eight");
                    break;

                case 9:
                    Console.WriteLine("nine");
                    break;

               
                default:
                    break;
            }

            return lastDigit;


        }
    }
}
