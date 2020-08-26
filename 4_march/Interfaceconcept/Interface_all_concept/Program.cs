using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_all_concept
{

    //1.
    class Token
    {
        protected Token(string name)
        {
            Console.WriteLine("base class constructor: name= " + name);
        }
    }
    class commentToken : Token
    {
        public commentToken(string name): base(name)
        {
            Console.WriteLine("derived class constructor: name= " + name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            commentToken ct = new commentToken("Nikita");
            Console.ReadKey();
        }
    }



}
        

        



    





