using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindTreeQuestion9
{
    class Program
    {
        static void Main(string[] args)
        {
            long[] a = new long[10];
            Program Obj = new Program();
            for(int i=0; i<10;i++)
            {
                a[i] = Convert.ToInt64(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
              bool result= Obj.IsPrime(a[i]);
                Console.WriteLine(a[i] +" "+result);
            }
            Console.WriteLine("Finished");
            Console.ReadLine(); 


        }
        public bool IsPrime(long n)
        {
            int c = 0;
            if (n == 0 || n == 1)
                return false;
            for (long i=2;i<=n/2;i++)
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
