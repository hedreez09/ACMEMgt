﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMEMgt
{
	public class OrderRepository
	{
		public Order Retrieve(int orderId)
		{
			Order order = new Order(orderId);

			if(orderId == 10)
			{
				order.OrderDate = new DateTimeOffset(DateTime.Now.Year, 4, 19, 20, 00, 00, 
					new TimeSpan(1, 0, 0));
			}
			return order;
		}
	}
}
