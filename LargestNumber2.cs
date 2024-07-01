using System;

namespace LargestOfFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first integer: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter the third integer: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Enter the fourth integer: ");
            int d = int.Parse(Console.ReadLine());

            int largest = GetLargestOfFour(a, b, c, d);
            Console.WriteLine($"The largest number is: {largest}");
        }

        static int GetLargestOfFour(int num1, int num2, int num3, int num4)
        {
            int max1 = GetLargest(num1, num2);
            int max2 = GetLargest(num3, num4);
            return GetLargest(max1, max2);
        }

        static int GetLargest(int num1, int num2)
        {
            return num1 > num2 ? num1 : num2;
        }
    }
}