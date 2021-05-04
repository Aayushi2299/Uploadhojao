using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindTreeQuestion14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your choice");
            Console.WriteLine("1.Binary search for Integer Elements");
            Console.WriteLine("2.Binary search for Strings");
            Console.WriteLine("3.Exit");
            int choice = Convert.ToInt32(Console.ReadLine());
            Program obj = new Program();
            if (choice==1)
            {
                Console.WriteLine("Enter the size of Integer Array");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] a = new int[n];
                Console.WriteLine("Enter the Elements of Array");
                for (int i = 0; i < n; i++)
                {
                    a[i] = Convert.ToInt32(Console.ReadLine());
                }
                a= obj.BubbleInteger(a);
                Console.WriteLine("Enter Number to be searched");
                int num = Convert.ToInt32(Console.ReadLine());
                bool result = obj.findElement(a, num);
                Console.WriteLine(result);
                Console.ReadLine();
            }
            else if(choice==2)
            {
                Console.WriteLine("Enter the size of String Array");
                int n = Convert.ToInt32(Console.ReadLine());
                string[] s = new string[n];
                Console.WriteLine("Enter the elements of Array");
                for (int i = 0; i < n; i++)
                {
                    s[i] = Console.ReadLine();
                }
                s = obj.BubbleString(s);
                Console.WriteLine("Enter String to be searched");
                string str = Console.ReadLine();
                bool result2 = obj.findString(s, str);
                Console.WriteLine(result2);
                Console.ReadLine();
            }
            else
            {
              Environment.Exit(0);
            }
        }
        public bool findElement(int[] a,int num)
        {
            int l = 0, u = a.Length - 1, mid, flag = 0;
            while(l<=u && flag==0)
            {
                mid = (l + u) / 2;
                if (a[mid] == num)
                {
                    flag = 1;
                    break;
                }
                else if (a[mid] > num)
                {
                    u = mid - 1;
                }
                else
                    l = mid + 1;
                          }
            if (flag == 1)
                return true;
            else
                return false;
        }
        public bool findString(string[] s,string str)
        {
            int l = 0, u = s.Length - 1, mid;
            while (l <= u)
            {
                mid = l + (u-l) / 2;
                int res=str.CompareTo(s[mid]);
                if (res==0)
                {
                    return true;
                }
               if (res > 0)
                {
                    l = mid + 1;
                }
                else
                    u = mid - 1;
            }
            return false;

        }
        public int[] BubbleInteger(int[] a)
        {
            int temp;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j + 1];
                        a[j + 1] = a[j];
                        a[j] = temp;
                    }
                }
            }
            return a;

        }
        public string[] BubbleString(string[] a)
        {
            string temp;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i+1 ; j < a.Length; j++)
                {
                    if (a[j].CompareTo(a[i]) < 0 )
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            return a;

        }
    }
}
