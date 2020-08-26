using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace copy_constructor
{
    class School
    {
        public int Roll_no,No;
        public string Name,na;
        
        //Instance Constructor
        public School(int R,string N)
        {
            Roll_no = R;
            Name = N;
        }


        //copy constructor
        public School(School S)
        {
            No = S.Roll_no;
            na = S.Name;
        }
        public void show()
        {
            Console.WriteLine("Roll number is: " + Roll_no);
            Console.WriteLine("Name is: " + Name);

        }
        public void show1()
        {
            Console.WriteLine("Roll number is: " + No);
            Console.WriteLine("Name is: " + na);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            School obj = new School(123, "Nikita");//Instance Constructor
            obj.show();
            School obj1 = new School(obj);//Copy constructor
            obj1.show1();
            Console.ReadKey();
            
        }
    }

    
}
