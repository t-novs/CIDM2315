using System;

namespace PrimeCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input an integer: ");
            int N = int.Parse(Console.ReadLine());
            bool isPrime = true;

            if (N <= 1)
            {
                isPrime = false;
            }
            else{
                for (int i = 2; i <= Math.Sqrt(N); i++)
                {
                    if (N % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine("N is prime");
            }
            else
            {
                Console.WriteLine("N is non-prime");
            }
        }
    }
}
