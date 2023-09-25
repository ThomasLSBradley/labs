using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    public class SavingsAccount : BankAccount
    {
        public decimal InterestRate { get; private set; }

        public SavingsAccount(string customerName, decimal balance, decimal interestRate)
            : base(customerName, balance)
        {
            InterestRate = interestRate;
        }

        public SavingsAccount(string customerName, int accountNumber, decimal balance, decimal interestRate)
            : base(customerName, accountNumber, balance)
        {
            InterestRate = interestRate;
        }

        public decimal AddInterest()
        {
            Balance *= 1 + InterestRate;
            return Balance;
        }
    }
}
