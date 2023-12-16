using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;

namespace OrderManagementSystem.exception
{
    public class OrderNotFoundException : Exception
    {
        public OrderNotFoundException() : base("Order not found.")
        {
           
        }
    }
}

