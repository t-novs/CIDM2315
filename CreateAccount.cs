using System;

namespace CreateAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            createAccount();
        }

        static bool checkAge(int birthYear)
        {
            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;
            return age >= 18;
        }

        static void createAccount()
        {
            Console.Write("Enter Your Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Your Password: ");
            string password = Console.ReadLine();

            Console.Write("Enter Your Password Again: ");
            string passwordAgain = Console.ReadLine();

            Console.Write("Enter Your Birthyear: ");
            int birthYear = int.Parse(Console.ReadLine());

            if (checkAge(birthYear))
            {
                if (password == passwordAgain)
                {
                    Console.WriteLine("Account is created successfully");
                }
                else
                {
                    Console.WriteLine("Wrong Password");
                }
            }
            else
            {
                Console.WriteLine("Could not create an account");
            }
        }
    }
}