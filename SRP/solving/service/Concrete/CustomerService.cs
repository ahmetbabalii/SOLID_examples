using SRP.solving.dao;
using SRP.solving.entity;
using SRP.solving.ex;
using SRP.solving.service.Abstract;

namespace SRP.solving.service.Concrete
{
    public class CustomerService : ICustomerService
    {
        private ICustomerDAO customerDao;
        private Customer currentCustomer;

        public CustomerService()
        {
        }

        public void checkIfCustomerAlreadyLoggedIn(Customer customer)
        {
            if (customer.isLoggedIn())
            {
                throw new CustomerAlreadyLoggedException("hali hazırda login olduğu bir yer var ise hata fırlatılacak");
            }
        }

        public void checkIfCustomerLocked(Customer customer)
        {
            if (customer.isLocked())
            {
                throw new CustomerLockedException("hesabın kilitli olma durumu hata fırlatılacak");
            }
        }

        public bool changePassword(Customer customer, string newpassword)
        {
            // logic
            return false;
        }      

        public void createCustomer(Customer customer)
        {
            // logic
        }

        public Customer getCurrentCustomer()
        {
            return null;
        }

        public Account getDefaultAccount(Customer customer)
        {
            return null;
        }

        public bool lockCustomer(Customer customer)
        {
            bool @lock = false;
            customer.setLocked(true);
            try
            {
                @lock = customerDao.updateCustomer(customer);
            }
            catch
            {
               
            }

            return @lock;
        }

        public Customer refreshCustomer(Customer customer)
        {
            return customerDao.refreshCustomer(customer);
        }
    }
}
