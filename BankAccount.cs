using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    public class BankAccount
    {
        private static int nextAccountNumber = 100000; // Starting account number

        private string customerName;
        private int accountNumber;
        private decimal balance;

        public BankAccount(string customerName)
        {
            this.customerName = customerName;
            this.accountNumber = nextAccountNumber++;
            this.balance = 0.0m; // Initial balance is zero
        }

        public int AccountNumber
        {
            get { return accountNumber; }
        }

        public decimal Balance
        {
                       get { return balance; }
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit amount must be positive.");
            }
            balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdrawal amount must be positive.");
            }
            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds for withdrawal.");
            }
            balance -= amount;
        }
    }
}
