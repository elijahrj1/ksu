using System;
using System.Collections.Generic;
using System.Reflection.Metadata;

namespace Lab4
{
    class DriverBank
    {
        static void Main(string[] args)
        {
            BankAccount b = new BankAccount();
            BankAccount c = new BankAccount();

            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Welcome To The C# Bank");
                Console.WriteLine("--===Menu==--");
                Console.WriteLine("0 - Exit");
                Console.WriteLine("1 - Create a Checking Account");
                Console.WriteLine("2 - Create a Savings Account");
                Console.WriteLine("3 - Withdraw");
                Console.WriteLine("4 - Deposit");
                Console.WriteLine("5 - Check Balance");
                Console.Write("Please Choose an Option: ");

                string option;
                option = Console.ReadLine();
                int selected = Convert.ToInt32(option);

                if (selected == 0)
                {
                    Environment.Exit(0);
                }

                if(selected == 1)
                {
                    Console.Write("Enter a New Account Number: ");
                    string inputAcctNum = Console.ReadLine();
                    Console.Write("Enter Initial Balance: ");
                    string inputBal = Console.ReadLine();
                    double bal = Convert.ToDouble(inputBal);

                    c = new CheckingAccount(inputAcctNum, bal);
                }

                if(selected == 2)
                {
                    Console.Write("Enter a New Account Number: ");
                    string inputAcctNum = Console.ReadLine();
                    Console.Write("Enter Initial Balance: ");
                    string inputBal = Console.ReadLine();
                    double bal = Convert.ToDouble(inputBal);

                    b = new SavingsAccount(inputAcctNum, bal);
                }

                if(selected == 3)
                {
                    Console.WriteLine("If you withdraw more than 5 times then you will be charged a $10 fee from the account withdrawn.");
                    Console.WriteLine("Current amount of withdrawls: " + ((CheckingAccount)c).GetNoOfTransactions());
                    Console.Write("Enter an amount to be withdrawn (You may only withdraw from your Checking Account): ");
                    string inputAmt = Console.ReadLine();
                    double amt = Convert.ToDouble(inputAmt);
                    if(amt <= ((CheckingAccount)c).GetBalance())
                    {
                        ((CheckingAccount)c).Withdraw(amt);
                    }
                    else
                    {
                        Console.WriteLine("Amount entered greater than balance.");
                    }
                }

                if(selected == 4)
                {
                    Console.WriteLine("--==Account Selection==--");
                    Console.WriteLine("1 - Checking");
                    Console.WriteLine("2 - Savings");
                    Console.Write("Select an account to modify: ");
                    string secondary = Console.ReadLine();
                    int choice = Convert.ToInt32(secondary);
                    if(choice == 1)
                    {
                        Console.Write("Enter an amount to deposit: ");
                        string aa = Console.ReadLine();
                        double bb = Convert.ToDouble(aa);
                        ((CheckingAccount)c).Deposit(bb);
                    }
                    if (choice == 2)
                    {
                        Console.Write("Enter an amount to deposit: ");
                        string aa = Console.ReadLine();
                        double bb = Convert.ToDouble(aa);
                        ((SavingsAccount)b).Deposit(bb);
                    }
                }

                if(selected == 5)
                {
                    Console.WriteLine("--==Account Selection==--");
                    Console.WriteLine("1 - Checking");
                    Console.WriteLine("2 - Savings");
                    Console.Write("Select an account to modify: ");
                    string secondary = Console.ReadLine();
                    int choice = Convert.ToInt32(secondary);
                    if (choice == 1)
                    {
                        Console.WriteLine("Current Balance of Checking Account: $" + ((CheckingAccount)c).GetBalance());
                    }
                    if (choice == 2)
                    {
                        Console.WriteLine("Current Balance of Savings Account: $" + ((SavingsAccount)b).GetBalance());
                    }
                }
            }
        }
    }
}
