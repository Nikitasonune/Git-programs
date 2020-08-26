using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_with_Delegate
{
    class Account
    {
        public int balance = 1000;
        public int Interest = 500;
        public string deposit(int amt)
        {
            balance = balance + amt;
            return "amount deposited successfully Balance is: " + balance;
        }
        public string withdrawal(int amt)
        {
            balance = balance - amt;
            return "amount withdrawl successfully Balance is: " + balance;
        }
        public int depositInterest(int amt)
        {
            balance = balance + amt + Interest;
            return balance;
        }
    }
    class Program
    {
        //string and amt indicate that the method has parameter and return type
        //Declaring a Delegate
        public delegate string accountdelegate(int amt);
        public delegate int accountDelegate(int amt);

        //Declaring an Event
        private event accountdelegate accountEvent;
        private event accountDelegate accountevent;
        static void Main(string[] args)
        {
            Program p = new Program();
            int amount = 0, res = 0;
            Console.WriteLine("Enter Amount please: ");
            amount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter deposit or withdrawl or interest please: ");
            string t = Console.ReadLine();
            // int s = int.Parse(Console.ReadLine());

            Account act = new Account();
            //accountdelegate ad = null; //Delegate ka object nahi bhi create kiya to chalta

           // accountDelegate D = null;

            switch (t)
            {
                case "deposit":
                    //subscribing event
                    p.accountEvent += new accountdelegate(act.deposit);
                    break;

                case "withdrawl":
                    p.accountEvent += new accountdelegate(act.withdrawal);
                    break;

                case "interest":
                    p.accountevent += new accountDelegate(act.depositInterest);
                    break;

                default:
                    Console.WriteLine("You should enter deposit or withdrawl Dear!");

                    break;
            }
            if (p.accountEvent != null)
            {
                string result = p.accountEvent(amount);
                Console.WriteLine(result);
            }
            else if (p.accountevent != null)
            {
                res = p.accountevent(amount);
            Console.WriteLine("Amount Deposited successfully with Interest, Balance is: " + res);
            }
            Console.ReadKey();
        }
    }
}
