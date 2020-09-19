using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4
{
    class CheckingAccount : BankAccount
    {
        private int noOfTransactions;
        private double processingFee;

        public CheckingAccount() : base()
        {
            this.noOfTransactions = 0;
        }

        public CheckingAccount(string acctNum, double bal) : base(acctNum, bal)
        {
            this.noOfTransactions = 0;
            this.processingFee = 10;
        }

        public int GetNoOfTransactions()
        {
            return noOfTransactions;
        }

        public new void Withdraw(double subbed)
        {
            if(base.GetBalance() >= subbed)
            {
                base.SetBalance(base.GetBalance() - subbed);
                if(noOfTransactions > 5)
                {
                    base.SetBalance(base.GetBalance() - processingFee);
                }
            }
            this.noOfTransactions++;
        }

        public new void Deposit(double added)
        {
            base.Deposit(added);
        }

        public new void SetBalance(double bal)
        {
            base.SetBalance(bal);
        }
    }
}
