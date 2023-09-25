using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    public class CurrentAccount : BankAccount
    {
        public decimal OverdraftLimit { get; private set; }

        public CurrentAccount(string customerName, decimal balance, decimal overdraftLimit) 
            : base(customerName, balance)
        {
            OverdraftLimit = overdraftLimit;
        }

        public CurrentAccount(string customerName, int accountNumber, decimal balance, decimal overdraftLimit) 
            : base(customerName, accountNumber, balance)
        {
            OverdraftLimit = overdraftLimit;
        }

        new public decimal Withdraw(decimal amount)
        {
            if (amount <= Balance + OverdraftLimit)
            {
                throw new ArgumentException("Insufficient funds");
            }

            Balance -= amount;
            return Balance;
        }
    }
}
