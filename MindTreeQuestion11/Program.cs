using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindTreeQuestion11
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            switch(str)
            {
                case "triangle":
               int a, b;
                 a = Convert.ToInt32(Console.ReadLine());
                 b = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine((a*b)/2);
                break;
                case "rectangle":
                    int p, q;
                    p = Convert.ToInt32(Console.ReadLine());
                    q = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(p * q);
                    break;
                case "square":
                    int s;
                    s = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(s*s);
                    break;
                case "circle":
                    int r;
                    r = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(3.14*r*r);
                    break;
                default:
                    Console.WriteLine("Your choice is wrong");
                    break;
            }
            Console.ReadLine();

        }
    }
}
