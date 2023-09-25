using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    public class BankAccount
    {
        public string CustomerName { get; protected set; }
        public int AccountNumber { get; protected set; }
        public decimal Balance { get; protected set; }

        private static int initialAccountNumber = 100_000;

        public BankAccount(string customerName, decimal balance)
        {
            CustomerName = customerName;
            AccountNumber = initialAccountNumber++;
            Balance = balance;
        }

        public BankAccount(string customerName, int accountNumber, decimal balance)
        {
            CustomerName = customerName;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public decimal Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                throw new ArgumentException("Insufficient funds");
            }

            Balance -= amount;
            return Balance;
        }

        public decimal Deposit(decimal amount)
        {
            Balance += amount;
            return Balance;
        }
    }
}
