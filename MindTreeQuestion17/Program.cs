using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindTreeQuestion17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String");
            string str = Console.ReadLine();
            for (int i = 0; i < str.Length; i++)
            {
                char ch = str[i];
                if (Char.IsUpper(ch))
                {
                   Console.Write(ch);
                }
            }
            Console.ReadLine();
        }
    }
}
