using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    //Delegate Example with 2 method of string return type and 1 method is of int return type
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
            balance = balance + amt+Interest;
            return balance;
        }
    }
    class Program
    {
        //string and amt indicate that the method has parameter and return type
        public delegate string accountdelegate(int amt);
        public delegate int  accountDelegate(int amt);
        static void Main(string[] args)
        {
            int amount = 0, res = 0;
            Console.WriteLine("Enter Amount please: ");
             amount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter deposit or withdrawl or interest please: ");
            string t =Console.ReadLine();
           // int s = int.Parse(Console.ReadLine());

            Account act = new Account();
            accountdelegate ad = null;

            accountDelegate D=null;

            switch (t)
            {
                case "deposit":
                    ad = new accountdelegate(act.deposit);
                    break;

                case "withdrawl":
                    ad = new accountdelegate(act.withdrawal);
                    break;

                case "interest":
                    D = new accountDelegate(act.depositInterest);
                    break;

                default:
                    Console.WriteLine("You should enter deposit or withdrawl Dear!");
                    
                    break;
            }
            if (ad != null )
            {
                string result = ad(amount);
                Console.WriteLine(result);
            }
            else if(D != null)
            { 
                res = D(amount);
           Console.WriteLine("Amount Deposited successfully with Interest, Balance is: " + res);
            }
            Console.ReadKey();
        }
    }
}
