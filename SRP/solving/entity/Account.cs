using SRP.solving.ex;
using System.Runtime.CompilerServices;

namespace SRP.solving.entity
{
    public class Account
    {
        protected string iban;
        protected double balance;
        protected bool defaultAccount;
        protected Customer owner;

        public Account()
        {
        }

        public Account(string iban, double balance)
        {
            this.iban = iban;
            this.balance = balance;
        }

        public string getIban()
        {
            return iban;
        }

        public void setIban(string iban)
        {
            this.iban = iban;
        }

        public double getBalance()
        {
            return balance;
        }

        public void setBalance(double balance)
        {
            this.balance = balance;
        }


        [MethodImpl(MethodImplOptions.Synchronized)]
        public void withdraw(double amount)
        {
            if (amount >= 0)
            {
                if (balance >= amount)
                {
                    balance -= amount;
                }
                else
                    throw new InsufficentFundException("Balance: " + balance + " Çekilen Miktar: " + amount);
            }
            else
                throw new NegativeAmountException("Miktar: " + amount);
        }

        [MethodImpl(MethodImplOptions.Synchronized)]
        public void deposit(double amount)
        {
            if (amount >= 0)
            {
                balance += amount;
            }
            else
                throw new NegativeAmountException("Miktar: " + amount);
        }

        public void transfer(double amount)
        {
            withdraw(amount);
        }
    }
}
