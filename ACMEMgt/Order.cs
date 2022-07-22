using System;
using System.Collections.Generic;

namespace ACMEMgt
{
    public class Order : EntityBase
    {
        public Order() : this(0)
        {
        }

        public Order(int orderId)
        {
            OrderId = orderId;
            OrderItems = new List<OrderItem>();
        }

        public int CustomerId { get; set; }
        public int OrderId { get; private set; }
        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderItem> OrderItems { get; set; } //relationship btw order and orderItems
        public int ShippingAddressId { get; set; }

        public override string ToString() => $"{OrderDate}({OrderId})";

       

        //To retrieve all product
        public List<Order> Retrieve()
        {
            //code that retrieve all product
            return new List<Order>();
        }

      

        //To validate that the specified field are required and not null
        public override bool Validate()
        {
            var inValid = true;

            if (OrderDate == null) inValid = false;

            return inValid;
        }
    }
}