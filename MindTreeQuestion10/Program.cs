using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindTreeQuestion10
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            string result = "";
            for (int i = a; i <=b; i++)
            {
                if (IsPrime(i))
                {
                    result += i + ",";
                }
            }
            Console.WriteLine(result.Substring(0,result.Length-1));
            Console.ReadLine();

        }
       
        private static  bool IsPrime(int n)
        {
            int c = 0;
            if (n == 0 || n == 1)
                return false;
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    c++;
            }
            if (c == 0)
                return true;
            else
                return false;


        }

    }
}
