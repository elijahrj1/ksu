using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;

namespace Lab4
{
    class SavingsAccount : BankAccount
    {
        private double interestRate;
        private double interest;

        public SavingsAccount() : base()
        {
            interestRate = 0;
            interest = 0;
        }

        public SavingsAccount(string acctNum, double bal) : base(acctNum, bal)
        {
            interestRate = 0.015;
            interest = 0;
        }

        public double GetInterest()
        {
            return interest;
        }

        public double GetInterestRate()
        {
            return interestRate;
        }

        public void SetInterestRate(double rate)
        {
            this.interestRate = rate; //I wish I could set my interest rate :'(
        }

        public void AddInterest()
        {
            base.Deposit(base.GetBalance() * this.interestRate);
        }
    }
}
