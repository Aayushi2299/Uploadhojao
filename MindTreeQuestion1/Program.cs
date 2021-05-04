using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindTreeQuestion1
{
    class Program
    {
        public static void Main(string[] args)
        {
            int f = 1;
            int num = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=num;i++)
            {
                f = f * i;
            }
            Console.WriteLine("Factorial of a given Number is "+f);
            Console.ReadLine();


        }
    }
}