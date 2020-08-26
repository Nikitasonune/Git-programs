using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace more_oops5
{
    class Degree
    {
        public void getDegree()
        {
            Console.WriteLine("I got a degree");
        }
    }
    class Undergraduate:Degree
    {
        public void getDegree()
        {
            Console.WriteLine("I am Undergraduate");
        }
    }
    class Postgraduate : Degree
    {
        public void getDegree()
        {
            Console.WriteLine("I am Postgraduate");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Degree D = new Degree();
            D.getDegree();
            Undergraduate U = new Undergraduate();
            U.getDegree();
            Postgraduate P = new Postgraduate();
            P.getDegree();
            Console.ReadKey();
        }
    }
}
