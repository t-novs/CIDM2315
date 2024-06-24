using System;

namespace SquarePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Assign an int value to N: ");
            
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {

                for (int j = 0; j < N; j++)
                {
                    Console.Write("#");
                }

                Console.WriteLine();
            }
        }
    }
}
