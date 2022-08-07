using SRP.solving.entity;
using System;

namespace SRP.solving.dao
{
    public interface ICustomerDAO
    {
        bool createCustomer(Customer customer);
        Customer retrieveCustomer(string tckn);
        bool updateCustomer(Customer customer);
        bool deleteCustomer(Customer customer);
        Customer refreshCustomer(Customer customer);
    }
}
