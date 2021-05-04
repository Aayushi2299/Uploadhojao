using System;


namespace MindTreeQuestion16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size the of string array");
            int Size = Convert.ToInt32(Console.ReadLine());
            string[] StringArray = new string[Size];
            StringArray = InputArray(StringArray, Size);
            Console.WriteLine("Enter your Choice if you want to with bubble Sort Press 1 else Press 2");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                string[] BubbleSortedArray= BubbleSort(StringArray);
                PrintArrayElemets(BubbleSortedArray);
                
            }
            else if(choice==2)
            {
                string[] InsertionSortedArray = InsertionSort(StringArray);
                PrintArrayElemets(InsertionSortedArray);
            }
            else
            {
                Console.WriteLine("You Enterted wrong Choice");
                Console.ReadLine();
                Environment.Exit(0);
            }
        }

        private static void PrintArrayElemets(string[] SortedArray)
        {
            Console.WriteLine("Sorted Array");
            foreach (string elements in SortedArray)
            {
                Console.WriteLine(elements);
            }
            Console.ReadLine();
        }
        private static string[] InputArray(string[] StringArray, int size)
        {
            Console.WriteLine("Enter the elements of Array");
            for (int i = 0; i < size; i++)
            {
                StringArray[i] = Console.ReadLine();
            }
            return StringArray;
        }

        private static string[] BubbleSort(string[] a)
        {
            string temp;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j].CompareTo(a[i]) < 0)
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            return a;

        }

        private static string[] InsertionSort(string[] arr)
        {
            int i = 0, j = 0, n = arr.Length, flag = 0;
            string val = "";
            for (i = 1; i < n; i++)
            {
                val = arr[i];
                flag = 0;
                for (j = i - 1; j >= 0 && flag != 1;)
                {
                    if (String.Compare(val, arr[j]) < 0)
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
