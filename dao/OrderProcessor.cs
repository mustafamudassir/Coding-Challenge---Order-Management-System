
using Order_Management_System.entity;
using OrderManagementSystem.dao;
using OrderManagementSystem.entity.model;
using System;
using System.Collections.Generic;

namespace OrderManagementSystem.dao
{
    public class OrderProcessor : IOrderManagementRepository
    {
        private List<User> users = new List<User>();
        private List<Product> products = new List<Product>();
        private List<Order> orders = new List<Order>();
        private int orderIdCounter = 1;

        public void CreateOrder(User user, List<Product> products)
        {
           
            CreateUserIfNotExists(user);

            // Create an order and add it to the orders list
            Order order = new Order
            {
                OrderId = orderIdCounter++,
                User = user,
                Products = products,
                OrderDate = DateTime.Now
            };

            orders.Add(order);

            Console.WriteLine("Order created successfully!");
        }

        public void CancelOrder(int userId, int orderId)
        {
            
            User user = users.Find(u => u.UserId == userId);
            Order order = orders.Find(o => o.OrderId == orderId && o.User == user);

            if (user != null && order != null)
            {
               
                orders.Remove(order);
                Console.WriteLine("Order canceled successfully!");
            }
            else
            {
                Console.WriteLine("User or order not found. Unable to cancel the order.");
            }
        }

        public void CreateProduct(User adminUser, Product product)
        {
            
            if (adminUser != null && adminUser.Role == "Admin")
            {
                
                products.Add(product);
                Console.WriteLine("Product created successfully!");
            }
            else
            {
                Console.WriteLine("Admin user not found. Unable to create the product.");
            }
        }

        public void CreateUser(User user)
        {
            
            user.UserId = users.Count + 1;
            users.Add(user);
            Console.WriteLine("User created successfully!");
        }

        public List<Product> GetAllProducts()
        {
            
            return products;
        }

        public List<Product> GetOrderByUser(User user)
        {
           
            List<Product> userProducts = new List<Product>();
            foreach (var order in orders)
            {
                if (order.User == user)
                {
                    userProducts.AddRange(order.Products);
                }
            }

            return userProducts;
        }

        private void CreateUserIfNotExists(User user)
        {
           s
            if (!users.Contains(user))
            {
                CreateUser(user);
            }
        }
    }
}
