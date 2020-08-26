using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_11
{
    class Distance
    {
       public float sumInch = 0;
        public float sumFeet = 0;
        public void AddDistance(float inch1,float inch2,float feet1,float feet2 )
        {
            sumInch = inch1 + inch2;
            sumFeet = feet1 + feet2;
            if(sumInch>12)
            {
                sumInch = sumInch - 12;
                sumFeet = sumFeet + 1;
            }
            Console.WriteLine("Sum of Distance in inches are: " + sumInch);
            Console.WriteLine("Sum of Distance in feets are: " + sumFeet);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Distance D = new Distance();

            Console.WriteLine("Enter distance in feet 1   ");
            float feet1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter distance in feet 2   ");
            float feet2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter distance in inch 1   ");
            float inch1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter distance in inch 2  ");
            float inch2 = int.Parse(Console.ReadLine());

            
            D.AddDistance(inch1,inch2,feet1, feet2);
            Console.ReadKey();
        }
    }
}
