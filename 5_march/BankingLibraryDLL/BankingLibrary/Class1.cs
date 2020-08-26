using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{
    public class Account
    {
        public int AccountNumber { get; set; }
        public static double  Balance { get; set; }

        //creating constructor
        public Account()
        {
            Balance = 1000;
        }
        public virtual string Deposit(double amount)
        {
            return "Hello from account class deposit method";
        }
        public virtual string withdrawal(double amount)
        {
            return "Hello from account class withdrawal method";
        }
        public string showBalance()
        {
            return "Balance Amount of Account number: " + AccountNumber + " is: " + Balance;
        }
    }
    //creating a derived class Saving from class Account
    public class Saving : Account
    {
        public double Interest { get; set; }

        //override the base class deposit method
        public override string Deposit(double amount)
        {
            Interest = 500;
            Balance = Balance + amount + Interest;
            return " Amount Deposited successfully with Interest, Balance is: " + Balance;
        }
        public override string withdrawal(double amount)
        {
            Balance = Balance - amount;
            return " Amount withdrawal successfully, Balance is: " + Balance;
        }
    }

    //create class current
    public class Current : Account
    {
        //override the base class deposit method
        public override string Deposit(double amount)
        {
            Balance = Balance + amount;
            return " Amount Deposited successfully without Interest, Balance is: " + Balance;
        }
        public override string withdrawal(double amount)
        {
            Balance = Balance - amount;
            return " Amount withdrawal successfully, Balance is: " + Balance;
        }
    }
}

