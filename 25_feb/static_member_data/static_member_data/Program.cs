using System;

namespace static_member_data
{
        //2.static member data
        class Program
        {
            static void Main(string[] args)
            {
                BankAccount obj = new BankAccount();
                Console.WriteLine("enter name and amount: ");
                obj.name = Console.ReadLine();
                decimal amt = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("enter deposit or withdraw: ");
                string t = Console.ReadLine();
                obj.interest = 500;
                switch (t)
                {
                    case "deposit":
                        obj.Deposit(obj.name, amt);
                        break;
                    case "withdraw":
                        obj.Withdraw(obj.name, amt);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }



                BankAccount obj1 = new BankAccount();
                Console.WriteLine("enter name and amount: ");
                obj1.name = Console.ReadLine();
                amt = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("enter deposit or withdraw: ");
                t = Console.ReadLine();
                //  obj1.interest=100;
                switch (t)
                {
                    case "deposit":
                        obj1.Deposit(obj1.name, amt);
                        break;
                    case "withdraw":
                        obj1.Withdraw(obj1.name, amt);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
                Console.ReadKey();
            }
        }
        public class BankAccount
        {
            public Decimal balance = 1000;
            public string name;
            public decimal interest = 200;
            public void Withdraw(string n, decimal amount)
            {
                name = n;
                balance = balance - amount;
                Console.WriteLine("amount withdrawal,{0} balance is {1}", name, balance);
            }
            public void Deposit(string n, decimal amount)
            {
                name = n;
                balance = balance + amount + interest;
                Console.WriteLine("amount deposit,{0} balance is {1}", name, balance);
            }


        }
    }


