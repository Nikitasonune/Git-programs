using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_2
{
    abstract class Bank
    {
        public abstract void getBalance();
        
    }
    class BankA : Bank
    {
        public override void getBalance()
        {
            Console.WriteLine("$100 deposited in Bank A");
        }
    }
    class BankB : Bank
    {
        public override void getBalance()
        {
            Console.WriteLine("$150 deposited in Bank B");
        }
    }
    class BankC : Bank
    {
        public override void getBalance()
        {
            Console.WriteLine("$200 deposited in Bank C");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankA obj1 = new BankA();
            obj1.getBalance();

            BankB obj2 = new BankB();
            obj2.getBalance();

            BankC obj3 = new BankC();
            obj3.getBalance();

            Console.ReadKey();
        }
    }
    
}
