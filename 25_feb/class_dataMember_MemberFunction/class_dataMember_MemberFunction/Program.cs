using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_dataMember_MemberFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount obj = new BankAccount();
            Console.WriteLine("enter name and amount: ");
            string n = Console.ReadLine();
            decimal amt =Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("enter deposit or withdraw: ");
            string t = Console.ReadLine();
            switch(t)
            {
                case "deposit":
                    obj.Deposit(n, amt);
                    break;
                case "withdraw":
                    obj.Withdraw(n, amt);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.ReadKey();
        }
    }
    class BankAccount
    {
        private Decimal balance = 1000;
        private string name;
        public void Withdraw(string n, decimal amount)
        {
            name = n;
            balance = balance - amount;
            Console.WriteLine("amount withdrawal,{0} balance is {1}", name, balance);
        }
        public void Deposit(string n, decimal amount)
        {
            name = n;
            balance = balance + amount;
            Console.WriteLine("amount deposit,{0} balance is {1}", name, balance);
        }


    }

}
