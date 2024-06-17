using System;

namespace GradetoGPA
{
    class Program
    {
        //Grade to GPA using switch statement
        static void Main(string[] args)
        {
            Console.Write("Enter Grade (A, B, C, D, F): ");
            string input = Console.ReadLine().ToUpper();
            
            switch (input)
            {
                case "A":
                    Console.WriteLine("GPA Points: 4");
                    break;
                
                case "B":
                    Console.WriteLine("GPA Points: 3");
                    break;

                case "C":
                    Console.WriteLine("GPA Points: 2");
                    break;
                
                case "D":
                    Console.WriteLine("GPA Points: 1");
                    break;

                case "F":
                    Console.WriteLine("GPA Points: 0");
                    break;

                default:
                    Console.WriteLine("Wrong Letter Grade!");
                    break;
            }
        }
    }
}

