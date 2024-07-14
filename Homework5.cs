using System;

namespace Homework5
{
    class Customer
    {
        private int cusID;
        public string cusName { get; set; }
        public int cusAge { get; set; }

        public Customer(int cusID, string cusName, int cusAge)
        {
            this.cusID = cusID;
            this.cusName = cusName;
            this.cusAge = cusAge;
        }

        public void ChangeID(int newID)
        {
            this.cusID = newID;
        }

        public void PrintCusInfo()
        {
            Console.WriteLine($"ID: {cusID}, Name: {cusName}, Age: {cusAge}");
        }

        public void CompareAge(Customer objCustomer)
        {
            if(this.cusAge > objCustomer.cusAge)
            {
                Console.WriteLine($"{this.cusName} is older.");
            }
            else if (this.cusAge < objCustomer.cusAge)
            {
                Console.WriteLine($"{objCustomer.cusName} is older.");
            }
            else
            {
                Console.WriteLine("Both customers are of the same age.")
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer(110, "Alice", 28);
            Customer customer2 = new Customer(111, "Bob", 30);

            customer1.PrintCusInfo();
            customer2.PrintCusInfo();

            customer1.ChangeID(220);
            customer2.ChangeID(221);

            customer1.PrintCusInfo();
            customer2.PrintCusInfo();

            customer1.CompareAge(customer2);
        }
    }
}