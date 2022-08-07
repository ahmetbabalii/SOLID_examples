using System;

namespace SRP.solving.ex
{
    public class NegativeAmountException : Exception
    {
        private static string prefix = "Negatif tutar sağlanamıyor. ";
        public NegativeAmountException(string message) : base(prefix + message)
        {
            
        }

        public string getMessage()
        {
            return prefix + this.getMessage();
        }
    }
}
