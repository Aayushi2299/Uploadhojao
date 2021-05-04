using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindTreeQuestion13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter size of array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Enter Number to be searched");
            int num= Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            bool result=obj.LinearSearch(a, num);
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public bool LinearSearch(int[] a,int num)
        {
            int pos = -1;
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]==num)
                {
                    pos = i;
                    break;
                }
            }
            if (pos != -1)
                return true;
            else
                return false;
                    }
    }
}
