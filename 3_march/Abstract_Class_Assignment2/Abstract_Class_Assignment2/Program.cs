using System;

namespace Abstract_Class_Assignment2
{
    //4.abstract class
    abstract class Account
    {
        public abstract void Deposite (int amt);
        public void showbalance()
        {
            Console.WriteLine("balance");
        }
    }
    class Saving : Account
    {
        public override void Deposite(int amt)
        {
            Console.WriteLine("deposite "+amt);
        }
    }
    class Program
    {
        static void Main(string[]args)
        {
            Account act = new Saving();
            act.showbalance();
            act.Deposite(2);
            Console.ReadKey();

        }
    }


}
