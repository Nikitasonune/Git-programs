using System;

namespace Array_Of_Object
{
    //3.array of object
     class Program
     {
         static void Main(string[] args)
         {
             BankAccount[] obj = new BankAccount[5];
             for(int i=0;i<5;i++)
             {
                 obj[i] = new BankAccount();
                 Console.WriteLine("enter name and amount: ");
                 obj[i].name = Console.ReadLine();
                 decimal amt = Convert.ToDecimal(Console.ReadLine());
                 Console.WriteLine("enter deposit or withdraw: ");
                 string t = Console.ReadLine();
                 //obj.interest = 500;
                 switch (t)
                 {
                     case "deposit":
                         obj[i].Deposit(obj[i].name, amt);
                         break;
                     case "withdraw":
                         obj[i].Withdraw(obj[i].name, amt);
                         break;
                     default:
                         Console.WriteLine("Invalid choice");
                         break;
                 }
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
