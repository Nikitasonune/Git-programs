using System;

namespace Inheritance_Assignment7
{
    //5.Interface
    interface Account
    {
        void Deposit(int amt);
    }
    interface Account1 : Account
    {
        void showbalance();
    }
    class Saving : Account1
    {
        public void Deposit(int amt)
        {
            Console.WriteLine("deposite " + amt);
        }
        public void showbalance()
        {
            Console.WriteLine("Show");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Saving act = new Saving();
            act.Deposit(2);
            act.showbalance();
            Console.ReadKey();

        }
    }
}
