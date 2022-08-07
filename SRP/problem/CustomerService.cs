using SRP.solving.dao;
using SRP.solving.entity;
using SRP.solving.ex;
using System;

namespace SRP.problem
{
    public class CustomerService
    {
        private readonly ICustomerDAO customerDao;
        private Customer currentCustomer;
        private int loginAttemptCount;


        public CustomerService(ICustomerDAO customerDao)
        {
            this.customerDao = customerDao;
        }

        public void login(string tckn, string password)
        {
            validateTckn(tckn);
            validatePassword(password);

            Customer customer = customerDao.retrieveCustomer(tckn);

            if (customer.getPassword().Equals(password) & !customer.isLocked() & !customer.isLoggedIn())
            {
                customer.setLoggedIn(true);
                customerDao.updateCustomer(customer);
                currentCustomer = customer;
                // login olabilecek yetkinlikte ise login olacak şekilde güncelliyoruz
            }
            else if (customer.isLoggedIn())
            {
                throw new CustomerAlreadyLoggedException("hali hazırda login olduğu bir yer var ise hata fırlatılacak");
            }
            else if (customer.isLocked())
            {                
                throw new CustomerLockedException("hesabın kilitli olma durumu hata fırlatılacak");
            }
            else if (!customer.getPassword().Equals(password))
            {
                loginAttemptCount++;
                if (loginAttemptCount == 3)
                {                    
                    customer.setLocked(true);
                    customerDao.updateCustomer(customer);
                    loginAttemptCount = 0;
                    throw new MaxNumberOfFailedLoggingAttemptExceededException("şifrenin yanlış olma durumuna göre kişinin hesabının kitlenmesi");
                }
                else
                {                    
                    throw new WrongCustomerCredentialsException("Şifrenin yanlış olma durumunun fırlatılması.");
                }
            }
        }

        public void createCustomer(Customer customer)
        {
            try
            {
                customerDao.createCustomer(customer);
            }
            catch (CustomerAlreadyExistsException e) { }
        }

        public Customer retrieveCustomer(string tckn)
        {
            Customer customer = customerDao.retrieveCustomer(tckn);
            return customer;
        }

        public Customer refreshCustomer(Customer customer)
        {
            return customerDao.refreshCustomer(customer);
        }

        public bool logout(Customer customer)
        {
            bool logout = false;

            customer.setLoggedIn(false);
            try
            {
                logout = customerDao.updateCustomer(customer);
                logout = true;
                //logger.info("Customer logging out: " + customer);
            }
            catch
            {
                // logic
            }

            customer = null;
            return logout;
        }

        public bool changePassword(Customer customer, string password)
        {
            bool change = false;
            validatePassword(password);
            customer.setPassword(password);

            try
            {
                change = customerDao.updateCustomer(customer);
            }
            catch
            {
                // logic
            }
            //logger.info("Customer changed the password: " + customer);
            return change;
        }

        private bool validatePassword(string password)
        {
            // control logic
            return true;
        }

        public bool lockCustomer(Customer customer)
        {
            bool @lock = false;
            customer.setLocked(true);
            try
            {
                @lock = customerDao.updateCustomer(customer);
                //logger.info("Customer locked: " + customer);
            }
            catch
            {
                // logic
            }
            return @lock;
        }

        private bool validateTckn(string tckn)
        {
            bool b = true;
            if (tckn == null | tckn.Length == 0)
                throw new ImproperCustomerCredentialsException("Empty TCKN not allowed.");

            string length = ""; // Şifre girişi bir nesne üzerinde tutulmalı
            int tcknLength = Convert.ToInt16(length);
            if (tckn.Length < tcknLength)
                throw new ImproperCustomerCredentialsException("TCKN must have " + tcknLength + " characters.");

            return b;
        }
    }
}
