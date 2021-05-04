using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindTreeQuestion18
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Student name ");
            string str = Console.ReadLine();
            Console.WriteLine("Enter Age");
            int age = Convert.ToInt32(Console.ReadLine());
            string words = str[0]+"";
            for(int i=0;i<str.Length;i++)
            {
                if(i!=str.Length-1)
                {
                    if (str[i] == ' ')
                    {
                        words += str[i + 1];

                    }
                    else
                        continue;
                }
            }
            
            Console.WriteLine("Student Password "+ words + age.ToString());
            Console.ReadLine();
        }
    }
}
