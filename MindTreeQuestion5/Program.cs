using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindTreeQuestion5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of both the arrays");
            int n1 = Convert.ToInt32(Console.ReadLine());
            int n2 = Convert.ToInt32(Console.ReadLine());
            double[] arr1 = new double[n1];
            double[] arr2 = new double[n2];
            Program Obj = new Program();
           arr1= Obj.GetArray(arr1, n1);
            arr2=Obj.GetArray(arr2, n2);
            
          double[] arr3= Obj.SumOfTwoArray(arr1, arr2);
            Console.WriteLine("Final Array is");
            for (int i = 0; i < arr3.Length; i++)
            {
                Console.WriteLine(arr3[i]);
                            }
            Console.ReadLine();

        }
        public double[] GetArray(double[] arr,int n)
        {
            Console.WriteLine("Enter elements of array");
            for(int i=0;i<n;i++)

            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return arr;
        }
        public double[] SumOfTwoArray(double[] arr1,double[] arr2)
        {
           int l1= Math.Min(arr1.Length, arr2.Length);
            int l2= Math.Max(arr1.Length, arr2.Length);
            double[] arr3= new double[l2];
          
            for (int i=0;i<l2;i++)
            {
                if (i < arr1.Length && i < arr2.Length)
                    arr3[i] = arr1[i] + arr2[i];
                else if (i < arr1.Length && i >= arr2.Length)
                    arr3[i] = arr1[i];
                else
                    arr3[i] = arr2[i];

                    
            }

            return arr3;
        }
    }
}
