using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACMEMgt
{
    public class Customer
    {
		public int CustomerId { get; private set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string EmailAddress { get; set; }

	}
}
