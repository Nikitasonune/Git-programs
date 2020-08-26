using System;

namespace ThisKeyword
{
    //using this keyword
    class BankAccount
    {
        private string name;
        public void setname(string name)
        {
            this.name = name;
        }
        public void show()
        {
            Console.Write("name = " + name);
        }
    }
    class Program
    {
        static void Main(string[]args)
        {
            BankAccount obj = new BankAccount();
            obj.setname("Nikita");
            obj.show();
            Console.ReadKey();
        }
            
    }
}
