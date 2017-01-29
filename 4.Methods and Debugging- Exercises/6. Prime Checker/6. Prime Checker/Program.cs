using System;


namespace _6.Prime_Checker
{
  public  class Checker
    {
       public  static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            bool isPrime;
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                    break;
                }
                else
                {
                    isPrime =true;
                }
            }

            
           
        }
    }
}
