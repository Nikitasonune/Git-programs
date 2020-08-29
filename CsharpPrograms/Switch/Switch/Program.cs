using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, result, rev = 0, rem;
            Console.WriteLine("enter a number: ");
            n = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            result = obj.Convert(n);
            while (rev != 0)
            {
                rem = rev % 10;
                rev = rev / 10;

                switch (rem)
                {

                    case 1:
                        Console.WriteLine("one \t");
                        break;
                    case 2:
                        Console.WriteLine("two \t");
                        break;
                    case 3:
                        Console.WriteLine("three \t");
                        break;
                    case 4:
                        Console.WriteLine("four \t");
                        break;
                    case 5:
                        Console.WriteLine("five \t");
                        break;
                    case 6:
                        Console.WriteLine("six \t");
                        break;
                    case 7:
                        Console.WriteLine("seven \t");
                        break;
                    case 8:
                        Console.WriteLine("Eight \t");
                        break;
                    case 9:
                        Console.WriteLine("Nine \t");
                        break;
                }
                Console.ReadKey();
            }
        }
       public int convert(int num)
        {
            int dig, rev = 0, rem;
            while (num > 0)
            {
                rem = num % 10;
                num = num / 10;
                rev = rev * 10 + rem;
            }
        }
        return rev;  

        }
    }

