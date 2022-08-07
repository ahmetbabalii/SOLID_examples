using SRP.solving.entity;

namespace SRP.solving.service.Abstract
{
    public interface ICustomerService
    {
        bool lockCustomer(Customer customer);
        bool changePassword(Customer customer, string newpassword);
        void createCustomer(Customer customer);
        Account getDefaultAccount(Customer customer);
        Customer getCurrentCustomer();
        Customer refreshCustomer(Customer customer);
        void checkIfCustomerAlreadyLoggedIn(Customer customer);
        void checkIfCustomerLocked(Customer customer);
    }
}
