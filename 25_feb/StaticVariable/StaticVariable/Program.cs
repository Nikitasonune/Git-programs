using System;

namespace StaticVariable
{
    //4.using static variable
    class BankAccount
    {
        private static string name;
        public void setname(string name)
        {
            BankAccount.name = name;
        }
        public void show()
        {
            Console.Write("name = " + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount obj = new BankAccount();
            obj.setname("Nikita");
            obj.show();
            Console.ReadKey();
        }

    }
}
