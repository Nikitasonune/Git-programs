using System;

namespace Multiple_Interface
{
    //2.multiple interface (Implict Intreface)
     interface IToken
     {
          string Name();
     }
     interface IVisitable
     {
          void Accept(string n);
     }
     class Token : IToken, IVisitable
     {
         public string Name()
         {
             return "Hello frome name";
         }
         public void Accept(string n)
         {
             Console.WriteLine("name= " + n);
         }
     }
     class Program
     {
         static void Main(string[] args)
         {
             Token t = new Token();
             Console.WriteLine(t.Name());
             t.Accept("Nikita");
             Console.ReadKey();
         }
     }

}
