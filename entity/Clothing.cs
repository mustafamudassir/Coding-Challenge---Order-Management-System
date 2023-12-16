using Order_Management_System.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementSystem.entity.model
{
    public class Clothing : Product
    {
        
        public string Size { get; set; }
        public string Color { get; set; }

        
        public Clothing() { }

        public Clothing(int productId, string productName, string description, double price, int quantityInStock, string type, string size, string color)
            : base(productId, productName, description, price, quantityInStock, type)
        {
            Size = size;
            Color = color;
        }
    }
}
