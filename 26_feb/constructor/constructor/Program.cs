using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constructor
{

    //nested classes

     class BankAccount
     {
         public class Account
         {
             private string name;
             public void setname(string n)
             {
                 name = n;
                 Console.WriteLine("name is= " + name);
             }
         }
         public int actno;
         public void setactno(int a)
         {
             actno = a;
             Console.WriteLine("account number= " + actno);
         }
     }


     class Program
     {
         static void Main(string[] args)
         {
             BankAccount.Account obj = new BankAccount.Account();
             BankAccount obj1 = new BankAccount();

             obj.setname("Nikita");
             obj1.setactno(22);
             Console.ReadKey();

         }
     }

}
