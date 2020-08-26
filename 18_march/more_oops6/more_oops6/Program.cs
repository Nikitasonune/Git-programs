using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_oops6
{
    
    class Bank
    {
        public int amount;
        public int getBalance()
        {
            return 0;
        }
    }
    class BankA: Bank
    {
        public BankA(int a)
        {
            amount = a;
        }
        public int getBalance()
        {
            
            return amount;
        }
    }
    class BankB:Bank
    {
        public BankB(int b)
        {
            amount = b;
        }
        public int getBalance()
        {

            return amount;
        }
    }
    class BankC:Bank
    {
        public BankC(int c)
        {
            amount = c;
        }
        public int getBalance()
        {

            return amount;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            BankA obj1 = new BankA(1000);
            int result1 = obj1.getBalance();
            Console.WriteLine("Amount deposited " + result1);

            BankB obj2 = new BankB(1500);
            int result2 = obj2.getBalance();
            Console.WriteLine("Amount deposited " + result2);

            BankC obj3 = new BankC(2000);
            int result3 = obj3.getBalance();
            Console.WriteLine("Amount deposited " + result3);
            Console.ReadKey();
            
        }
    }
}
