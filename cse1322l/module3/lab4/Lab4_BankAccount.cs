using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class BankAccount
    {
        private string accountNumber;
        private double balance;
        
        public BankAccount()
        {
            this.accountNumber = "";
            this.balance = 0;
        }
        
        public BankAccount(string acctNum, double bal)
        {
            this.accountNumber = acctNum;
            this.balance = bal;
        }

        public string GetAccountNumber()
        {
            return accountNumber;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void Deposit(double added)
        {
            if(added >= 0)
            {
                balance += added;
            }
        }

        public void Withdraw(double subbed)
        {
            if(subbed >= 0 && balance >= subbed)
            {
                balance -= subbed;
            }
        }

        public void SetBalance(double bal)
        {
            balance = bal;
        }
    }
}
