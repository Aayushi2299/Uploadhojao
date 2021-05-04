using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindTreeQuestion3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num = Convert.ToInt32(Console.ReadLine());
            Program Obj = new Program();
            Obj.PrintPattern(Num);
        }
        public void PrintPattern(int Num)
        {
            int count = 0;
            while(Num!=1)
            {
                if (Num % 2 == 0)
                {
                    
                    Console.WriteLine(Num + " is even so i take half : " + Num / 2);
                    Num = Num / 2;
                }
                else
                {
                   
                    Console.WriteLine(Num + " is odd so i take 3n+1 : " + ((Num*3)+1));
                    Num = (Num * 3) + 1;
                }
                count++;
            }
            Console.WriteLine("There are total "+count+" steps to reach 1");
            Console.ReadLine();
        }
    }
}
