using System;

namespace Run_Time_Polymorphism
{
    //2.Run time polymorphism
    class Account
    {
        public int AccountNumber { get; set; }
        public double Balance { get; set; }
        public Account()
        {
            Balance = 1000;
        }
        public virtual string Deposit(double amount)
        {
           return "Hello from account class deposit method";
        }

        public string showbalance()
        {
            return "Balance Amount of Account Number: " + AccountNumber + " is:  " + Balance;
        }
    }

    //dreived class
    class saving : Account
    {
        public double Interest { get; set; }
        public override string Deposit(double amount)
        {
            Interest = 500;
            Balance = Balance + amount + Interest;
            return "Amount deposited successfully with interest in saving account, Balance is: "+Balance;
        }

    }
    class current : Account
    {
        public override string Deposit(double amount)
        {
            Balance = Balance + amount;
            return "Amount deposited successfully without interest in current account, Balance is: " + Balance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int actno;
            double amt;
            string accounttype;

            Console.WriteLine("Enter Account Number: ");
            actno = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Amount: ");
            amt = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter account type (saving or current) please: ");
            accounttype = Console.ReadLine();

            string result=null;
            string result1 = null;
            Account act = new Account();
           // Account act = null;

            if(accounttype=="saving")
            {
                act = new saving();
            }
            else if(accounttype=="current")
            {
                act = new current();
            }

            act.AccountNumber = actno;
            result = act.Deposit(amt);
            result1 = act.showbalance();

            Console.WriteLine(result);
            Console.WriteLine(result1);
            Console.ReadKey();
        }
    }


}
