using System;

namespace Multiple_Interface_ExplicitType_
{
    //3.(Explicit Interface)
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
          string IToken.Name()
         {
             return "Hello frome name";
         }
          void IVisitable.Accept(string n)
         {
             Console.WriteLine("name= " + n);
         }
     }
     class Program
     {
         static void Main(string[] args)
         {
             IToken t = new Token();
             Console.WriteLine(t.Name());

             IVisitable t1 = new Token();
             t1.Accept("Nikita");
             Console.ReadKey();
         }
     }

}
