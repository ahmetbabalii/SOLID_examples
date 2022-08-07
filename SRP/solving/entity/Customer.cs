using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP.solving.entity
{
    public class Customer
    {
		private string tckn;
		private string firstName;
		private string lastName;
		private string password;
		private bool locked;
		private bool loggedIn;
		private int invalidLoginCount;				

		public Customer() { }

		public Customer(string tckn, string firstName, string lastName, string password, 
					    bool locked, bool loggedIn,	int invalidLoginCount)
		{
			this.tckn = tckn;
			this.firstName = firstName;
			this.lastName = lastName;
			this.password = password;
			this.locked = locked;
			this.loggedIn = loggedIn;
			this.invalidLoginCount = invalidLoginCount;
		}

		public string getTckn()
		{
			return tckn;
		}

		public void setTckn(string tckn)
		{
			this.tckn = tckn;
		}

		public string getFirstName()
		{
			return firstName;
		}

		public void setFirstName(string firstName)
		{
			this.firstName = firstName;
		}

		public string getLastName()
		{
			return lastName;
		}

		public void setLastName(string lastName)
		{
			this.lastName = lastName;
		}

		public string getPassword()
		{
			return password;
		}

		public void setPassword(string password)
		{
			this.password = password;
		}

		public bool isLocked()
		{
			return locked;
		}

		public void setLocked(bool locked)
		{
			this.locked = locked;
		}

		public bool isLoggedIn()
		{
			return loggedIn;
		}

		public void setLoggedIn(bool loggedIn)
		{
			this.loggedIn = loggedIn;
		}

		public int getInvalidLoginCount()
		{
			return invalidLoginCount;
		}

		public void setInvalidLoginCount(int invalidLoginCount)
		{
			this.invalidLoginCount = invalidLoginCount;
		}

		public bool equals(object @object)
		{
			Customer customer = null;
			var control = @object.GetType().IsAssignableFrom(customer.GetType());
			if (control) {
				customer = (Customer)@object;
				if (customer.getTckn().Equals(tckn))
					return true;
				else
					return false;
			} 
			else
				return false;
		}
	}
}
