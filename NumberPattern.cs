using System;

namespace NumberPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Assign an int value to N: ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 1; i <= N; i++)
            {
                for (int j = 0; j < N - i; j++)
                {
                    Console.Write(" ");
                }

                for (int j = 1; j <= i; j++)
                {
                    Console.Write(i);
                }
                
                Console.WriteLine();
            }
        }
    }
}
