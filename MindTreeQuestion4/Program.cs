using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindTreeQuestion4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size of the array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Program Obj = new Program();
            Console.WriteLine("Enter the elements of the array");
            for(int i=0;i<n;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Sum of Elements of the Array is "+Obj.SumOfArray(a));
            Console.ReadLine();
        }
        public int SumOfArray(int[] a)
        {
            int sum = 0;
            for (int i=0; i<a.Length;i++)
            {
                sum = sum + a[i];
            }
            return sum;
        }

    }
}
