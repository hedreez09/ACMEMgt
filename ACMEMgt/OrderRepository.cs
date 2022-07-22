using System;

namespace ACMEMgt
{
    public class OrderRepository
    {
        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 19, 20, 00, 00,
                    new TimeSpan(1, 0, 0));
            }
            return order;
        }

       

        //To Save the current prodcut
        public bool Save()
        {
            var SUCCESS = true;
            //if (order.HasChanges)
            //{
            //    if (order.IsValid)
            //    {
            //        if (order.IsNew)
            //        {
            //            // call an insert stored procedure
            //        }
            //        else
            //        {
            //            //call an update stored procedure
            //        }
            //    }
            //    else
            //    {
            //        SUCCESS = false;
            //    }
            //}

            return SUCCESS;
        }
    }
}