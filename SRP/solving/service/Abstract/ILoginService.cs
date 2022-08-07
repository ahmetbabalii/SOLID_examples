using SRP.solving.entity;
using System;

namespace SRP.solving.service.Abstract
{
    internal interface ILoginService
    {
        void login(string tckn, string password);
        bool logout(Customer customer);
    }
}
