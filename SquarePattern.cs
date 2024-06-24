using System;

namespace SquarePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to input an integer value for N
            Console.Write("Assign an int value to N: ");
            
            // Read the input from the user and convert it to an integer
            int N = int.Parse(Console.ReadLine());

            // Loop to print N rows
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
