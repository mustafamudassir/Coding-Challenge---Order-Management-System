
using Order_Management_System.entity;
using OrderManagementSystem.entity.model;
using System.Collections.Generic;

namespace OrderManagementSystem.dao
{
    public interface IOrderManagementRepository
    {
       
        void CreateOrder(User user, List<Product> products);

        
        void CancelOrder(int userId, int orderId);

       
        void CreateProduct(User adminUser, Product product);

        
        void CreateUser(User user);

        
        List<Product> GetAllProducts();

        
        List<Product> GetOrderByUser(User user);
    }
}
