using System;
using System.ComponentModel.DataAnnotations;

namespace SRP.solving.ex
{
    public class ImproperCustomerCredentialsException : ValidationException
    {
        private static string prefix = "Uygun olmayan müşteri kimlik bilgileri sağlandı: ";
        public ImproperCustomerCredentialsException(string message) : base(message)
        {

        }

        public string getMessage()
        {
            return prefix + base.Message;
        }
    }
}
