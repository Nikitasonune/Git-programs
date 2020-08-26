using System;

namespace DefaultConstructor
{
    //1.Default Constructor
      class BankAccount
      {
          public int actno;
          public BankAccount()
          {
              actno = 22;
          }
      }
      class Program
      {
          static void Main(string[] args)
          {
              BankAccount obj = new BankAccount();
              Console.WriteLine("Account Number= " + obj.actno);
              Console.ReadKey();
          }
      }

}
