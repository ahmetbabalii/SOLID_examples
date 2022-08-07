using SRP.solving.dao;
using SRP.solving.entity;
using SRP.solving.ex;
using SRP.solving.service.Abstract;
using System;

namespace SRP.solving.service.Concrete
{
    public class LoginService : ILoginService
    {
        private ICustomerService customerService;
        private ICustomerDAO customerDao;
        private int loginAttemptCount;

        public void login(string tckn, string password)
        {
            Customer customer = customerDao.retrieveCustomer(tckn);
            loginCustomer(customer, password);
        }

        private void loginCustomer(Customer customer, string password)
        {
            customerService.checkIfCustomerAlreadyLoggedIn(customer);
            customerService.checkIfCustomerLocked(customer);
            checkCustomerPassword(customer, password);
            customerDao.updateCustomer(customer);
        }
      
        private void checkCustomerPassword(Customer customer, string password)
        {
            if (!customer.getPassword().Equals(password))
            {
                loginAttemptCount++;
                checkLoginAttempCount(customer);
                throw new WrongCustomerCredentialsException("Şifrenin yanlış olma durumunun fırlatılması.");
            }
        }

        private void checkLoginAttempCount(Customer customer)
        {
            if (loginAttemptCount == 3)
            {
                lockCustomer(customer);                
            }
        }

        private void lockCustomer(Customer customer)
        {
            customer.setLocked(true);
            throw new MaxNumberOfFailedLoggingAttemptExceededException("şifrenin yanlış olma durumuna göre kişinin hesabının kitlenmesi");
        }

        public bool logout(Customer customer)
        {
            bool logout = false;

            customer.setLoggedIn(false);
            try
            {
                logout = customerDao.updateCustomer(customer);
                logout = true;
            }
            catch { }

            customer = null;
            return logout;
        }
    }
}
