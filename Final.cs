using System;
using System.Collections.Generic;

namespace HotelManagementApp
{
    class Program
    {
        private static string predefinedUsername = "alice";
        private static string predefinedPassword = "alice123";

        // Room data
        private static Dictionary<int, int> rooms = new Dictionary<int, int>
        {
            { 101, 2 }, { 102, 2 }, { 103, 2 }, { 104, 2 },
            { 105, 2 }, { 106, 3 }, { 107, 3 }, { 108, 3 },
            { 109, 3 }, { 110, 4 }
        };

        private static Dictionary<int, string> reservedRooms = new Dictionary<int, string>();

        static void Main(string[] args)
        {
            Console.WriteLine("-----CIDM2315 Final Project: Carl Zhang-----");
            Console.WriteLine("-----Welcome to Buff Hotel------");

            Console.Write("--> Please input username: ");
            string username = Console.ReadLine();
            Console.Write("--> Please input password: ");
            string password = Console.ReadLine();

            if (username == predefinedUsername && password == predefinedPassword)
            {
                Console.WriteLine("--> Login Successfully.");
                ShowMenu();
            }
            else
            {
                Console.WriteLine("--> Wrong Username/Password");
                return;
            }
        }

        static void ShowMenu()
        {
            while (true)
            {
                Console.WriteLine("** Hello User: alice **");
                Console.WriteLine("********************");
                Console.WriteLine("--> Please select:");
                Console.WriteLine("1. Show Available Room");
                Console.WriteLine("2. Check-In");
                Console.WriteLine("3. Show Reserved Room");
                Console.WriteLine("4. Check-Out");
                Console.WriteLine("5. Log Out");
                Console.WriteLine("********************");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        ShowAvailableRooms();
                        break;
                    case "2":
                        CheckIn();
                        break;
                    case "3":
                        ShowReservedRooms();
                        break;
                    case "4":
                        CheckOut();
                        break;
                    case "5":
                        Console.WriteLine("--> Log out system");
                        return;
                    default:
                        Console.WriteLine("--> Invalid choice, please try again.");
                        break;
                }
            }
        }

        static void ShowAvailableRooms()
        {
            Console.WriteLine("********************");
            Console.WriteLine("--> Available Rooms:");
            foreach (var room in rooms)
            {
                if (!reservedRooms.ContainsKey(room.Key))
                {
                    Console.WriteLine($"+ Room number: {room.Key}; Capacity: {room.Value}");
                }
            }
            Console.WriteLine("********************");
        }

        static void CheckIn()
        {
            Console.Write("--> Input Number of People: ");
            int peopleCount = int.Parse(Console.ReadLine());
            List<int> availableRooms = new List<int>();

            foreach (var room in rooms)
            {
                if (room.Value >= peopleCount && !reservedRooms.ContainsKey(room.Key))
                {
                    availableRooms.Add(room.Key);
                }
            }

            if (availableRooms.Count > 0)
            {
                Console.WriteLine("--> Available Rooms:");
                foreach (int room in availableRooms)
                {
                    Console.WriteLine($"+ Room number: {room}; Capacity: {rooms[room]}");
                }

                Console.Write("--> Input Room Number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("--> Input Customer Name: ");
                string customerName = Console.ReadLine();
                Console.Write("--> Input Customer Email: ");
                string customerEmail = Console.ReadLine();

                reservedRooms[roomNumber] = customerName;
                Console.WriteLine($"--> Check-In successfully! Customer is assigned to Room {roomNumber}");
            }
            else
            {
                Console.WriteLine("--> No suitable room at this time.");
            }
        }

        static void ShowReservedRooms()
        {
            Console.WriteLine("-------Reserved Room---------");
            foreach (var room in reservedRooms)
            {
                Console.WriteLine($"+ Room number: {room.Key}; Customer: {room.Value}");
            }
            Console.WriteLine("-----------------------------");
        }

        static void CheckOut()
        {
            Console.Write("--> Please input room number: ");
            int roomNumber = int.Parse(Console.ReadLine());

            if (reservedRooms.ContainsKey(roomNumber))
            {
                Console.WriteLine($"--> Room: {roomNumber}; Customer Name: {reservedRooms[roomNumber]}");
                Console.Write("--> Please confirm the customer name and input 'y' to continue Check-Out OR input any key to cancel: ");
                string confirm = Console.ReadLine();

                if (confirm.ToLower() == "y")
                {
                    reservedRooms.Remove(roomNumber);
                    Console.WriteLine("--> Check-Out Successfully!");
                }
                else
                {
                    Console.WriteLine("--> Cancel Check-Out");
                }
            }
            else
            {
                Console.WriteLine("--> Could not find customer record of this room");
            }
        }
    }
}
