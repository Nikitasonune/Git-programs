using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_oops2
{
    class Sample
    {
        public void Print(int num,string str)
        {
            Console.WriteLine("number is: " +num +" " +"Name is: "+str);
        }
        public void Print(string str,int num)
        {
            Console.WriteLine("Name is: "+str +"  "+"number is: "+ num);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Sample S = new Sample();
            S.Print(5,"Nikita");
            S.Print("Nikita",5);
            Console.ReadKey();
        }
    }
}
