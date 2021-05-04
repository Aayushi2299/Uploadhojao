using System;


namespace MindTreeQuestion15
{
    class InsertionSort1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Size of the Array");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] Array = new int[n];
            InsertionSort1 Obj = new InsertionSort1();
            Console.WriteLine("Enter the Elements to be sorted");
           Array= Obj.InputArray(Array, n);
            int[] sortedArray = Obj.InsertionSort(Array);
            Console.WriteLine("Sorted Array");         
            foreach (int element in sortedArray)
            {
                Console.WriteLine(element);
            }

            Console.ReadLine();

        }
        public int[] InputArray(int[] Array,int n)
        {
            for(int i=0;i<n;i++)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine());
            }
            return Array;
        }
        public int[] InsertionSort(int[] arr)
        {
            int i = 0, j = 0, n = arr.Length, val = 0, flag = 0;
            for (i = 1; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (val < arr[j])
                    {
                        arr[j + 1] = arr[j];
                        j--;
                        arr[j + 1] = val;
                    }
                    else flag = 1;
                }
            }
            return arr;
        }
    }
}
