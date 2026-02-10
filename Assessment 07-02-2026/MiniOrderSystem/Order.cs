using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniOrderSystem
{
    public class Order
    {
        public int OrdId { get; set; }
        public int CustId { get; set; }
        public List<OrderItem> OrderItems { get; set; }


        public Order()
        {
            OrderItems = new List<OrderItem>();
        }

    }
}
