using OrderManagementSystem.dao;
using OrderManagementSystem.entity.model;
using System;

namespace Order_Management_System.main
{
    public class MainModule
    {
        private static OrderProcessor orderProcessor = new OrderProcessor(); // 

        public static void Main(string[] args)
        {
            while (true)
            {
                DisplayMenu();

                // Get user input
                string userInput = Console.ReadLine();

                // Process user input
                ProcessUserInput(userInput);
            }
        }

        private static void DisplayMenu()
        {
            Console.WriteLine("Order Management System Menu:");
            Console.WriteLine("1. Create User");
            Console.WriteLine("2. Create Product");
            Console.WriteLine("3. Cancel Order");
            Console.WriteLine("4. Get All Products");
            Console.WriteLine("5. Get Orders by User");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice (1-6): ");
        }

        private static void ProcessUserInput(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("You selected option 1 (Create User)");

                    // Get input for user details
                    Console.Write("Enter userid: ");
                    string username = Console.ReadLine();

                    Console.Write("Enter password: ");
                    string password = Console.ReadLine();

                    Console.Write("Enter user role (Admin/User): ");
                    string role = Console.ReadLine();

                    
                    orderProcessor.CreateUser(new User { Username = username, Password = password, Role = role });
                    Console.WriteLine("User created successfully!");
                    break;

                case "2":
                    Console.WriteLine("You selected option 2 (Create Product)");

                    // Get input for product details
                    Console.Write("Enter product name: ");
                    string productName = Console.ReadLine();

                    Console.Write("Enter product description: ");
                    string productDescription = Console.ReadLine();

                    Console.Write("Enter product price: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal productPrice))
                    {
                      
                        Console.WriteLine("Product created successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for product price. Please enter a valid decimal value.");
                    }
                    break;

                case "3":
                    Console.WriteLine("You selected option 3 (Cancel Order)");

                    
                    Console.Write("Enter user ID: ");
                    if (int.TryParse(Console.ReadLine(), out int userIdForCancellation))
                    {
                        Console.Write("Enter order ID: ");
                        if (int.TryParse(Console.ReadLine(), out int orderIdForCancellation))
                        {
                            
                            Console.WriteLine("Order canceled successfully!");
                        }
                        else
                        {
                            Console.WriteLine("Invalid input for order ID. Please enter a valid integer value.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for user ID. Please enter a valid integer value.");
                    }
                    break;

                case "4":
                    Console.WriteLine("You selected option 4 (Get All Products)");
                   
                    break;

                case "5":
                    Console.WriteLine("You selected option 5 (Get Orders by User)");

                    
                    Console.Write("Enter user ID: ");
                    if (int.TryParse(Console.ReadLine(), out int userIdForOrders))
                    {
                        
                    }
                    else
                    {
                        Console.WriteLine("Invalid input for user ID. Please enter a valid integer value.");
                    }
                    break;

                case "6":
                    Console.WriteLine("Exiting the Order Management System. Goodbye!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 6.");
                    break;
            }
        }
    }
}
