using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindTreeQuestion12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter size");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("enter elements");
            for(int i=0;i<n;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Program obj = new Program();
            obj.Bubble(a);
            Console.ReadLine();
        }
        public void Bubble(int[] a)
        {
            int temp;
            for(int i=0;i<a.Length;i++)
            {
                for(int j=0;j<a.Length-i-1;j++)
                {
                    if(a[j]>a[j+1])
                    {
                         temp = a[j+1];
                        a[j+1] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted array");
            for (int k = 0; k < a.Length; k++)
            {
                Console.WriteLine(a[k]);
            }

        }
    }
}
