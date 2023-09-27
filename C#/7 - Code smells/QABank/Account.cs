using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    public interface IAccount
    {
        // Write interface
    }

    public class Account : IAccount
    {
        // We would have getters/setters for these but left out to minimise the code
        private Customer owner;
        private int accountNumber;
        private double interest;
        private double overdraftLimit;
        private double balance;
        private AccountType accountType;
        private Dictionary<int, Payee> directDebits = new Dictionary<int, Payee>();
        private Dictionary<int, Payee> standingOrders = new Dictionary<int, Payee>();

        public Account(Customer owner)
        {
            // Left out rest of initialization for brevity
            this.owner = owner;
            owner.accounts.Add(accountNumber, this);
        }

        public void WithDraw(double amount)
        {
            if (amount >= balance && accountType == AccountType.Deposit)
                return;
            balance -= amount;
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void AddInterestToAccount()
        { // used where account is a deposit acct
            balance += balance * 0.0001;
        }
        // used where account is current account
        public bool IsOverDrawn()
        {
            return false;
        }
        // used where account is current account
        public void SetOverdraftLimit(double overdraftLimit)
        {
            this.overdraftLimit = overdraftLimit;
        }
        // used where account is current account
        public void ProcessDirectDebits()
        {
            foreach (Payee payee in directDebits.Values)
            {
            }
        }
        // used where account is current account
        public void ProcessStandingOrders()
        {
            foreach (Payee payee in standingOrders.Values)
            {
            }
        }
    }

    enum AccountType
    {
        Deposit
    }
}
