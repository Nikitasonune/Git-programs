using System;

namespace Interface_AbstractClassHierchy_
{
    //4.Using abstract class in a Hierarchy
    interface IAccount
    {
        string Deposit(int amt);

    }
    abstract class Account
    {
        public abstract void hello();
        public virtual string showbalance()
        {
            return "hello from account balance";
        }
    }
    class Saving : Account, IAccount
    {
        public int balance = 100;
        public override void hello()
        {
            Console.WriteLine("hello from abstract method");
        }
        public string Deposit(int amt)
        {
            balance = balance + amt;
            return "amount deposited balance is " + balance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Saving act = new Saving();
            string str = act.Deposit(200);
            Console.WriteLine(str);
            Console.WriteLine(act.showbalance());
            act.hello();
            Console.ReadKey();
        }
    }
}
