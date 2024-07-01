using System;

namespace LargestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first integer: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int b = int.Parse(Console.ReadLine());

            int largest = GetLargest(a, b);
            Console.WriteLine($"The largest number is: {largest}");
        }

        static int GetLargest(int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }
    }
}
