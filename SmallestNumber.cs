using System;

namespace SmallestNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asking for user input
            Console.Write("Please input the first num: ");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Please input the second num: ");
            int num2 = Convert.ToInt16(Console.ReadLine());

            Console.Write("Please input the third num: ");
            int num3 = Convert.ToInt16(Console.ReadLine());

            int smallest;

            //Using nested if statements to find the smallest number
            if (num1 < num2)
            {
                if (num1 < num3)
                {
                    smallest = num1;
                }
                else
                {
                    smallest = num3;
                }
            }
            else{
                if (num2 < num3)
                {
                    smallest = num2;
                }
                else
                {
                    smallest = num3;
                }
            }

            //Printing the smallest number
            Console.WriteLine("The smallest number is: " + smallest);
        }
    }
}