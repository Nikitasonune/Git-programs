using System;

namespace BankExamplePractice
{
    class BankAccount
    {
        public decimal balance = 1500;
        public string name;

        public void withdrawal(string n,decimal Amount)
        {
            name = n;
            balance = balance - Amount;
           // Console.WriteLine("Amount withdrawal,current balance is: " +balance);
            Console.WriteLine("Amount withdrawal successfully balance is: "+balance);
        }
        public void deposit(string n,decimal Amount)
        {
            name = n;
            balance = balance + Amount;
            //Console.WriteLine("Amount deposited, current balance is" +balance);
            //Console.WriteLine(balance);
            Console.WriteLine("Amount deposited successfully balance is: "+ balance);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount obj = new BankAccount();
            Console.WriteLine("Enter name and amount: ");
            obj.name = Console.ReadLine();
            decimal amt = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter deposit and withdrawal");
            string t = Console.ReadLine();
            switch(t)
            {
                case "deposit":
                    obj.deposit(obj.name, amt);
                    break;
                case "withdrawal":
                    obj.withdrawal(obj.name, amt);
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
            Console.ReadKey();
        }
    }
}
