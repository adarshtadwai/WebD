using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcmeCustomerManager
{
    public class Customer
    {
		public int CustomerId { get; private set; }
		public string EmailAddress { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

		/*
		private string LastName;
		public string _LastName
		{
			get { return LastName; }
			set { LastName = value; }
		}
		*/

		public Customer()
		{
			
		}

		public Customer Retrieve(int customerId)
		{
			return new Customer();
		}

		public List<Customer> Retrieve()
		{
			return new List<Customer>();
		}

		public Customer(int CustID)
		{
			CustomerId = CustID;
		}

		public string FullName
		{
			get
			{
				string fullname = FirstName;
				if(!string.IsNullOrWhiteSpace(LastName) && !string.IsNullOrWhiteSpace(FirstName))
				{
					fullname += ", ";
				}
				fullname += LastName;
				return fullname;
			}
		}

		public bool Validate()
		{
			return !string.IsNullOrEmpty(LastName) && !string.IsNullOrWhiteSpace(EmailAddress);
		}



	}
}
