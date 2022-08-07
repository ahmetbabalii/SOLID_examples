using System;

namespace SRP.solving.ex
{
    public class CustomerAlreadyExistsException : Exception
    {
        public CustomerAlreadyExistsException(string message) : base(message)
        {

        }
    }

}
